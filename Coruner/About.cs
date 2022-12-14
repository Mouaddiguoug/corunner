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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }
        string message = "Hello! and WELCOME to 'CORUNER' :D!\nCoRuner is a simple 2D Game inspired by the human fight against Coronavirus. \nUsed Techniques :\n- C# Language.\n- .net framework (WinForm).\n- Bunifu UI framework.\n- Siticone UI framework.\nProgrammed by : \n- Gourar Abderrahim \n- Diguoug Mouad\nThe game currently contains only one level :( \nBut we are considering adding more levels later :) \nThanks and Enjoy It <3!\n\nContact info:\n-Abderrahim.gourar54@gmail.com     +212642966972\n-mouaddigoug12@gmail.com           +212615107414";
        bool start; int i = 0;
        //----------------------------------
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
        //-------------------------------------

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(start == true)
            {
                if(i < message.Length)
                {
                    richTextBox1.Text += message[i]; 
                }
                i++; 
            }
        }

        private void About_Load(object sender, EventArgs e)
        {
            start = true;
            panel1.Focus();
            this.ActiveControl = panel1; 
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            ExitConfirm ec = new ExitConfirm();
            DialogResult dr = ec.ShowDialog();
            if (dr == DialogResult.Cancel)
            {
                timer1.Start();
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = new Home();
            home.Show();
        }
    }
}
