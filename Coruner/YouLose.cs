using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coruner
{
    public partial class YouLose : Form
    {
        public YouLose()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {

            ExitConfirm ec = new ExitConfirm();
            DialogResult dr = ec.ShowDialog();
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btn_Replay_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Ignore;
            this.Close();
        }

        private void YouLose_Load(object sender, EventArgs e)
        {
            button_focus.Focus();
            this.ActiveControl = button_focus; 
        }
    }
}
