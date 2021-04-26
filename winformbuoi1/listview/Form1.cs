using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            createCol();
            createRow();
            view();
        }
        //add colum
        public void createCol()
        {
            ColumnHeader c1 = new ColumnHeader();
            c1.Text = "MSSV";
            ColumnHeader c2 = new ColumnHeader();
            c2.Text = "Name SV";
            ColumnHeader c3 = new ColumnHeader();
            c3.Text = "Lop SH";
            //addrange add 1 mang
            listView1.Columns.AddRange(new ColumnHeader[] { c1, c2, c3 });
        }
        //anh row
        public void createRow()
        {
            ListViewItem i1 = new ListViewItem();
            i1.Text = "102190202";
            ListViewItem.ListViewSubItem sb1 = new ListViewItem.ListViewSubItem();
            sb1.Text = DateTime.Now.ToString();
            ListViewItem.ListViewSubItem sb2 = new ListViewItem.ListViewSubItem();
            sb2.Text = "19tclc";
            i1.SubItems.AddRange(new ListViewItem.ListViewSubItem[] { sb1, sb2 });
            listView1.Items.Add(i1);
            ListViewItem i2 = new ListViewItem();
            i2.Text = "102190202";
            
            i2.SubItems.AddRange(new ListViewItem.ListViewSubItem[] { sb1, sb2 });
            listView1.Items.Add(i2);

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //tra ve cac row duoc lua chon
            //multiselect chon duoc nhieu row
            ListView.SelectedListViewItemCollection r = listView1.SelectedItems;
            string a = "";
            foreach(ListViewItem i in r)
            {
                a +="Mssv: " + i.Text +"NAme: " + i.SubItems[1].Text+"lop: " + i.SubItems[2].Text;
            }
            MessageBox.Show(a);

        }
        public void view()
        {
            sv[] arr = new sv[]
            {
                new sv{masv="101",ten="nva",genDer=true},
                new sv{masv="101",ten="nva",genDer=true},
                new sv{masv="101",ten="nva",genDer=true}
            };
            DataTable d = new DataTable();
            d.Columns.Add("MSSV", typeof(string));
            d.Columns.Add("Ten", typeof(string));
            d.Columns.Add("Gender", typeof(bool));
            //de dr co 3 row nhu d
            DataRow dr = d.NewRow();
            dr["MSSV"] = "1001";
            dr["Ten"] = "Nva";
            dr["Gender"] = true;
            DataRow dr1 = d.NewRow();
            dr1["MSSV"] = "1002";
            dr1["Ten"] = "Nvb";
            dr1["Gender"] = false;
            d.Rows.Add(dr);
            d.Rows.Add(dr1);
            //datasourch nhna ve 1 mang,nhan ve 1 list,datatable
            dataGridView1.DataSource = d;

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //1 row
            DataGridViewRow r = dataGridView1.CurrentRow;
            string re = "";
            re = r.Cells[0].Value.ToString() + " " + r.Cells[1].Value.ToString() + " " + r.Cells[2].Value.ToString();
            MessageBox.Show(re);
            //nhieu row
            DataGridViewSelectedRowCollection rh = dataGridView1.SelectedRows;
            string r1 = "";
            foreach(DataGridViewRow i in rh)
            {
                r1 += i.Cells[0].Value.ToString() + " "
                    + i.Cells[1].Value.ToString() + " "
                    + i.Cells[2].Value.ToString() + "\n";
                
            }
            MessageBox.Show(r1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(userControl11.Name + " ," + userControl11.Pw);
            userControl11.Name = "helo";
            userControl11.Pw = "ban";
            MessageBox.Show(userControl11.Name + " ," + userControl11.Pw);

            //tao user controe. dau tien tao project la class library voi c# co net framwork
            // and mot user control
            // tao mot cai form tuy theo y minh
            // buid sloution=>tao 1 file dll trong thu muc bin->debug
            //add thu vien vao form moi
            // neeu vao toolbox chua co thi minh vao references click chuot phai chon add references roi chon den thu muc
            //neu con khong duoc thi vao toolbox click chuot phai va chon chose iteam



        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "(All)|*.*|(Excel)|*.xlsx";
            DialogResult r = f.ShowDialog();

            if (r == DialogResult.OK)
            {
                MessageBox.Show("OK");
            }
        }

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    MessageBox.Show(dataGridView1.CurrentCell.Value.ToString());
        //}
    }
}
