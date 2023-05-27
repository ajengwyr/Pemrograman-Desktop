using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace TugasP6
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formUser = new FormUser();
            formUser.Show();
            formUser.Closed += (s, args) => this.Close();
            formUser.Show();
        }
    }
}
