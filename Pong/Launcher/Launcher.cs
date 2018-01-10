using MetroFramework.Forms;
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
    public partial class Launcher : MetroForm
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
            timer1.Interval = 500;
            object i = comboBox1.SelectedItem;
            

                if (i.ToString() == "Native")
                {
                    GameThread = new Thread(() => Launch(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height));
                }
                else
                {
                    String[] Resolution = i.ToString().Split('x');
                    GameThread = new Thread(() => Launch(int.Parse(Resolution[0]), int.Parse(Resolution[1])));
                }


            GameThread.Start();
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (game.IsActive == false) this.Close();
            }
            catch (Exception)
            {

                //throw;
            }
                
        }

        public void Launch(int GameWidth, int GameHeight)
        {
            Game1.Resolution = new Microsoft.Xna.Framework.Vector2(GameWidth, GameHeight);
            Game1.isFullscreen = Fullscreen.Checked;           
            Global.PlayerSensitivity = (float)metroTrackBar1.Value / 100;

            game = new Game1();        
            game.Run();
        }

        private void Launcher_Load(object sender, EventArgs e)
        {
            this.Name = "Pong Launcher";
            comboBox1.SelectedIndex = 1;
            metroTrackBar1.Value = 50;
        }

        private void metroTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            TrackbarLabel.Text = metroTrackBar1.Value.ToString() + "%";
        }
    }
}
