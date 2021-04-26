using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitapquanlysinhvien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            addGripview();
            //addLopSh();
            setCBB();
        }

       

        public void addGripview()
        {
            dataGridViewsv.DataSource= CSDL_OOP.Instance.GetAllSV();
        }
        //public void addLopSh()
        //{
            


        //    foreach (DataRow txt in CSDL.instance.LopSH.Rows)
        //    {
        //        if (txt != null)
        //        {
        //            string txt1 = txt["NameLop"].ToString();
        //            if (cbLophp.Items.IndexOf(txt1) < 0)
        //            {
        //                //add vao listBox
        //                cbLophp.Items.Add(txt1);
        //            }
        //        }
        //    }
           
        //}
        public void setCBB()
        {
            cbLophp.Items.Add(new CbbItem { Value = 0, tenLop = "All" });
   
            foreach (LopSh i in CSDL_OOP.Instance.GetAllLSH())
            {
                cbLophp.Items.Add(new CbbItem
                {
                    Value = i.Id_lop,
                    tenLop = i.NameLop
                });
            }
            cbLophp.SelectedIndex = 0;
        }
        public void Show(int Id_Lop,string name)
        {
            
             dataGridViewsv.DataSource = CSDL_OOP.Instance.GetListSV(Id_Lop, name);
            
            
        }

        private void btShow_Click(object sender, EventArgs e)
        {
            Show(((CbbItem)cbLophp.SelectedItem).Value,txtSearch.Text);

        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(0);
            f.d += new Form2.MyDel1(Show);//doi tuong delegate tham chieu den ham show
            f.Show();

        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if(dataGridViewsv.SelectedRows.Count == 1)
            {
                int MSSV = Convert.ToInt32(dataGridViewsv.SelectedRows[0].Cells["MSSV"].Value.ToString());
                Form2 f = new Form2(MSSV);
                f.d +=new Form2.MyDel1(Show);
                f.Show();
            }
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            if (dataGridViewsv.SelectedRows.Count == 1)
            {
                int MSSV = Convert.ToInt32(dataGridViewsv.SelectedRows[0].Cells["MSSV"].Value.ToString());
                CSDL_OOP.Instance.DeleteSV(MSSV);
            }
            MessageBox.Show("thanh cong");
            Show(0, "");
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            dataGridViewsv.DataSource = CSDL_OOP.Instance.getSVByTen(txtSearch.Text.ToString());
        }

        private void btSort_Click(object sender, EventArgs e)
        {
            if (cbSort.SelectedIndex == 0)
            {
                dataGridViewsv.DataSource = CSDL_OOP.Instance.sort(CSDL_OOP.Instance.cpMaSV);
            }
            else
            {
                dataGridViewsv.DataSource = CSDL_OOP.Instance.sort(CSDL_OOP.Instance.cpMaTen);
            }
        }
    }
}
