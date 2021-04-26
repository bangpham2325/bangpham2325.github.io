using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT03_102190202.DAL
{
    class DBHelper
    {

        private static SqlConnection cnn;
        private static DBHelper _Instance;

        public static DBHelper Instance
        {
            get
            {
                if (_Instance == null)
                {
                    string cnnstr = @"Data Source=LAPTOP-TAT7V0QC\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True";
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
            
                SqlCommand cmd = new SqlCommand(query, cnn);
                // ham dung mac dinh// neu ham dung co tham so thi tham so se la sqlCommand
                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            
        }
        //select data
        public DataTable getRecords(string query)
        {
                // DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(query, cnn);
                //DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                cnn.Open();
                da.Fill(dt);
                cnn.Close();
                return dt;
            
        }
    }
}
