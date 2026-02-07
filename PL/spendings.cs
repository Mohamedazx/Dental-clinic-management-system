using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Dentist1;

namespace dintist.PL
{
    class spendings
    {

        public void new_bill(int bill_id,
           string Amount,
           string comment,          
           DateTime date,         
           byte[] image)
        {
            Dentist1.Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[5];
            p[0] = new SqlParameter("@bill_id", SqlDbType.Int);
            p[0].Value = bill_id;
            p[1] = new SqlParameter("@Amount", SqlDbType.Int);
            p[1].Value = Amount;
            p[2] = new SqlParameter("@comment", SqlDbType.NVarChar, 50);
            p[2].Value = comment;
            p[3] = new SqlParameter("@date", SqlDbType.Date);
            p[3].Value = date;
            p[4] = new SqlParameter("@image", SqlDbType.Image);
            p[4].Value = image;
           
            ob.RUA("new_bill", p);
            ob.close();
        }

        public DataTable search_bill_date(DateTime d1, DateTime d2)
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[2];
            p[0] = new SqlParameter("@date1", SqlDbType.Date);
            p[0].Value = d1;
            p[1] = new SqlParameter("@date2", SqlDbType.Date);
            p[1].Value = d2;
            dt = ob.Reader("search_bill_date", p);
            ob.close();
            return dt;
        }

        public DataTable show_BILL_id()
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            dt = ob.Reader("show_bill_id", null);
            ob.close();
            return dt;
        }

        public DataTable view_all_bills()
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            dt = ob.Reader("view_all_bills", null);
            ob.close();
            return dt;
        }
        public void delete_bill_info(int bill_id)
        {
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@p_ID", SqlDbType.Int);
            p[0].Value = bill_id;
            ob.RUA("delete_bill_info", p);
            ob.close();
        }
        public DataTable show_biil_img(int id)
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@p_id", SqlDbType.Int);
            p[0].Value = id;
            ob.open();
            dt = ob.Reader("show_biil_img", p);
            ob.close();
            return dt;

        }
        public DataTable search_bill_info(string bill_info)
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@dates", SqlDbType.NVarChar, 50);
            p[0].Value = bill_info;
            dt = ob.Reader("search_bill", p);
            ob.close();
            return dt;
        }

    }
}
