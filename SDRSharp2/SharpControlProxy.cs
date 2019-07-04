using SDRSharp.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace SDRSharp2
{
    public class SharpControlProxy : ISharpControl, INotifyPropertyChanged
    {

        public SharpControlProxy()
        {

        }

        #region ISharpControl

        public SDRSharp.Radio.DetectorType DetectorType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public SDRSharp.Radio.WindowType FilterType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int AudioGain { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public long CenterFrequency { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int CWShift { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool FilterAudio { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool UnityGain { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int FilterBandwidth { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int FilterOrder { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool FmStereo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public long Frequency { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public long FrequencyShift { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool FrequencyShiftEnabled { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool MarkPeaks { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool SnapToGrid { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool SquelchEnabled { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int SquelchThreshold { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool IsSquelchOpen => throw new NotImplementedException();

        public bool SwapIq { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool UseAgc { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool AgcHang { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int AgcThreshold { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int AgcDecay { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int AgcSlope { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int FFTResolution => throw new NotImplementedException();

        public float FFTRange => throw new NotImplementedException();

        public float FFTOffset => throw new NotImplementedException();

        public int StepSize => throw new NotImplementedException();

        public bool IsPlaying => throw new NotImplementedException();

        public int SAttack { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int SDecay { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int WAttack { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int WDecay { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool UseTimeMarkers { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string RdsProgramService => throw new NotImplementedException();

        public string RdsRadioText => throw new NotImplementedException();

        public int RFBandwidth => throw new NotImplementedException();

        public bool SourceIsSoundCard => throw new NotImplementedException();

        public bool SourceIsWaveFile => throw new NotImplementedException();

        public bool SourceIsTunable => throw new NotImplementedException();

        public event PropertyChangedEventHandler PropertyChanged;

        public void GetSpectrumSnapshot(byte[] destArray)
        {
            throw new NotImplementedException();
        }

        public void RegisterStreamHook(object streamHook)
        {
            throw new NotImplementedException();
        }

        public void StartRadio()
        {
            throw new NotImplementedException();
        }

        public void StopRadio()
        {
            throw new NotImplementedException();
        }

        public void UnregisterStreamHook(object streamHook)
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}
