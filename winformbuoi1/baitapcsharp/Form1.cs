using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitapcsharp
{
    public partial class Form1 : Form
    {
        public DataTable DB { get; set; }
        public Form1()
        {
            InitializeComponent();
            createDB();
            getCBB();
        }
        //
        public void createDB()
        {
            //tao colums cho DB
            DB = new DataTable();
            DB.Columns.AddRange(new DataColumn[]{
                new DataColumn("MSSV", typeof(string)),
                new DataColumn("HVT", typeof(string)),
                new DataColumn("GT", typeof(bool)),
                new DataColumn("ngay sinh", typeof(DateTime)),
                new DataColumn("dia chi", typeof(string)),
                new DataColumn("sdt", typeof(string)),
                new DataColumn("lophp", typeof(string))


            });

            //tao Row(tao 3 row)
            DB.Rows.Add(new object[]
            {
                "102190202","NVA",true,DateTime.Now,"nghean","035","19tclc"
            });
            DB.Rows.Add(new object[]
            {
                "102190203","NVB",false,DateTime.Now,"Danana","035","19tclc"
            });
            DB.Rows.Add(new object[]
            {
                "102190204","NVC",true,DateTime.Now,"hanoi","035","19tclc"
            });
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btShow_Click(object sender, EventArgs e)
        {
            dataGridViewsv.DataSource = DB;
        }
        public void getCBB()
        {
            if (cbLop2 != null)
            {
                cbLop2.Items.Clear();
            }
            cbLop2.Items.Add("All");
            cbLop2.Items.AddRange(GetTenLopHP().Distinct().ToArray());
        }
        public List<string> GetTenLopHP()
        {
            List<string> data = new List<string>();
            foreach(DataRow i in DB.Rows)
            {
                data.Add(i["lophp"].ToString());

            }
            return data;
        }
    }
}
