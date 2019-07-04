using SDRSharp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SDRSharp.IllegalRadioDetect
{
    public class IllegalRadioDetectPlugin : ISharpPlugin
    {
        private const string DefaultDisplayName = "黑广播检测";

        private ISharpControl _control;
        private IllegalRadioDetectPanel _guiControl;

        public IllegalRadioDetectPlugin()
        {

        }

        #region ISharpPlugin

        public bool HasGui
        {
            get { return true; }
        }

        public UserControl GuiControl
        {
            get { return _guiControl; }
        }

        public string DisplayName
        {
            get { return DefaultDisplayName; }
        }

        public void Close()
        {
            if (_guiControl != null)
            {
                _guiControl.Close();
            }
        }

        public void Initialize(ISharpControl control)
        {
            _control = control;
            _guiControl = new IllegalRadioDetectPanel(_control);
        }

        #endregion

    }
}
