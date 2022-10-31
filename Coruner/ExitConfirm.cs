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
    public partial class ExitConfirm : Form
    {
        public ExitConfirm()
        {
            InitializeComponent();
        }

        private void btn_Replay_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close(); 
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
