using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class DataProvider
    {
        public SqlConnection cn = new SqlConnection();

        public void Ketnoi()
        {
            try
            {
                if (cn.State == 0)
                {
                    cn.ConnectionString = @"Data Source=NGUYEN-THANH-PH\SQLEXPRESS;Initial Catalog=Project_Apple3;Integrated Security=True";
                    cn.Open();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void Ngatketnoi()
        {
            if (cn.State != 0)
            {
                cn.Close();
            }
        }

        // Hiển thị Dữ Liệu DataGridview

    

        //Phương thức truy vấn dữ liệu: Insert, Update, Delete
   

        public SqlDataReader getdata(string sql)
        {
            Ketnoi();
            SqlCommand cmd = new SqlCommand(sql, cn);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }


        public int Insert(string sql)
        {
            Ketnoi();
            SqlCommand cmd = new SqlCommand(sql, cn);
            int count = cmd.ExecuteNonQuery();
            Ngatketnoi();
            return count;
        }
        public int Update(string sql)
        {
            Ketnoi();
            SqlCommand cmd = new SqlCommand(sql, cn);
            int count = cmd.ExecuteNonQuery();
            Ngatketnoi();
            return count;
        }
        public int Delete(string sql)
        {
            Ketnoi();
            SqlCommand cmd = new SqlCommand(sql, cn);
            int count = cmd.ExecuteNonQuery();
            Ngatketnoi();
            return count;
        }


        public Int64 GetDataScalar(string sql)
        {
            Ketnoi();
            SqlCommand cmd = new SqlCommand(sql, cn);
            object data = cmd.ExecuteScalar();
            Int64 count = Convert.ToInt64(data);
            Ngatketnoi();
            return count;
        }

        public object GetDataScalarObj(string sql)
        {
            Ketnoi();
            SqlCommand cmd = new SqlCommand(sql, cn);
            object data = cmd.ExecuteScalar();
            Ngatketnoi();
            return data;
        }
        public Int64 GetTong(string sql)
        {
            try
            {
                return this.GetDataScalar(sql);
            }
            catch
            {
                return 0;
            }

        }
        public string GetMaxPNId(string sql)
        {

            try
            {
                Object maxPNId = this.GetDataScalarObj(sql);
                return Convert.ToString(maxPNId);
            }
            catch
            {
                return "";
            }
        }
    }

}
