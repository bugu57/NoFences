using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.Remoting;
using System.Text;
using System.Windows.Forms;

namespace NoFences
{
    public partial class OpacityDialog : Form
    {
        public OpacityDialog(double oldOpacity)
        {
            InitializeComponent();
            trackBarOpacity.Value = (int)(oldOpacity * 100);
        }

        public double NewOpacity => (trackBarOpacity.Value) / 100.0;

        private void trackBarOpacity_ValueChanged(object sender, EventArgs e)
        {
            lblOpacityValue.Text = trackBarOpacity.Value.ToString();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
