using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DDSControl
{
    public partial class SweepUserControl : UserControl, ISweepSetting
    {
        public SweepUserControl()
        {
            InitializeComponent();
        }

        public SweepSetting SweepSetting { get { return getSweepSetting(); } }

        private SweepSetting getSweepSetting()
        {
            SweepSetting setting = new SweepSetting();
            setting.Channel = Convert.ToInt32(sweepChannelComboBox.Text);
            setting.AmplitudeScaleFactor = Convert.ToInt32(ampTextBox.Text);
            setting.StartFreq = Convert.ToDouble(startFreqTextBox.Text);
            setting.StopFreq = Convert.ToDouble(stopFreqTextBox.Text);
            setting.Rate = Convert.ToDouble(rateTextBox.Text);
            return setting;
        }


        

    }
}
