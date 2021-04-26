using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winformbuoi1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
			//MessageBox.Show(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(textBox1.Text);
            //tra ve item duoc lua chon ->object
            //  listBox1.SelectedItem
            //listbox co 3 item thuoc ve items->mang co 3 doi tuong
            //duoc danh so tu 0->2
            //tra ve vi tri item dang duoc lua chon
            // listBox1.SelectedIndex
            //tra ve cac iteam dang duoc lua chon
            //r la mang cac item dang duoc lua chon
            //ListBox.SelectedObjectCollection r=   listBox1.SelectedItems
            string txt = textBox1.Text;
            //neu trung tra ve vi tri  item trung cua listbox
            //neu khong trung trả ve gia tri -1
            if (txt != null)
            {
                if (listBox1.Items.IndexOf(txt) < 0)
                {
                    //add vao listBox
                    listBox1.Items.Add(txt);
                }
                else
                {
                    MessageBox.Show("trung roi cu oi");
                }
            }
            else
            {
                MessageBox.Show("Nhap text di cu oi...");
            }
            //------------------ cobobox
            if (txt != null)
            {
                if (comboBox1.Items.IndexOf(txt) < 0)
                {
                    //add vao listBox
                    comboBox1.Items.Add(txt);
                }
                else
                {
                    MessageBox.Show("trung roi cu oi cobobox");
                }
            }
            else
            {
                MessageBox.Show("Nhap text di cu oi...");
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //tra ve gia tri nguyen la vi tri item duoc lua chon >=0
            if (listBox1.SelectedIndex >= 0)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
           textBox1.Text= comboBox1.Items[index].ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show(checkBox1.Checked.ToString());
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show(checkBox1.Checked.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
    }
}
