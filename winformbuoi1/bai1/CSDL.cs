using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{

    class CSDL
    {
        public DataTable SV { get; set; }
        public DataTable LopSH { get; set; }
        public string cnnString { get; set; }
        private static CSDL _instance;
        public static CSDL instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CSDL();

                }
                return _instance;

            }
            private set
            {

            }
        }
        //public CSDL()
        //{
        //    SV = new DataTable();

        //    SV.Columns.Add("MSSV", typeof(int));
        //    SV.Columns.Add("Name", typeof(string));
        //    SV.Columns.Add("Gender", typeof(bool));
        //    SV.Columns.Add("NS", typeof(DateTime));
        //    SV.Columns.Add("Id_lop", typeof(int));

        //    DataRow d = SV.NewRow();
        //    d["MSSV"] = 1;
        //    d["Name"] = "bang";
        //    d["Gender"] = true;
        //    d["NS"] = DateTime.Now;
        //    d["Id_lop"] = 1;
        //    DataRow d1 = SV.NewRow();
        //    d1["MSSV"] = 2;
        //    d1["Name"] = "duong";
        //    d1["Gender"] = true;
        //    d1["NS"] = DateTime.Now;
        //    d1["Id_lop"] = 2;
        //    DataRow d2 = SV.NewRow();
        //    d2["MSSV"] = 3;
        //    d2["Name"] = "Tuan";
        //    d2["Gender"] = false;
        //    d2["NS"] = DateTime.Now;
        //    d2["Id_lop"] = 3;

        //    SV.Rows.Add(d);
        //    SV.Rows.Add(d1);
        //    SV.Rows.Add(d2);
        //    LopSH = new DataTable();
        //    LopSH.Columns.Add("Id_lop", typeof(int));
        //    LopSH.Columns.Add("NameLop", typeof(string));
        //    DataRow l = LopSH.NewRow();
        //    l["Id_lop"] = 1;
        //    l["NameLop"] = "19TCLC_DT1";
        //    DataRow l1 = LopSH.NewRow();
        //    l1["Id_lop"] = 2;
        //    l1["NameLop"] = "19TCLC_DT2";
        //    DataRow l2 = LopSH.NewRow();
        //    l2["Id_lop"] = 3;
        //    l2["NameLop"] = "19TCLC_DT3";
        //    DataRow l3 = LopSH.NewRow();
        //    l3["Id_lop"] = 4;
        //    l3["NameLop"] = "19TCLC_DT4";
        //    DataRow l4 = LopSH.NewRow();
        //    l4["Id_lop"] = 5;
        //    l4["NameLop"] = "19TCLC_DT5";
        //    DataRow l5 = LopSH.NewRow();
        //    l5["Id_lop"] = 6;
        //    l5["NameLop"] = "19TCLC_DT6";
        //    LopSH.Rows.Add(l);
        //    LopSH.Rows.Add(l1);
        //    LopSH.Rows.Add(l2);
        //    LopSH.Rows.Add(l3);
        //    LopSH.Rows.Add(l4);
        //    LopSH.Rows.Add(l5);


        //}
        //public void AddDataRowSV(SV s)
        //{
        //    DataRow d = SV.NewRow();
        //    d["MSSV"] = s.MSSV;
        //    d["Name"] = s.Name;
        //    d["Gender"] = s.Gender;
        //    d["NS"] = s.NS;
        //    d["Id_lop"] = s.Id_lop;
        //    SV.Rows.Add(d);

        //}
        //public void EditDataRowSV(SV s)
        //{
        //    //
        //    for(int i = 0; i < SV.Rows.Count; i++)
        //    {
        //        if (SV.Rows[i]["MSSV"].Equals(s.MSSV))
        //        {
        //            SV.Rows[i]["Name"] = s.Name;
        //            SV.Rows[i]["Gender"] = s.Gender;
        //            SV.Rows[i]["NS"] = s.NS;
        //            SV.Rows[i]["Id_lop"] = s.Id_lop;
        //            break;

        //        }
        //    }

        //}
        //public void DeleteDataRow(int MSSV)
        //{
        //    //
        //    for (int i = 0; i < SV.Rows.Count; i++)
        //    {
        //        if (SV.Rows[i]["MSSV"].Equals(MSSV))
        //        {
        //            SV.Rows.RemoveAt(i);
        //            break;

        //        }
        //    }

        //}
        private CSDL()
        {
            cnnString = @"Data Source=LAPTOP-TAT7V0QC\SQLEXPRESS;Initial Catalog=QLSV1;Integrated Security=True";
        }
        //insert ,delete,update
        public bool ExecuteDB(string query)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(cnnString))
                {
                    SqlCommand cmd = new SqlCommand(query, cnn);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);// ham dung mac dinh// neu ham dung co tham so thi tham so se la sqlCommand

                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        //select
        public DataTable getRecords(string query)
        {
            try
            {
                // DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                using(SqlConnection cnn = new SqlConnection(cnnString))
                {
                    SqlCommand cmd = new SqlCommand(query, cnn);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);// ham dung mac dinh// neu ham dung co tham so thi tham so se la sqlCommand

                    cnn.Open();
                    da.Fill(dt);
                    cnn.Close();
                    return dt;
                }
            }
            catch
            {
                return null;
            }
        }

    }
}
