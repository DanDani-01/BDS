using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Agenda.Formularios
{
    public partial class FrmSplashScreen : Form
    {
        private SoundPlayer player;
        private Timer timer;
        public FrmSplashScreen()
        {
            InitializeComponent();
        }

        private void FrmSplashScreen_Load(object sender, EventArgs e)
        {
            this.Opacity = 1;
            player = new SoundPlayer();
            player.Play();

            timer = new Timer();
            timer.Interval = 5000;
            timer.Tick += Timer_Tick;
            timer.Start();

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.01;
            if (this.Opacity <= 0)
            {
                
                player.Stop();
                this.Hide();
                frmLogon Login = new frmLogon();
                Login.Show();
            }
            else
            {
                timer.Stop();
                frmLogon Login = new frmLogon();
                Login.Show();
                this.Hide();
            }
        }
    }
}
