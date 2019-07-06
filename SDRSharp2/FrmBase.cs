using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SDRSharp2
{
    public partial class FrmBase : Form
    {
        public FrmBase()
        {
            InitializeComponent();

            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Skins\\WaveColor2.ssk");
        }
    }
}
