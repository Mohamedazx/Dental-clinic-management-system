using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentist1
{
    class Dxl
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        
        SqlConnection cn;
        DataTable dt = new DataTable();

        public Dxl()  /*  باني افتراضي لاجل بناء اتصال */
        {
           // cn = new SqlConnection("server=192.168.1.20,1433;Initial Catalog=Dentist;  User ID=hosny;Password=Hosnyaz123");
           cn = new SqlConnection("Data Source=DESKTOP-1IGTKVJ\\SQLEXPRESS;Initial Catalog=Dentist;Integrated Security=True");
           
            /*"server=192.168.1.10,1433;Initial Catalog=Dentist;  User ID=hosny;Password=Hosnyaz123"*/

        }

        public void open()
{
  if (cn.State == ConnectionState.Closed)
  {
      cn.Open();
  }
}

public void close()
{
  if (cn.State == ConnectionState.Open)
  {
      cn.Close();
  }
}
// لقراءة البيانات من قاعدة البيانات
public DataTable Reader(string sp, SqlParameter[] p)
{
  cmd = new SqlCommand();
  cmd.CommandType = CommandType.StoredProcedure;
  cmd.CommandText = sp;
  cmd.Connection = cn;
  if (p != null)
  {
      cmd.Parameters.AddRange(p);
  }
  da = new SqlDataAdapter(cmd);
  da.Fill(dt);
  return dt;


}
//Remove ,Update ,Add
public void RUA(string sp, SqlParameter[] p)
{
  cmd = new SqlCommand();
  cmd.CommandType = CommandType.StoredProcedure;
  cmd.CommandText = sp;
  cmd.Connection = cn;
  if (p != null)
  {
      cmd.Parameters.AddRange(p);
  }
  cmd.ExecuteNonQuery();

}
}
}
