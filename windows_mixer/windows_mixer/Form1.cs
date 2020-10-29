using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using NAudio.CoreAudioApi;
using NAudio.Wave;

namespace windows_mixer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            MMDeviceEnumerator devEnum = new MMDeviceEnumerator();
            MMDevice defaultDevice = devEnum.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);

            Console.WriteLine("Render");
            for (int i = 0; i < WaveIn.DeviceCount; i++)
                Console.WriteLine(devEnum.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active)[i]);

            Console.WriteLine("Capture");
            for (int i = 0; i < WaveIn.DeviceCount; i++)
                Console.WriteLine(devEnum.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active)[i]);

            //clean up
            devEnum.Dispose();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MMDeviceEnumerator devEnum = new MMDeviceEnumerator();
            MMDevice defaultDevice = devEnum.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
            //string currVolume = "MasterPeakVolume : " + defaultDevice.AudioMeterInformation.MasterPeakValue.ToString();
            //Console.WriteLine(currVolume);
            volumeMeter1.Amplitude = defaultDevice.AudioMeterInformation.MasterPeakValue;

            //clean up
            devEnum.Dispose();
        }
    }
}

