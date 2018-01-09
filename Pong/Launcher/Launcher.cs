using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong.Launcher
{
    public partial class Launcher : Form
    {
        Thread GameThread;
        public Game1 game;

        public Launcher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Create a new game hide the window
            this.Hide();
            object i = comboBox1.SelectedItem;
            timer1.Interval = 500;


            #region The Big if
            if (checkBox1.Checked == true)
            {
                if (i.ToString() == "Native")
                {
                    GameThread = new Thread(() => Launch(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, true));
                }
                else if (i.ToString() == "1080p")
                {

                    GameThread = new Thread(() => Launch(1920, 1080, true));
                }
                else if (i.ToString() == "720p")
                {

                    GameThread = new Thread(() => Launch(1280, 720, true));
                }
            }
            else if(checkBox1.Checked == false)
            {
                if (i.ToString() == "Native")
                {
                    GameThread = new Thread(() => Launch(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, false));
                }
                else if (i.ToString() == "1080p")
                {

                    GameThread = new Thread(() => Launch(1920, 1080, false));
                }
                else if (i.ToString() == "720p")
                {

                    GameThread = new Thread(() => Launch(1280, 720, false));
                }
            }

            #endregion


            GameThread.Start();
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (game.IsActive == false) this.Close();
        }

        public void Launch(int GameWidth, int GameHeight, bool fullscreen)
        {
            Game1.Resolution = new Microsoft.Xna.Framework.Vector2(GameWidth, GameHeight);
            Game1.isFullscreen = fullscreen;

            game = new Game1();        
            game.Run();
        }
    }
}
