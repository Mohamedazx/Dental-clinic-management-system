using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using dintist.forms;
using Dentist1;


namespace dintist.PL
{
    class pati
    {

        public void add_new_state(string new_state)
        {
            Dentist1.Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@state_name", SqlDbType.NVarChar);
            p[0].Value = new_state;
            ob.RUA("add_state", p);
            ob.close();

        }
        public DataTable View_patient_state()
        {
            DataTable dt = new DataTable();
            Dentist1.Dxl ob = new Dxl();
            ob.open();
            dt = ob.Reader("view_patient_state", null);
            ob.close();
            return dt;
        }
        
            public DataTable View_all_state()
        {
            DataTable dt = new DataTable();
            Dentist1.Dxl ob = new Dxl();
            ob.open();
            dt = ob.Reader("view_all_state", null);
            ob.close();
            return dt;
        }
        public void newpatient(int pat_id,
            string pat_tc,
            string pat_nam,
            string pat_age,
            string gen,
            string pho,
            string sta,
            DateTime dat,
            string emi,
            double cos,
            double pay,
            double rem,
            byte[] img,
            string com)
        {
            Dentist1.Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[14];
            p[0] = new SqlParameter("@patient_id", SqlDbType.Int);
            p[0].Value = pat_id;
            p[1] = new SqlParameter("@patient_tc", SqlDbType.NVarChar, 50);
            p[1].Value = pat_tc;
            p[2] = new SqlParameter("@patient_name", SqlDbType.NVarChar, 50);
            p[2].Value = pat_nam;
            p[3] = new SqlParameter("@patient_age", SqlDbType.Int);
            p[3].Value = pat_age;
            p[4] = new SqlParameter("@patient_gender", SqlDbType.NVarChar, 50);
            p[4].Value = gen;
            p[5] = new SqlParameter("@patient_phone", SqlDbType.NVarChar, 50);
            p[5].Value = pho;
            p[6] = new SqlParameter("@patient_state", SqlDbType.NVarChar, 50);
            p[6].Value = sta;
            p[7] = new SqlParameter("@patient_date", SqlDbType.Date);
            p[7].Value = dat;
            p[8] = new SqlParameter("@patient_email", SqlDbType.NVarChar,50);
            p[8].Value = emi;
            p[9] = new SqlParameter("@cost", SqlDbType.Float);
            p[9].Value = cos;
            p[10] = new SqlParameter("@paied", SqlDbType.Float);
            p[10].Value = pay;
            p[11] = new SqlParameter("@remind", SqlDbType.Float);
            p[11].Value = rem;
            p[12] = new SqlParameter("@patient_img", SqlDbType.Image);
            p[12].Value = img;
            p[13] = new SqlParameter("@comment", SqlDbType.NVarChar, 50);
            p[13].Value = com;
            ob.RUA("newpatients", p);
            ob.close();
        }
        public DataTable show_pati_id()
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            dt = ob.Reader("show_patient_id", null);
            ob.close();
            return dt;
        }
        public DataTable view_all_patients()
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            dt = ob.Reader("view_all_patients", null);
            ob.close();
            return dt;
        }

        public DataTable show_patient_img(int id)
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            SqlParameter[] p = new SqlParameter[1];
            p[0] =new SqlParameter("@patient_id", SqlDbType.Int);
            p[0].Value = id;
            ob.open();
            dt = ob.Reader("show_patient_img", p);
            ob.close();
            return dt;

        }
        public DataTable search_patient_info(string patient_name)
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@patient_name", SqlDbType.NVarChar,50);
            p[0].Value = patient_name;
            dt = ob.Reader("search_patient_info", p);
            ob.close();
            return dt;
        }

        public void update_patient_info(int pat_id,
            string pat_tc,
            string pat_nam,
            string pat_age,
            string gen,
            string pho,
            string sta,
            DateTime dat,
            string emi,
            double cos,
            double pay,
            double rem,
            byte[] img,
            string com)
        {
            Dentist1.Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[14];
            p[0] = new SqlParameter("@patient_id", SqlDbType.Int);
            p[0].Value = pat_id;
            p[1] = new SqlParameter("@patient_tc", SqlDbType.NVarChar, 50);
            p[1].Value = pat_tc;
            p[2] = new SqlParameter("@patient_name", SqlDbType.NVarChar, 50);
            p[2].Value = pat_nam;
            p[3] = new SqlParameter("@patient_age", SqlDbType.Int);
            p[3].Value = pat_age;
            p[4] = new SqlParameter("@patient_gender", SqlDbType.NVarChar, 50);
            p[4].Value = gen;
            p[5] = new SqlParameter("@patient_phone", SqlDbType.NVarChar, 50);
            p[5].Value = pho;
            p[6] = new SqlParameter("@patient_state", SqlDbType.NVarChar, 50);
            p[6].Value = sta;
            p[7] = new SqlParameter("@patient_date", SqlDbType.Date);
            p[7].Value = dat;
            p[8] = new SqlParameter("@patient_email", SqlDbType.NVarChar, 50);
            p[8].Value = emi;
            p[9] = new SqlParameter("@cost", SqlDbType.Float);
            p[9].Value = cos;
            p[10] = new SqlParameter("@paied", SqlDbType.Float);
            p[10].Value = pay;
            p[11] = new SqlParameter("@remind", SqlDbType.Float);
            p[11].Value = rem;
            p[12] = new SqlParameter("@patient_img", SqlDbType.Image);
            p[12].Value = img;
            p[13] = new SqlParameter("@comment", SqlDbType.NVarChar, 50);
            p[13].Value = com;
            ob.RUA("update_patient_info", p);
            ob.close();
        }
        public void delete_patient_info(int pat_id)
        {
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@p_ID", SqlDbType.Int);
            p[0].Value = pat_id;
            ob.RUA("delete_patient_info", p);
            ob.close();
        }
        public DataTable view_income()
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            dt = ob.Reader("view_income", null);
            ob.close();
            return dt;
        }
        public DataTable search_salary_date(DateTime d1, DateTime d2)
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[2];
            p[0] = new SqlParameter("@date1", SqlDbType.Date);
            p[0].Value = d1;
            p[1] = new SqlParameter("@date2", SqlDbType.Date);
            p[1].Value = d2;
            dt = ob.Reader("search_income", p);
            ob.close();
            return dt;
        }
        public void delete_state_info(string pat_id)
        {
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@p_ID", SqlDbType.NVarChar,50);
            p[0].Value = pat_id;
            ob.RUA("delete_state_info", p);
            ob.close();
        }

        public DataTable search_patient_date(DateTime d1, DateTime d2)
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[2];
            p[0] = new SqlParameter("@date1", SqlDbType.Date);
            p[0].Value = d1;
            p[1] = new SqlParameter("@date2", SqlDbType.Date);
            p[1].Value = d2;
            dt = ob.Reader("search_patient_date", p);
            ob.close();
            return dt;
        }
    }


}
