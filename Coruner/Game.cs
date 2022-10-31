using Coruner.Properties;
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
using System.Windows.Input;

namespace Coruner
{
    public partial class Game : Form
    {
        bool goLeft, goRight, jumping, isGameOver;
        int jumpSpeed;
        int force;
        int Score = 0;
        int playerSpeed = 6;
        int horizontalSpeed = 5;
        int verticalSpeed = 3;
        int enemyOneSpeed = 4;
        int enemyTwoSpeed = 2;

        /////////////////////////////////////////////
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
        /////////////////////////////////////////////

        public Game()
        {
            InitializeComponent();
        }

        

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            gameTimer.Start();
            label_score.Text = Score.ToString();

            //CircleProgressBar1.Value = (Score / 29) * 100;
            playerSpeed = 6;
            player.Top += jumpSpeed;

            if (goLeft == true)
            {
                if(player.Left > 0)
                { 
                    if(jumping == true)
                    {
                        playerSpeed = 7;
                        player.Left -= playerSpeed ;
                    }
                    else { 
                    player.Left -= playerSpeed;
                    }
                }
            }
            if (goRight == true)
            {

                if(player.Left < 792)
                {
                    if (jumping == true)
                    {
                        playerSpeed = 7;
                        player.Left += playerSpeed;
                    }
                    else
                    {
                        player.Left += playerSpeed;
                    }
                }
            }
            if (jumping == true && force < 0)
            {
                jumping = false;
            }
            if (jumping == true)
            {
                jumpSpeed = -8;
                force -= 1;
            }
            else
            {
                jumpSpeed = 10;
            }

            if(Score == 29)
            {
                gateState.BackgroundImage = Resources.gate_open;
                labelGateIs.Text = "Open";
                labelGateIs.ForeColor = Color.Lime; 
            }
            else
            {
                gateState.BackgroundImage = Resources.gate_closed;
                labelGateIs.Text = "Closed";
                labelGateIs.ForeColor = Color.OrangeRed;
            }

            foreach (Control c in Controls)
            {
                if (c is PictureBox)
                {
                    if ((string)c.Tag == "platform")
                    {
                        if (player.Bounds.IntersectsWith(c.Bounds))
                        {
                            force = 8;
                            player.Top = c.Top - player.Height;
                            c.BringToFront();
                        }
                        c.BringToFront();

                        //if(player.Top < c.Top)
                        //{
                        //    jumping = false; 
                        //}

                    }
                    if ((string)c.Tag == "coins")
                    {
                        if (player.Bounds.IntersectsWith(c.Bounds) && c.Visible == true)
                        {
                            c.Visible = false;
                            Score++;
                        }
                    }
                    if ((string)c.Tag == "enemy")
                    {
                        if (player.Bounds.IntersectsWith(c.Bounds) && c.Visible == true)
                        {
                            gameTimer.Stop();
                            isGameOver = true;

                            YouLose yl = new YouLose();
                            DialogResult dr = yl.ShowDialog();
                            if (dr == DialogResult.Ignore)
                            {
                                Restart();
                            }
                            
                            //label_score.Text = "score :" + Score + Environment.NewLine + "vous aves perdu";
                        }
                    }
                }
            }
            horizontalPlatform.Left -= horizontalSpeed;
            if (horizontalPlatform.Left < 0 || horizontalPlatform.Left + horizontalPlatform.Width > 792)
            {
                horizontalSpeed = -horizontalSpeed;
            }
            verticalPlatform.Top -= verticalSpeed;
            if (verticalPlatform.Top < 280 || verticalPlatform.Top > 552)
            {
                verticalSpeed = -verticalSpeed;
            }
            enemyOne.Left -= enemyOneSpeed;
            if (enemyOne.Left < Platform5.Left || enemyOne.Left + enemyOne.Width > Platform5.Left + Platform5.Width)
            {
                enemyOneSpeed = -enemyOneSpeed;
            }
            enemyTwo.Left -= enemyTwoSpeed;
            if (enemyTwo.Left < Platform2.Left || enemyTwo.Left + enemyTwo.Width > Platform2.Left + Platform2.Width)
            {
                enemyTwoSpeed = -enemyTwoSpeed;
            }

            if (player.Top + player.Height > this.ClientSize.Height + 50)
            {
                gameTimer.Stop();
                isGameOver = true;

                YouLose yl = new YouLose();
                DialogResult dr = yl.ShowDialog();
                if (dr == DialogResult.Ignore)
                {
                    Restart();
                }
                

                //label_score.Text = "score :" + Score + Environment.NewLine + "vous aves perdu";
            }
            if (player.Bounds.IntersectsWith(door.Bounds) && Score == 29)
            {
                gameTimer.Stop();
                isGameOver = true;

                YouWin yw = new YouWin();
                DialogResult dr =  yw.ShowDialog();
                if(dr == DialogResult.Ignore)
                {
                    Restart(); 
                }
                
                
                //label_score.Text = "score :" + Score + Environment.NewLine + "vous aves gagne";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player.SizeMode = PictureBoxSizeMode.StretchImage;
            this.KeyPreview = true;
            this.Focus();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void Form1_PreviewKeyDown_1(object sender, PreviewKeyDownEventArgs e)
        {
            e.IsInputKey = true;
        }

        

        private void Exit_Click(object sender, EventArgs e)
        {
            gameTimer.Stop(); 
            ExitConfirm ec = new ExitConfirm();
            DialogResult dr = ec.ShowDialog();
            if (dr == DialogResult.Cancel)
            {
                gameTimer.Start();  
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = new Home();
            home.Show(); 
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
                player.Image = Resources.playerLeft;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
                player.Image = Resources.playerRight;
            }
            if (e.KeyCode == Keys.Space && jumping == false)
            {
                jumping = true; 
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
                 
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
                 
            }
            if (jumping == true)
            {
                jumping = false;
            }
            //if (e.KeyCode == Keys.Enter && isGameOver == true)
            //{
            //    Restart();
            //}
        }

        public void Restart()
        {
            jumping = false;
            goLeft = false;
            goRight = false;
            isGameOver = false;
            Score = 0;
            label_score.Text = "score : " + Score;

            foreach (Control c in this.Controls)
            {
                if (c is PictureBox && c.Visible == false)
                {
                    c.Visible = true;
                }
            }

            player.Left = 60;
            player.Top = 660;
            player.BackgroundImage = Resources.playerRight; 

            enemyOne.Left = 488;
            enemyTwo.Left = 518;

            horizontalPlatform.Left = 318;
            verticalPlatform.Top = 552;

           // CircleProgressBar1.Value = 0; 

            gameTimer.Start();
        }

    }
}
