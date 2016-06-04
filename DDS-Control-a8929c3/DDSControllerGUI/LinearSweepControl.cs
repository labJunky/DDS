using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DDSControl
{
    public partial class LinearSweepControl : UserControl, ILinearSweepSetting
    {
        public LinearSweepControl()
        {
            InitializeComponent();
        }

        public LinearSweepSetting LinearSweepSetting { get { return getLinearSweepSetting(); } }

        private LinearSweepSetting getLinearSweepSetting()
        {
            LinearSweepSetting setting = new LinearSweepSetting();
            setting.StartFreq = Convert.ToDouble(startFreqTextBox.Text);
            setting.StopFreq = Convert.ToDouble(stopFreqTextBox.Text);
            setting.DeltaFreq = Convert.ToDouble(deltaFreqTextBox.Text);
            setting.DeltaTime = Convert.ToDouble(deltaTimeTextBox.Text);

            return setting;
        }
    }
}


