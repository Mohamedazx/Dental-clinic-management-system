using dintist.PL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using dintist.forms;

namespace dintist.forms
{
    public partial class new_state : Form
    {
        pati ob = new pati();
        public new_state()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            ob.add_new_state(search.Text);
            MessageBox.Show("doctor has been saved ...", "saving the doctor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void bunifuThinButton22_Click_1(object sender, EventArgs e)
        {
            ALL_state f = new ALL_state();
            f.Show();
            this.Hide();
        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
