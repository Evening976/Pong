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
            timer1.Interval = 1500;    
            GameThread = new Thread(new ThreadStart(Launch));
            GameThread.Start();
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (game.IsActive == false) this.Close();
        }

        public void Launch()
        {
            game = new Game1();
            game.Run();
        }
    }
}
