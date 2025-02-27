﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace SDRSharp.IllegalRadioDetect
{
    public enum WavSampleFormat
    {
        PCM8,
        PCM16,
        Float32
    }

    public struct WavFormatHeader
    {
        public UInt16 FormatTag;
        public UInt16 Channels;
        public UInt32 SamplesPerSec;
        public UInt32 AvgBytesPerSec;
        public UInt16 BlockAlign;
        public UInt16 BitsPerSample;

        public WavFormatHeader(WavSampleFormat format, ushort channels, uint sampleRate)
        {

            BitsPerSample = 0;
            FormatTag = 0;

            switch (format)
            {
                case WavSampleFormat.PCM8:
                    FormatTag = 1;
                    BitsPerSample = 8;
                    break;
                case WavSampleFormat.PCM16:
                    FormatTag = 1;
                    BitsPerSample = 16;
                    break;
                case WavSampleFormat.Float32:
                    FormatTag = 3;
                    BitsPerSample = 32;
                    break;

            }

            BlockAlign = (ushort)(channels * (BitsPerSample / 8));
            SamplesPerSec = sampleRate;
            Channels = channels;
            AvgBytesPerSec = sampleRate * BlockAlign;
        }
    }

    public unsafe class SimpleWavWriter
    {
        private const long MaxStreamLength = int.MaxValue;

        private readonly string _filename;
        private readonly WavFormatHeader _format;
        private readonly WavSampleFormat _wavSampleFormat;
        private BinaryWriter _outputWav;
        private BinaryWriter _outputPcm;

        private long _fileSizeOffs;
        private long _dataSizeOffs;
        private long _length;

        private byte[] _outputBuffer;

        private bool _isStreamFull;

        #region Public Propertites

        public WavSampleFormat SampleFormat
        {
            get { return _wavSampleFormat; }
        }

        public WavFormatHeader WaveFormat
        {
            get { return _format; }
        }

        public string FileName
        {
            get { return _filename; }
        }

        public long Length
        {
            get { return _length; }
        }

        public bool IsStreamFull
        {
            get { return _isStreamFull; }
        }

        #endregion

        public SimpleWavWriter(string filename, WavSampleFormat recordingFormat, uint sampleRate)
        {
            _filename = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filename);
            FileInfo fi = new FileInfo(_filename);
            if(!Directory.Exists(fi.Directory.FullName))
            {
                Directory.CreateDirectory(fi.Directory.FullName);
            }

            _wavSampleFormat = recordingFormat;
            _format = new WavFormatHeader(recordingFormat, 1, sampleRate);
        }

        #region Public Methods

        public void Open()
        {
            if (_outputWav == null)
            {
                _outputWav = new BinaryWriter(File.Create(_filename));
                WriteHeader();

                //return;
            }

            if (_outputPcm == null)
            {
                _outputPcm = new BinaryWriter(File.Create(_filename.Replace(".wav", ".pcm")));
            }

            //throw new InvalidOperationException("Stream already open");
        }

        public void Close()
        {
            if (_outputWav != null)
            {
                UpdateLength();

                _outputWav.Flush();
                _outputWav.Close();
                _outputWav = null;

                _outputBuffer = null;

                //return;
            }

            if (_outputPcm != null)
            {
                _outputPcm.Flush();
                _outputPcm.Close();
                _outputPcm = null;
            }

            //throw new InvalidOperationException("Stream not open");
        }

        public void Write(float* data, int length)
        {
            if (_outputWav != null)
            {
                //if (_isStreamFull)
                //{
                //    throw new InvalidOperationException("Stream full");
                //}

                switch (_wavSampleFormat)
                {
                    case WavSampleFormat.PCM8:
                        WritePCM8(data, length);
                        break;

                    case WavSampleFormat.PCM16:
                        WritePCM16(data, length);
                        break;

                    case WavSampleFormat.Float32:
                        WriteFloat(data, length);
                        break;
                }

                return;
            }

            throw new InvalidOperationException("Stream not open");
        }

        #endregion

        #region Private Methods

        private void WritePCM8(float* data, int length)
        {
            #region Buffer

            if (_outputBuffer == null || _outputBuffer.Length != (length * 2))
            {
                _outputBuffer = null;
                _outputBuffer = new byte[length * 2];
            }

            #endregion

            var ptr = data;

            for (var i = 0; i < length; i++)
            {
                _outputBuffer[(i * 2)] = (byte)((*ptr++ * 127.0f) + 128);
                _outputBuffer[(i * 2) + 1] = (byte)((*ptr++ * 127.0f) + 128);
            }

            WriteStream(_outputBuffer);
        }

        private void WritePCM16(float* data, int length)
        {
            #region Buffer

            if (_outputBuffer == null || _outputBuffer.Length != (length * sizeof(Int16) * 2))
            {
                _outputBuffer = null;
                _outputBuffer = new byte[length * sizeof(Int16) * 2];
            }

            #endregion

            var ptr = data;

            List<byte> left = new List<byte>();

            for (var i = 0; i < length; i++)
            {

                var leftChannel = (Int16)(*ptr++ * 32767.0f);
                var rightChannel = (Int16)(*ptr++ * 32767.0f);

                _outputBuffer[(i * 4)] = (byte)(leftChannel & 0x00ff);
                _outputBuffer[(i * 4) + 1] = (byte)(leftChannel >> 8);
                _outputBuffer[(i * 4) + 2] = (byte)(rightChannel & 0x00ff);
                _outputBuffer[(i * 4) + 3] = (byte)(rightChannel >> 8);

                left.Add((byte)(leftChannel & 0x00ff));
                left.Add((byte)(leftChannel >> 8));
            }

            WriteStream(left.ToArray());
        }

        private void WriteFloat(float* data, int length)
        {
            #region Buffer

            if (_outputBuffer == null || _outputBuffer.Length != (length * sizeof(float) * 2))
            {
                _outputBuffer = null;
                _outputBuffer = new byte[length * sizeof(float) * 2];
            }

            #endregion

            Marshal.Copy((IntPtr)data, _outputBuffer, 0, _outputBuffer.Length);

            WriteStream(_outputBuffer);
        }

        private void WriteStream(byte[] data)
        {
            if (_outputWav != null)
            {
                var toWrite = (int)Math.Min(MaxStreamLength - _outputWav.BaseStream.Length, data.Length);

                _outputWav.Write(data, 0, toWrite);

                _length += toWrite;
                UpdateLength();

                _isStreamFull = _outputWav.BaseStream.Length >= MaxStreamLength;
            }

            if (_outputPcm != null)
            {
                _outputPcm.Write(data, 0, data.Length);
            }
        }

        private void WriteHeader()
        {
            if (_outputWav != null)
            {
                WriteTag("RIFF");
                _fileSizeOffs = _outputWav.BaseStream.Position;
                _outputWav.Write((UInt32)0); //fs

                WriteTag("WAVE");

                WriteTag("fmt ");

                _outputWav.Write((UInt32)16);
                _outputWav.Write(_format.FormatTag);
                _outputWav.Write(_format.Channels);
                _outputWav.Write(_format.SamplesPerSec);
                _outputWav.Write(_format.AvgBytesPerSec);
                _outputWav.Write(_format.BlockAlign);
                _outputWav.Write(_format.BitsPerSample);

                WriteTag("data");
                _dataSizeOffs = _outputWav.BaseStream.Position;
                _outputWav.Write((UInt32)0);
            }
        }

        private void UpdateLength()
        {
            if (_outputWav != null)
            {
                _outputWav.Seek((int)_fileSizeOffs, SeekOrigin.Begin);
                _outputWav.Write((UInt32)(_outputWav.BaseStream.Length - 8));
                _outputWav.Seek((int)_dataSizeOffs, SeekOrigin.Begin);
                _outputWav.Write((UInt32)(_length));
                _outputWav.BaseStream.Seek(0, SeekOrigin.End);
            }
        }

        private void WriteTag(string tag)
        {
            var data = Encoding.ASCII.GetBytes(tag);
            _outputWav.Write(data, 0, data.Length);
        }

        #endregion
    }
}
