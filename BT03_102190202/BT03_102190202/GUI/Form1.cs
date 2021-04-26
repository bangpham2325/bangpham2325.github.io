using BT03_102190202.BLL;
using BT03_102190202.DTO;
using BT03_102190202.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT03_102190202
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Show();
            setCBB();
            setcbbSort();
        }
        public void setCBB()
        {
            cbLophp.Items.Add(new CBBItem { Value = 0, tenLop = "All" });

            foreach (LopHP i in QLSV_BLL.Instance.getListLopHP_BLL())
            {
                cbLophp.Items.Add(new CBBItem
                {
                    Value = i.Id_lop,
                    tenLop = i.NameLop
                });
            }
            cbLophp.SelectedIndex = 0;
        }
        public void Show(int Id_Lop, string name)
        {

            dataGridViewsv.DataSource = QLSV_BLL.Instance.getListSVView_BLL(QLSV_BLL.Instance.getSVByID_Name_BLL(Id_Lop, name));


        }
        private void btShow_Click(object sender, EventArgs e)
        {
            Show(((CBBItem)cbLophp.SelectedItem).Value, txtSearch.Text);
        }
       
        private void btSearch_Click(object sender, EventArgs e)
        {

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(0);
            f.d += new Form2.MyDel1(Show);//doi tuong delegate tham chieu den ham show
            f.Show();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewsv.SelectedRows.Count == 1)
            {
                string MSSV = dataGridViewsv.SelectedRows[0].Cells["MSSV"].Value.ToString();
                Form2 f = new Form2(Convert.ToInt32(MSSV));
                f.d += new Form2.MyDel1(Show);
                f.Show();
            }
        }
        public void setcbbSort()
        {
            foreach (var i in QLSV_BLL.Instance.getCBBSort())
            {
                cbSort.Items.Add(new CBBItem
                {
                    Value = i.Value,
                    tenLop = i.tenLop

                });
            }
            cbSort.SelectedIndex = 0;
        }
        private void btDel_Click(object sender, EventArgs e)
        {
            if (dataGridViewsv.SelectedRows.Count == 1)
            {
               
                string MSSV =dataGridViewsv.SelectedRows[0].Cells["MSSV"].Value.ToString();
                QLSV_BLL.Instance.deleteSV_BLL(MSSV);
            }
            MessageBox.Show("thanh cong");
            Show(0, "");
        }

        private void btSort_Click(object sender, EventArgs e)
        {
            String demand = cbSort.Text;
            dataGridViewsv.DataSource = QLSV_BLL.Instance.SortListSVByDemand(demand);
        }
    }
}
