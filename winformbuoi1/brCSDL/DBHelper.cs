using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brCSDL
{

    class DBHelper
    {
        
        private SqlConnection cnn;
        private static  DBHelper _Instance;

        public static DBHelper Instance
        {
            get
            {
                if(_Instance == null)
                {
                    string cnnstr = @"Data Source=LAPTOP-TAT7V0QC\SQLEXPRESS;Initial Catalog=QLSV1;Integrated Security=True";
                    _Instance = new DBHelper(cnnstr);
                }
                return _Instance;
            }
            private set { }
        }
        private DBHelper(string query)
        {
            cnn = new SqlConnection(query);
        }
        //insert ,delete,update
        public void ExecuteDB(string query)
        {
            try
            {
                
                    SqlCommand cmd = new SqlCommand(query, cnn);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);// ham dung mac dinh// neu ham dung co tham so thi tham so se la sqlCommand

                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    cnn.Close();
            }
            catch (Exception)
            {
            }
        }
        //select
        public DataTable getRecords(string query)
        {
            try
            {
                // DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                
                SqlCommand cmd = new SqlCommand(query, cnn);
                dt.Columns.AddRange(new DataColumn[]
                {
                 new DataColumn("MSSV",typeof(string)),
                new DataColumn("Ten",typeof(string))
                });
                cnn.Open();
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    DataRow dr = dt.NewRow();
                    dr["MSSV"] = r["MSSV"];
                    dr["Ten"] = r["HoTen"];
                    dt.Rows.Add(dr);
                }
                return dt;
            }
            catch
            {
                return null;
            }
        }
        public DataTable GetRecords1(string query)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query,cnn);
            cnn.Open();
            da.Fill();
            cnn.Close();
            return dt;
        }
}
