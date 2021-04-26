using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //khi dong form thi cac doi tuong tren form khong duoc giai phong va duoc tu giai phong boi C# tu dong gia phong

           // this.Close();
            //khi dong form thi giai phong toan bo
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("nhap ten di ban");
            }
            else
            {
                textBox2.Text = total().ToString();
            }
            
        }
        private double total()
        {
            double s = 0;
            //cpde tinh tien
            if (cvoi.Checked == true)
            {
                s += 100;
            }
            if( tayrang.Checked){
                s += 1000;
            }
            if (chup.Checked)
            {
                s += 200;
            }
            //int index=comboBox1.selectedIndex
            //string select=comboBox1.Items[index].ToString()
            //s+=convert.ToInt32(comboBox1.seclecItems.Tostring())*80
            string select = comboBox1.SelectedItem.ToString();
            int r = Convert.ToInt32(select);
            s += r * 80;
            return s;
        }
    }
}
