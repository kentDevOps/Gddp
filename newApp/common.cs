using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio;
using NAudio.Wave;

namespace newApp
{
    internal class common
    {
        public static void phatAudio(string filePath)
        {
            
            using (var audioFileReader = new AudioFileReader(filePath))
            {
                // Xử lý audioFileReader ở đây, ví dụ: phát audio
                using (var outputDevice = new WaveOutEvent())
                {
                    outputDevice.Init(audioFileReader);
                    outputDevice.Play();

                    // Đợi cho đến khi phát xong
                    while (outputDevice.PlaybackState == PlaybackState.Playing)
                    {
                        System.Threading.Thread.Sleep(1000);
                    }
                }
            }
        }
    }
}
