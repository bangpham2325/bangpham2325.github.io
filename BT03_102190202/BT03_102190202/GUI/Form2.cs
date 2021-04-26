using BT03_102190202.BLL;
using BT03_102190202.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT03_102190202.GUI
{
    public partial class Form2 : Form
    {
        public delegate void MyDel1(int id, string name);// doi tuong delegate nhu mot class
        public MyDel1 d { get; set; }// mot thu the nhu 1 doi tuong
        public int MSSV { get; set; }
        public Form2(int m)
        {
            InitializeComponent();
            MSSV = m;
            setGUI();
        }
        public void setCBB()
        {
            if (cbLop != null)
            {
                cbLop.Items.Clear();
            }
            foreach (LopHP i in QLSV_BLL.Instance.getListLopHP_BLL())
            {
                cbLop.Items.Add(new CBBItem
                {
                    Value = i.Id_lop,
                    tenLop = i.NameLop
                });
            }
        }
        public void setGUI()
        {
            setCBB();
            if (QLSV_BLL.Instance.getMSSVByIndex_BLL(MSSV) != null)
            {
                //;ay thong tin len giao dien
                if (MSSV == 0)
                {

                }
                else
                {
                    SV row = QLSV_BLL.Instance.getSVByMSSV_BLL(MSSV.ToString());
                    txtMSV.Text = row.MSSV.ToString();
                    txtTen.Text = row.Name.ToString();
                    if (Convert.ToBoolean(row.Gender.ToString()))
                    {
                        raBM.Checked = true;
                    }
                    else
                    {
                        raFM.Checked = true;
                    }

                    daTime.Value =Convert.ToDateTime(row.NS);

                    cbLop.SelectedIndex = row.Id_lop; ;

                }

                cbLop.SelectedIndex = 0;

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SV s = new SV();//GUI
            if (txtMSV.Text.Equals("")
                )
            {
                MessageBox.Show("Ban chua nhap MSSV ");
                return;
            }
            if (txtTen.Text.Equals(""))
            {
                MessageBox.Show("Ban chua nhap ten");
            }
            s.NS = daTime.Value.ToString("yyyy/MM/dd");
            s.Gender = ((raBM).Checked == true) ? true : false;
            s.Id_lop = ((CBBItem)cbLop.SelectedItem).Value;
            s.Name = txtTen.Text;
            s.MSSV = txtMSV.Text.ToString();
            QLSV_BLL.Instance.ExecuteDB(s);
            d(0, "");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
