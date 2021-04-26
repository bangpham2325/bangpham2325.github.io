using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace brCSDL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            // su dung ham dung co tham so
            string s = @"Data Source=LAPTOP-TAT7V0QC\SQLEXPRESS;Initial Catalog=QLSV1;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(s);
            //truyen tham so vao
            //SqlConnection cnn = new SqlConnection();
            //cnn.ConnectionString=@"Data Source=LAPTOP-TAT7V0QC\SQLEXPRESS;Initial Catalog=QLSV1;Integrated Security=True";
            //cnn.Open();//mo ket noi
            //kiem tra da ket noi chua
            //MessageBox.Show(cnn.State.ToString());//tra ve open la da duoc;
            //cnn.Close();//dong ket noi
            //command -> sqlCommand // thuc hien de tuong tac voi CSDL // CRUD
            // cach1
            //string query1 = "Select count(*) from SinhVien";
            //cach 2
            //string query = "delete dbo.SinhVien where MSSV =2";
            string query ="select * from SinhVien";

            //SqlCommand cmd = new SqlCommand();// cmd de thuc thi cac cau lenh .. day la ham dung mac dinh
            SqlCommand cmd = new SqlCommand(query, cnn);
            //cmd.Connection = cnn;// tuong tac voi csdl cnn
            //cmd.CommandType=//viec tuong tac thong qua cac chuoi string : co the la ca lenh query, co the la trigger
            //mac dich la query
            // cmd.CommandText = "Select count(*) from SinhVien";// chua thuc hien
            // cnn.Open();
            //cmd.ExecuteScalar();// tra ve cac ban ghi bi tac dong -> trong truong hop khong thay doi ban ghui
            // su dung voi cau lenh select count(*) from ,dem so ban ghi
            //cach 1
            // int n = (int)cmd.ExecuteScalar();// tra ve kieu object nen phai ep kieu
            //MessageBox.Show(n.ToString());
            //cach 2
            //cmd.ExecuteNonQuery();//tra ve cac ban ghi bi tac dong-> thay doi du lieu ban ghi
            // insert delete va update
            //ccah 3
            //cmd.ExecuteReader();// cau lenh select ...where-> tra ve doi tuong DataReader -> mang nhieu row(1 ban ghi)
            // SqlDataReader r= cmd.ExecuteReader();
            // doc tu row dau den row cuoi
            //while (r.Read())
            //{
            //    comboBox1.Items.Add(new CCBBItem
            //    {
            //        Value = Convert.ToInt32(r["MSSV"].ToString()),
            //        Text = r["HoTen"].ToString()
            //    });
            //    //string n = r["MSSV"].ToString();
            //    //comboBox1.Items.Add(n);
            //}

            //cnn.Close();
            //cach 4
            //Dataset -> mang nhieu DataTable, anh xa toan bo cossodulieu ra dataset
            //cau noi trung gian de do csdl ra : CDDL<--> DataSet
            //SqlDataAdapter  Fill: do du lieu tu CSDL ra DataSet
            //Update : dong bo dulieu tu DataSet ve CSDL// tu tim hieu
            SqlDataAdapter da = new SqlDataAdapter(cmd);// ham dung mac dinh// neu ham dung co tham so thi tham so se la sqlCommand
            DataSet ds = new DataSet();
            // hoawc dung data table
            //DataTable dt = new DataTable();
            cnn.Open();
            //da.Fill(ds)
            //da.Fill(dt);//sau do gans datasourch cho datatable
           da.Fill(ds,"SV");//dat ten cho table
            cnn.Close();
            //dataGridView1.DataSource = ds.Tables[0];//tra ve table trong ds, lay datatable dau tien de do du lieu vao
            //ngat ket noi nhung du lieu van ton tai con datareader thi khong
            dataGridView1.DataSource = ds.Tables["SV"];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex >= 0)
            {
                string s = ((CCBBItem)comboBox1.SelectedItem).Value.ToString() + ((CCBBItem)comboBox1.SelectedItem).Text;//doi tuong duoc lua chon
                MessageBox.Show(s);
            }
            
        }
        //Insert,Delete,Update giong nhau khac nhau ve cau lenh query
        public void InitDB(string query)
        {
            string s = @"Data Source=LAPTOP-TAT7V0QC\SQLEXPRESS;Initial Catalog=QLSV1;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(s);
            SqlCommand cmd = new SqlCommand(query, cnn);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //query la cau lenh Insert SinhVien
            string query1 = "insert SinhVien (MSSV,HoTen,gioiTinh) values (6,N'bang2',1)";
            InitDB(query1);
            string s = @"Data Source=LAPTOP-TAT7V0QC\SQLEXPRESS;Initial Catalog=QLSV1;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(s);
            string query = "select * from SinhVien";
            SqlCommand cmd = new SqlCommand(query, cnn);
            
            SqlDataAdapter da = new SqlDataAdapter(cmd);// ham dung mac dinh// neu ham dung co tham so thi tham so se la sqlCommand
            DataSet ds = new DataSet();
            cnn.Open();
            da.Fill(ds, "SV");//dat ten cho table
            cnn.Close();

            dataGridView1.DataSource = ds.Tables["SV"];
        }
        public DataTable GetDL(string query)
        {
            string s = @"Data Source=LAPTOP-TAT7V0QC\SQLEXPRESS;Initial Catalog=QLSV1;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(s);
            //string query = "select * from SinhVien";
            SqlCommand cmd = new SqlCommand(query, cnn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);// ham dung mac dinh// neu ham dung co tham so thi tham so se la sqlCommand
            //DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            cnn.Open();
            da.Fill(dt);//
            cnn.Close();
            return dt;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string query = "select * from SinhVien";
            DataTable dt1 = GetDL(query);
            foreach(DataRow i in dt1.Rows)
            {
                comboBox1.Items.Add(
                    new CCBBItem
                    {
                        Value = Convert.ToInt32(i["MSSV"].ToString()),
                        Text = i["HoTen"].ToString()
                    }
                    );
            }
            string query2 = "select * from SinhVien";
            DataTable dt2 = GetDL(query2);
            dataGridView1.DataSource = dt2;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string s = @"Data Source=LAPTOP-TAT7V0QC\SQLEXPRESS;Initial Catalog=QLSV1;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(s);
            string query = "select * from SinhVien";
            SqlCommand cmd = new SqlCommand(query, cnn);
            DataTable dt = new DataTable();
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
            dataGridView1.DataSource = dt;
        }
        public void show()
        {
            string s = @"Data Source=LAPTOP-TAT7V0QC\SQLEXPRESS;Initial Catalog=QLSV1;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(s);
            string query = "select * from SinhVien";
            SqlCommand cmd = new SqlCommand(query, cnn);
            DataTable dt = new DataTable();
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
            dataGridView1.DataSource = dt;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            string s = @"Data Source=LAPTOP-TAT7V0QC\SQLEXPRESS;Initial Catalog=QLSV1;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(s);
            SqlCommand cmd = new SqlCommand(textBox1.Text, cnn);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
            show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DBHelper.Instance.ExecuteDB(textBox1.Text);
            string query = "select * from SinhVien";
            dataGridView1.DataSource = DBHelper.Instance.getRecords(query);
        }
    }
}
