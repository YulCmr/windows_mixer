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
//using NAudio.Wave;
using CSCore.CoreAudioAPI;
using Role = CSCore.CoreAudioAPI.Role;
using DataFlow = CSCore.CoreAudioAPI.DataFlow;
using AudioMeterInformation = CSCore.CoreAudioAPI.AudioMeterInformation;

namespace windows_mixer
{
    public partial class Form1 : Form
    {
        public List<Label> labels = new List<Label>();
        public List<NAudio.Gui.VolumeMeter> volumeMeters = new List<NAudio.Gui.VolumeMeter>();

        public Form1()
        {
            InitializeComponent();

            labels.Add(label1);
            labels.Add(label2);
            labels.Add(label3);
            labels.Add(label4);
            labels.Add(label5);
            labels.Add(label6);

            volumeMeters.Add(volumeMeter1);
            volumeMeters.Add(volumeMeter2);
            volumeMeters.Add(volumeMeter3);
            volumeMeters.Add(volumeMeter4);
            volumeMeters.Add(volumeMeter5);
            volumeMeters.Add(volumeMeter6);

            /*MMDeviceEnumerator devEnum = new MMDeviceEnumerator();
            MMDevice defaultDevice = devEnum.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);

            Console.WriteLine("Render");
            for (int i = 0; i < WaveIn.DeviceCount; i++)
                Console.WriteLine(devEnum.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active)[i]);

            Console.WriteLine("Capture");
            for (int i = 0; i < WaveIn.DeviceCount; i++)
                Console.WriteLine(devEnum.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active)[i]);

            //clean up
            devEnum.Dispose();*/

            backgroundWorker1.RunWorkerAsync();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*MMDeviceEnumerator devEnum = new MMDeviceEnumerator();
            MMDevice defaultDevice = devEnum.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
            //string currVolume = "MasterPeakVolume : " + defaultDevice.AudioMeterInformation.MasterPeakValue.ToString();
            //Console.WriteLine(currVolume);
            volumeMeter1.Amplitude = defaultDevice.AudioMeterInformation.MasterPeakValue;

            //clean up
            devEnum.Dispose();*/
        }

        private static AudioSessionManager2 GetDefaultAudioSessionManager2(DataFlow dataFlow)
        {
            using (var enumerator = new CSCore.CoreAudioAPI.MMDeviceEnumerator())
            {
                using (var device = enumerator.GetDefaultAudioEndpoint(dataFlow, Role.Multimedia))
                {
                    Console.WriteLine("DefaultDevice: " + device.FriendlyName);
                    var sessionManager = AudioSessionManager2.FromMMDevice(device);
                    return sessionManager;
                }
            }
        }
        

        private void set_label(int i, string app_name)
        {
            BeginInvoke(new EventHandler(delegate
            {
                labels[i].Text = app_name;
            }));
        }

        private void set_peak(int i, int peak)
        {
            BeginInvoke(new EventHandler(delegate
            {
                volumeMeters[i].Amplitude = peak;
            }));
        }

        
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int i, peak;
            string pName;
            while (true)
            {
                i = 0;
                using (var sessionManager = GetDefaultAudioSessionManager2(DataFlow.Render))
                {
                    using (var sessionEnumerator = sessionManager.GetSessionEnumerator())
                    {
                        foreach (var session in sessionEnumerator)
                        {
                            using (var session2 = session.QueryInterface<AudioSessionControl2>())
                            using (var audioMeterInformation = session.QueryInterface<AudioMeterInformation>())
                            {
                                peak = (int)audioMeterInformation.GetPeakValue()*100;
                                pName = session2.Process.ProcessName;
                                set_label(i, pName);
                                set_peak(i, peak);
                                //Console.WriteLine(session2.Process.MainWindowTitle);
                                //Console.WriteLine(session2.Process.ProcessName);
                                Console.WriteLine(audioMeterInformation.GetPeakValue()*100);
                                if (i < 6) i++;
                            }
                        }
                    }
                }
            }
        }
    }
}



