using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coruner
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        //////////////////////////////////
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void SidePanel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        //////////////////////////////////

        private void Exit_Click(object sender, EventArgs e)
        {
            
            ExitConfirm ec = new ExitConfirm();
            DialogResult dr = ec.ShowDialog();
            if (dr == DialogResult.Cancel)
            {
                
            }
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            game.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; 
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            HowToPlay htp = new HowToPlay();
            htp.Show();
            this.Hide(); 
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            About abt = new About();
            abt.Show();
            this.Hide(); 
        }
    }
}
