using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thigiuakicsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            addGripview();
            setCBBNXB();
            setCBBTG();
        }
        public void addGripview()
        {
            dataGridViewSach.DataSource = CSDL_OOP.Instance.GetAllSach();
        }
        public void setCBBTG()
        {
            cbTG.Items.Add(new cbbItem { ma = 0, ten = "All" });

            foreach (TacGia i in CSDL_OOP.Instance.GetAllTG())
            {
                cbTG.Items.Add(new cbbItem
                {
                    ma = Convert.ToInt32(i.MaTG.ToString()),
                    ten = i.TenTG
                });
            }
            cbTG.SelectedIndex = 0;
        }
        public void setCBBNXB()
        {
            cbNXB.Items.Add(new cbbItem { ma =0, ten = "All" });

            foreach (NXB i in CSDL_OOP.Instance.GetAllNXB())
            {
                cbNXB.Items.Add(new cbbItem
                {
                    ma = i.MaNXB,
                    ten = i.TenNXB

                });
            }
            cbNXB.SelectedIndex = 0;
        }
        public void Show(int MaNXB, int MaTG, string Name)
        {

            dataGridViewSach.DataSource = CSDL_OOP.Instance.GetListSach(MaNXB,MaTG,Name);


        }

        private void btShow_Click(object sender, EventArgs e)
        {
            Show(((cbbItem)cbNXB.SelectedItem).ma, ((cbbItem)cbTG.SelectedItem).ma, txtSearch.Text);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(0);
            f.d += new Form2.MyDel1(Show);//doi tuong delegate tham chieu den ham show
            f.Show();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewSach.SelectedRows.Count == 1)
            {
                int MSSV = Convert.ToInt32(dataGridViewSach.SelectedRows[0].Cells["MaSach"].Value.ToString());
                Form2 f = new Form2(MSSV);
                f.d += new Form2.MyDel1(Show);
                f.Show();
            }
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            if (dataGridViewSach.SelectedRows.Count == 1)
            {
                int MSSV = Convert.ToInt32(dataGridViewSach.SelectedRows[0].Cells["MaSach"].Value.ToString());
                CSDL_OOP.Instance.DeleteSach(MSSV);
            }
            MessageBox.Show("thanh cong");
            Show(0,0, "");
        }

        private void btSort_Click(object sender, EventArgs e)
        {
            if (cbSort.SelectedIndex == 0)
            {
                dataGridViewSach.DataSource = CSDL_OOP.Instance.sort(CSDL_OOP.Instance.cpMaSach);
            }
            else
            {
                dataGridViewSach.DataSource = CSDL_OOP.Instance.sort(CSDL_OOP.Instance.cpMaTen);
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            dataGridViewSach.DataSource = CSDL_OOP.Instance.getSachByTen(txtSearch.Text.ToString());
        }
    }
}
