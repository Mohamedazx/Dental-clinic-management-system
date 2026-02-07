using dintist.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dintist.forms
{
    public partial class ALL_state : Form
    {
        public ALL_state()
        {
            InitializeComponent();
            Patients_state_constractor();
        }
        dintist.PL.pati ob = new dintist.PL.pati();
        DataTable dt = new DataTable();
        public void Patients_state_constractor()
        {

            dt = ob.View_all_state();
            dgv.DataSource = dt;

            dgv.Columns[0].Width = 150;
            dgv.Columns[1].Width = 150;
           



           




        }
        private void ALL_state_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
           
        }
        
        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            DialogResult DG = MessageBox.Show("Are You cure ??? ", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DG == DialogResult.Yes)
            {
                ob.delete_state_info(Convert.ToString(this.dgv.CurrentRow.Cells[0].Value));
                Patients_state_constractor();
            }
            else if (DG == DialogResult.No)
            {
                return;
            }
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            home f = new home();
            f.Show();
            this.Hide();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            new_state f = new new_state();
            f.Show();
            this.Hide();
        }
    }
}
