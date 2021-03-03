using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCaro1
{
    public class SoundGame
    {
        private static SoundPlayer sound;
        public static void soundGamePlay(string path) {
            sound = new SoundPlayer(Application.StartupPath + path);
           sound.Play();
        }
        public static void soundGameStop(string path) {
            sound = new SoundPlayer(Application.StartupPath + path);
            sound.Stop();

        }
        public static void soundGamePlayLoop(string path) {
            sound = new SoundPlayer(Application.StartupPath+path);
            sound.PlayLooping();

        }
    }
}
