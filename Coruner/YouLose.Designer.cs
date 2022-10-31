namespace Coruner
{
    partial class YouLose
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Exit = new Siticone.UI.WinForms.SiticoneButton();
            this.btn_Replay = new Siticone.UI.WinForms.SiticoneButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_focus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(37, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(467, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "You didn\'t Survive the Coronavirus!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Engravers MT", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.label1.Location = new System.Drawing.Point(115, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 47);
            this.label1.TabIndex = 2;
            this.label1.Text = "You Lose!";
            // 
            // btn_Exit
            // 
            this.btn_Exit.CheckedState.Parent = this.btn_Exit;
            this.btn_Exit.CustomImages.Parent = this.btn_Exit;
            this.btn_Exit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(77)))), ((int)(((byte)(64)))));
            this.btn_Exit.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.btn_Exit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Exit.HoveredState.Parent = this.btn_Exit;
            this.btn_Exit.Image = global::Coruner.Properties.Resources.appbar_power;
            this.btn_Exit.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_Exit.Location = new System.Drawing.Point(274, 490);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.ShadowDecoration.Parent = this.btn_Exit;
            this.btn_Exit.Size = new System.Drawing.Size(275, 60);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Replay
            // 
            this.btn_Replay.CheckedState.Parent = this.btn_Replay;
            this.btn_Replay.CustomImages.Parent = this.btn_Replay;
            this.btn_Replay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(77)))), ((int)(((byte)(64)))));
            this.btn_Replay.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.btn_Replay.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Replay.HoveredState.Parent = this.btn_Replay;
            this.btn_Replay.Image = global::Coruner.Properties.Resources.appbar_refresh_counterclockwise_down;
            this.btn_Replay.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_Replay.Location = new System.Drawing.Point(0, 490);
            this.btn_Replay.Name = "btn_Replay";
            this.btn_Replay.ShadowDecoration.Parent = this.btn_Replay;
            this.btn_Replay.Size = new System.Drawing.Size(275, 60);
            this.btn_Replay.TabIndex = 4;
            this.btn_Replay.Text = "Replay";
            this.btn_Replay.Click += new System.EventHandler(this.btn_Replay_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Coruner.Properties.Resources.loss_job_illustration_23_2148581492;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(71, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(398, 317);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // button_focus
            // 
            this.button_focus.Location = new System.Drawing.Point(560, 263);
            this.button_focus.Name = "button_focus";
            this.button_focus.Size = new System.Drawing.Size(75, 23);
            this.button_focus.TabIndex = 6;
            this.button_focus.Text = "button1";
            this.button_focus.UseVisualStyleBackColor = true;
            this.button_focus.Visible = false;
            // 
            // YouLose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(550, 550);
            this.Controls.Add(this.button_focus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Replay);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "YouLose";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "YouLose";
            this.Load += new System.EventHandler(this.YouLose_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Siticone.UI.WinForms.SiticoneButton btn_Exit;
        private Siticone.UI.WinForms.SiticoneButton btn_Replay;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_focus;
    }
}