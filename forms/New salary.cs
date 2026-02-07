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

using System.Data.SqlClient;
using System.Threading;
using System.Globalization;
using System.IO;


namespace dintist.forms
{
    public partial class New_salary : Form
    {
        
        public void salary_Manegment_constractor()
        {
            PL.Salarys ob = new PL.Salarys();

            dt = ob.view_all_salarys();
            dgb.DataSource = dt;

            dgb.Columns[0].Width = 100;
            
            dgb.Columns[1].Width = 300;
            dgb.Columns[2].Width = 200;
            dgb.Columns[3].Width = 300;
            dgb.Columns[4].Width = 300;
            dgb.Columns[5].Width = 200;

            dgb.Columns[2].DefaultCellStyle.Format = "c";
            dgb.Columns[3].DefaultCellStyle.Format = "c";
            dgb.Columns[5].DefaultCellStyle.Format = "c";
            dgb.AllowUserToAddRows = false;

           // Thread.CurrentThread.CurrentCulture = new CultureInfo("ar-US");

        }
        PL.Salarys ob = new PL.Salarys();
        DataTable dt = new DataTable();
       
        public New_salary()
        {
            InitializeComponent();
            salary_Manegment_constractor();
            dt = ob.show_salary_id();
            salary_id.Text = dt.Rows[0][0].ToString();
            

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
        }

        private void total_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (salary.Text == "")
                {
                    Incentives.Text = "0";

                }
                else
                {
                   

                    if (Incentives.Text == "")
                    {
                        total.Text = salary.Text;
                        Incentives.Text = "0";
                    }
                    else
                    {

                        total.Text = Convert.ToString(Convert.ToInt32(salary.Text) + Convert.ToInt32(Incentives.Text));
                    }
                }
                if (Incentives.Text == "")
                {
                    salary.Text = total.Text;
                }
            }
            catch
            {
                return;
            }
        }

        private void Incentives_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (salary.Text == "")
                {
                    total.Text = salary.Text = "0";

                }
                else
                {

                    if (Incentives.Text == "")
                    {
                        total.Text = salary.Text;
                    }
                    else
                    {

                        total.Text = Convert.ToString(Convert.ToInt32(salary.Text) + Convert.ToInt32(Incentives.Text));
                    }
                }
                if (Incentives.Text == "")
                {
                    salary.Text = total.Text;
                }
            }
            catch
            {
                return;
            }
        }

        private void salary_OnValueChanged(object sender, EventArgs e)
        {
            try
            {

                if (salary.Text == "")
                {
                    total.Text = salary.Text = "0";

                }
                else
                {

                    if (Incentives.Text == "")
                    {
                        total.Text = salary.Text;
                    }
                    else
                    {

                        total.Text = Convert.ToString(Convert.ToInt32(salary.Text) + Convert.ToInt32(Incentives.Text));
                    }
                }
                if (Incentives.Text == "")
                {
                    salary.Text = total.Text;
                }
            }
            catch
            {
                return;
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            
        }

        private void New_salary_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton29_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            salary_Manegment_constractor();
        }

        private void dgb_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton210_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            dt = ob.search_salary_date(Convert.ToDateTime(d1.Value), Convert.ToDateTime(d2.Value));
            this.dgb.DataSource = dt;
            Double x = 0;
            for (int i = 0; i < dgb.Rows.Count; i++)
            {
                x += Convert.ToDouble(dgb.Rows[i].Cells[5].Value);

            }
            totalamo.Text = x.ToString();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {

            try
            {


                ob.new_salary(
                    int.Parse(salary_id.Text), staff_name.Text, Convert.ToString(salary.Text), Convert.ToString(Incentives.Text), Convert.ToDateTime(date.Value.ToString()), Convert.ToString(total.Text));
                MessageBox.Show("A New Salary Has Been Add Successfully...", "Adding New Salary", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dt = ob.show_salary_id();
                salary_id.Text = dt.Rows[0][0].ToString();
                salary_Manegment_constractor();
                staff_name.Text = ""
;
                salary.Text = ""
;
                Incentives.Text = "";


            }
            catch
            {
                MessageBox.Show("pleas enter fall info ...", "Adding New Salary", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void bunifuThinButton22_Click_1(object sender, EventArgs e)
        {
            home f = new home();
            f.Show();
            this.Hide();
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            spending f = new spending();
            f.Show();
            this.Hide();
        }

        private void bunifuThinButton211_Click(object sender, EventArgs e)
        {
            DialogResult DG = MessageBox.Show("Are You cure ??? ", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DG == DialogResult.Yes)
            {
                ob.delete_salary_info(Convert.ToInt32(this.dgb.CurrentRow.Cells[0].Value));
                salary_Manegment_constractor();
            }
            else if (DG == DialogResult.No)
            {
                return;
            }
        }

        private void bunifuThinButton28_Click(object sender, EventArgs e)
        {
            salary_Manegment_constractor();
        }
    }
}
