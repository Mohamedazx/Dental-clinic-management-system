using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using dintist.forms;

namespace dintist.forms
{
    public partial class patients : Form
    {
        dintist.PL.pati ob = new dintist.PL.pati();
        DataTable dt = new DataTable();

        string gender;
        public patients()
        {
            InitializeComponent();
            label1.Text = DateTime.Now.ToShortDateString();
            label2.Text = DateTime.Now.ToShortTimeString();

             comboBox_state.DataSource = ob.View_patient_state();
             comboBox_state.DisplayMember = "state_name";
             comboBox_state.ValueMember = "state_name";

            text_tc.Text = "1";

            dt = ob.show_pati_id();
            text_id.Text = dt.Rows[0][0].ToString();

        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
             this.Hide();
        }

        private void add_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true)
            {
                gender = "male";
            }
            else
            {
                gender = "famale";
            }

            byte[] img;
            MemoryStream ms1 = new MemoryStream();
            pti_img.Image.Save(ms1, pti_img.Image.RawFormat);
            img = ms1.ToArray();

            try
            {
                ob.newpatient(int.Parse(text_id.Text), text_tc.Text, text_name.Text, Convert.ToString(txt_patient_age.Text), gender,
                        txt_phone.Text, comboBox_state.SelectedValue.ToString(), Convert.ToDateTime(date.Value.ToShortDateString()), text_email.Text,
                        Convert.ToDouble(cost.Text), Convert.ToDouble(text_pay.Text), Convert.ToDouble(text_rem.Text), img, com.Text);
                MessageBox.Show("a new patient has been add successfully...", "adding new patient", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch
            {
                MessageBox.Show("pleas enter fall info ...", "adding new patient", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }

        private void patients_Load(object sender, EventArgs e)
        {
            /*  dt = ob.search_patient_info(Convert.ToString(text_name));
           patients_Manegment.deleg.dgp.DataSource = dt;

           patients_Manegment p = new patients_Manegment();
           p.Show();*/
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            OpenFileDialog x = new OpenFileDialog();
            x.Filter = "Images File :|*.jpg;*.gif;*.Bmb;*.png";
            if (x.ShowDialog() == DialogResult.OK)
            {
                pti_img.Image = Image.FromFile(x.FileName);
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                gender = "male";
            }
            else
            {
                gender = "famale";
            }


            byte[] img;
            MemoryStream ms1 = new MemoryStream();
            pti_img.Image.Save(ms1, pti_img.Image.RawFormat);
            img = ms1.ToArray();

            try
            {

                ob.update_patient_info(int.Parse(text_id.Text), text_tc.Text, text_name.Text, Convert.ToString(txt_patient_age.Text), gender,
                        txt_phone.Text, comboBox_state.SelectedValue.ToString(), Convert.ToDateTime(date.Value.ToShortDateString()), text_email.Text,
                        Convert.ToDouble(cost.Text), Convert.ToDouble(text_pay.Text), Convert.ToDouble(text_rem.Text), img, com.Text);

                MessageBox.Show("تم التعديل بنجاح...", "update  patient", MessageBoxButtons.OK, MessageBoxIcon.Information);

               // this.Close();
            }

            catch
            {

                MessageBox.Show("برجاء ادخال البينات الصحيحه..", "update  patient", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }

            patients_Manegment.deleg.dgp.DataSource = dt;
            dt = ob.view_all_patients();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            new_state f = new new_state();
            f.Show();
        }

        private void cost_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cost.Text == "")
                {
                    text_rem.Text = cost.Text;
                }
                else
                {
                    text_rem.Text = "0";

                    text_rem.Text = Convert.ToString(Convert.ToInt32(cost.Text) - Convert.ToInt32(text_pay.Text));
                }
            }
            catch
            {
                return;
            }
        }

        private void text_pay_TextChanged(object sender, EventArgs e)
        {
            try
            {
                text_rem.Text = Convert.ToString(Convert.ToInt32(cost.Text) - Convert.ToInt32(text_pay.Text));
            }
            catch
            {
                return;
            }
        }

        private void text_rem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                text_rem.Text = Convert.ToString(Convert.ToDouble(cost.Text) - Convert.ToDouble(text_pay.Text));
            }
            catch
            {
                return;
            }
        }

        private void delet_Click(object sender, EventArgs e)
        {
            try
            {

                ob.delete_patient_info(Convert.ToInt32(text_id.Text));
                MessageBox.Show("Patient was deleted");
            }
            catch
            {
                return;
            }
        }

        private void text_pay_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (text_pay.Text == " ")
                {
                    text_rem.Text = cost.Text;
                }
            }
            catch
            {
                return;
            }
        }

        private void comboBox_state_MouseHover(object sender, EventArgs e)
        {
            comboBox_state.DataSource = ob.View_patient_state();
            comboBox_state.DisplayMember = "state_name";
            comboBox_state.ValueMember = "state_name";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
