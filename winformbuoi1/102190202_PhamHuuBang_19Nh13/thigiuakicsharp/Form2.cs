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
    public partial class Form2 : Form
    {
        public delegate void MyDel1(int maNXB,int maTG, string name);// doi tuong delegate nhu mot class
        public MyDel1 d { get; set; }// mot thu the nhu 1 doi tuong
        public int MaSach { get; set; }
        public Form2(int m)
        {
            InitializeComponent();
            MaSach = m;
            setGUI();
        }
        public void setCBBTG()
        {
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
        public void setGUI()
        {
            setCBBTG();
            setCBBNXB();
            if (CSDL_OOP.Instance.getSachByMa(MaSach) != null)
            {
                //;ay thong tin len giao dien
                if (MaSach == 0)
                {

                }
                else
                {
                    Sach row = CSDL_OOP.Instance.getSachByMa(MaSach);
                    txtMSach.Text = row.MaSach.ToString();
                    txtTen.Text = row.TenSach.ToString();
                    txtSL.Text = row.SoLuong.ToString();
                    cbTG.SelectedIndex = Convert.ToInt32(row.MaTG.ToString());
                    
                    cbNXB.SelectedIndex = row.MaNXB;

                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sach s = new Sach();//GUI
            if (txtMSach.Text.Equals(""))
            {
                MessageBox.Show("Ban chua nhap MSSV");
                return;
            }
            if (txtTen.Text.Equals(""))
            {
                MessageBox.Show("Ban chua nhap ten");
            }
            s.MaTG = ((cbbItem)cbTG.SelectedItem).ma.ToString();
            s.MaNXB = Convert.ToInt32(((cbbItem)cbNXB.SelectedItem).ma);

            s.SoLuong = Convert.ToInt32(txtSL.Text);
            s.TenSach = txtTen.Text;
            s.MaSach = Convert.ToInt32(txtMSach.Text.ToString());
            CSDL_OOP.Instance.ExecuteDB(s);
            d(0,0, "");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
