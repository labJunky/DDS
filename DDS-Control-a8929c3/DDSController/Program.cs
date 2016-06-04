using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CyUSB;

namespace DDSControl
{
    class Program
    {

        static void Main(string[] args)
        {

            //AD9958 selectedDDS = ddsList[0];

            int channel = 0;
            int amplitude = 683;
            double freq = 25e6;
            double startFreq = 5e6;
            double stopFreq = 30e6;
            double rate = 3.333e6;

            dds myDDS = new dds();

            if (args == null)
            {
                Console.WriteLine("args is null"); // Check for null array
            }
            else
            {
                Console.Write("args length is ");
                Console.WriteLine(args.Length); // Write array length

                //Select which output type is required
                switch (args[0])
                {
                    case "singletone":
                        if (args.Length != 4)
                        {
                            Console.WriteLine("Please provide the correct arguments for this function");
                            break;
                        }
                        else
                        {
                            Int32.TryParse(args[1], out channel);
                            Int32.TryParse(args[2], out amplitude);
                            Double.TryParse(args[3], out freq);
                            myDDS.singletone(channel, amplitude, freq);
                            break;
                        }
                    case "sweep":
                        if (args.Length != 6)
                        {
                            Console.WriteLine("Please provide the correct arguments for this function");
                            break;
                        }
                        Int32.TryParse(args[1], out channel);
                        Int32.TryParse(args[2], out amplitude);
                        Double.TryParse(args[3], out startFreq);
                        Double.TryParse(args[4], out stopFreq);
                        Double.TryParse(args[5], out rate);
                        myDDS.sweep(channel, amplitude, startFreq, stopFreq, rate);
                        break;
                    default:
                        //nothing
                        break;
                }

            }
            //Console.ReadLine();
            //string bytesWritten = myDDS.sweep(channel, amplitude, startFreq, stopFreq, rate);

        }

        

    }

    class dds
    {

        USBDeviceList deviceList;
        List<AD9958> ddsList;

        public dds()
        {
            initializeDeviceList();
            refreshDeviceListBox();
        }

        private void initializeDeviceList()
        {
            // Chose all USB Devices with the generic CyUSB driver
            // The argument of the constructor is a mask saying
            // just that.
            deviceList = new USBDeviceList(CyConst.DEVICES_CYUSB);
            ddsList = new List<AD9958>();

            deviceList.DeviceAttached += new EventHandler(deviceAttached);
            deviceList.DeviceRemoved += new EventHandler(deviceRemoved);
        }

        private void deviceAttached(object sender, EventArgs e)
        {
            refreshDeviceListBox();
        }

        private void deviceRemoved(object sender, EventArgs e)
        {
            refreshDeviceListBox();
        }

        private void refreshDeviceListBox()
        {
            foreach (USBDevice dev in deviceList)
            {
                //deviceListBox.Items.Add(String.Format("{0} / {1}", dev.Product, dev.SerialNumber));
                ddsList.Add(new AD9958(new DDSUSBChip(dev as CyUSBDevice)));
                Console.WriteLine(dev.SerialNumber);
            }
        }

        public void singletone(int channel, int amplitude, double freq)
        {
            AD9958 selectedDDS = ddsList[0];
            selectedDDS.MasterReset();

            //Set a saftely limit for the rf amplifier for evaporative cooling NTU.
            if (amplitude > 400) { amplitude = 400; }

            selectedDDS.SetFrequency(channel, amplitude, freq);
        }

        public string sweep(int channel, int amplitude, double startFreq, double stopFreq, double rate)
        {
            AD9958 selectedDDS = ddsList[0];
            selectedDDS.MasterReset();

            //Set a saftely limit for the rf amplifier for evaporative cooling NTU.
            if (amplitude > 400) { amplitude = 400; }

            string bytesWritten = selectedDDS.SetLinearSweep2(channel, amplitude, startFreq, stopFreq, rate);
            return bytesWritten;

        }

        public void test(double rate)
        {
            Console.WriteLine("The rate for this sweep is: ");
            Console.WriteLine(rate); // Write index
            Console.WriteLine(" MHz/s");
        }

        public void test(int channel, int amplitude, double freq)
        {
            Console.WriteLine("The singletone channel is: ");
            Console.WriteLine(channel); // Write index
            Console.WriteLine("Amplitude is: ");
            Console.WriteLine(amplitude); // Write index
            Console.WriteLine("Frequency: ");
            Console.WriteLine(freq); // Write index
            Console.WriteLine(" MHz");
        }

    }
}
