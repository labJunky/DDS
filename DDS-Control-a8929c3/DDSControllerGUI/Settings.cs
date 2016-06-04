using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDSControl
{
    public class ModulationSetting
    {
        public int Channel;
        public string Mode;
        public int Levels;
        public List<double> ChannelWords;
    }

    public class ChannelSetting
    {
        public int Channel;
        public int AmplitudeScaleFactor;
        public double Frequency;
        public double Phase;

        public ChannelSetting()
        {
            Channel = 0;
            AmplitudeScaleFactor = 660;
            Frequency = 0;
            Phase = 0;               
        }
    }

     public class SweepSetting
     {
         public int Channel = 0;
         public int AmplitudeScaleFactor = 660;
         public double Phase;
         public double StartFreq;
         public double StopFreq;
         public double Rate;

         public SweepSetting()
         {
             Channel = 0;
             AmplitudeScaleFactor = 660;
             Phase = 0;
             StartFreq = 1e6;
             StopFreq = 10e6;
             Rate = 1e+6;
          }
     }

    public class LinearSweepSetting
    {
        public int Channel = 0;
        public int AmplitudeScaleFactor = 660;
        public double Phase;
        public double StartFreq;
        public double StopFreq;
        public double DeltaFreq;
        public double DeltaTime;

        public LinearSweepSetting()
        {
            Channel = 0;
            AmplitudeScaleFactor = 660;
            Phase = 0;
            StartFreq = 1e6;
            StopFreq = 10e6;
            DeltaFreq = 1.6;
            DeltaTime = 160e-9;
        }
    }
}
