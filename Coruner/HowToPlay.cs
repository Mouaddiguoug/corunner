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
    public partial class HowToPlay : Form
    {
        public HowToPlay()
        {
            InitializeComponent();
        }

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

        int i = 0;
        int j = 3;
        bool move, revers; 
        bool move1, move2, move3;
        bool revers1, revers2, revers3; 
        private void HowToPlay_Load(object sender, EventArgs e)
        {
            //967; 602
            //31

            

            GroupBox1.Left = 1000;
            GroupBox2.Left = 1000;
            GroupBox3.Left = 1000;

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = new Home();
            home.Show();
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            i++;
            j--; 
            move = true;
            revers = false; 
            switch(i)
            {
                case 1: move1 = true; move2 = false; move3 = false; break;
                case 2: move2 = true; move1 = false; move3 = false; break;
                case 3: move3 = true; move1 = false; move2 = false; break;
            }

        }

        private void prev_btn_Click(object sender, EventArgs e)
        {
            i--;
           
            move = false;
            revers = true;

            switch(j)
            {
                case 2: revers1 = true; revers2 = false; revers3 = false; break;
                case 1: revers2 = true; revers1 = false; revers3 = false; break;
                case 0: revers3 = true; revers1 = false; revers2 = false; break;
            }

            j++;

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AnnimationTimer(object sender, EventArgs e)
        {
            if(i == 0)
            {
                prev_btn.Enabled = false; 
            }
            else
            {
                prev_btn.Enabled = true;
            }

            if (i >= 3)
            {
                next_btn.Enabled = false;
            }
            else
            {
                next_btn.Enabled = true;
            }

            //-------------------------------------------

            if(move == true)
            { 
                if (move1 == true)
                {
                    if (Logo.Left > -700)
                    {
                    
                        Logo.Left -= 50;
                    }
                    if(GroupBox1.Left > 100)
                    {
                    
                        GroupBox1.Left -= 50; 
                    }
                }
                

                //---------------------------------------
                if (move2 == true)
                {
                    if (GroupBox1.Left > -700)
                    {

                        GroupBox1.Left -= 50;
                    }
                    if (GroupBox2.Left > 100)
                    {

                        GroupBox2.Left -= 50;
                    }
                }
                


                //-----------------------------------------
                if (move3 == true)
                {
                    if (GroupBox2.Left > -700)
                    {

                        GroupBox2.Left -= 50;
                    }
                    if (GroupBox3.Left > 100)
                    {

                        GroupBox3.Left -= 50;
                    }
                }
                
            }
            //-------------------------------------------//
            ////////////////////////////////////////////////
            //____________________________________________//
            if (revers == true)
            {
                if (revers1 == true)
                {
                    if (Logo.Left < 100)
                    {
                        Logo.Left += 50;
                    }
                    if (GroupBox1.Left < 1000)
                    {
                        GroupBox1.Left += 50;
                    }
                }



                //____________________________________________//
                if (revers2 == true)
                {
                    if (GroupBox1.Left < 100)
                    {
                        GroupBox1.Left += 50;
                    }
                    if (GroupBox2.Left < 1000)
                    {
                        GroupBox2.Left += 50;
                    }
                }


                //____________________________________________//
                if (revers3 == true)
                {
                    if (GroupBox2.Left < 100)
                    {
                        GroupBox2.Left += 50;
                    }
                    if (GroupBox3.Left < 1000)
                    {
                        GroupBox3.Left += 50;
                    }
                }
            }

        }
    }
}
