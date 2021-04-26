using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BT01_102190202_PhamHuuBang
{
    public partial class Form1 : Form
    {
        String state = "";
        System.IO.FileStream fs;
        StreamWriter sw;
        public Form1()
        {
            InitializeComponent();
            createCol();
            
            readFile();


        }
        public void openFile()
        {
            fs = new System.IO.FileStream(@"C:\Users\ASUS\source\repos\winformbuoi1\BT01_102190202_PhamHuuBang\102190202.txt", FileMode.Truncate, FileAccess.Write, FileShare.None);
            sw = new StreamWriter(fs);
        }
        
        public void writeFile(string a)
        {
            
            
            sw.WriteLine(a);
            
        }
        public void readFile()
        {
            string a = "", b = "",c="",d="";
            fs = new System.IO.FileStream(@"C:\Users\ASUS\source\repos\winformbuoi1\BT01_102190202_PhamHuuBang\102190202.txt", FileMode.Open, FileAccess.Read, FileShare.None);
            StreamReader sr = new StreamReader(fs);
            a = sr.ReadLine();
            if (a != null)
            {
                
                c = a.Remove(0, 5);
                do
                {
                    b = sr.ReadLine();
                    if (b != null)
                    {
                        d = b.Remove(0, 6);
                    }

                    createRow1(c, d);
                    a = sr.ReadLine();

                    if (a != null)
                    {
                        c = a.Remove(0, 5);
                    }


                } while (a != null);
            }

            sr.Close();
            fs.Close();
        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += ((Button)sender).Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += ((Button)sender).Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += ((Button)sender).Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += ((Button)sender).Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += ((Button)sender).Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += ((Button)sender).Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += ((Button)sender).Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += ((Button)sender).Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += ((Button)sender).Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += ((Button)sender).Text;
            
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1.Focus();
            if (e.KeyChar == 8)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
            else if(e.KeyChar == (char)13)
            {
                button11_Click(sender,e);
            }else if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Ban Phai Nhap so");

            }else
            {
                textBox1.Text += e.KeyChar.ToString();
            }
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 4)
            {
                
                state = "Access granted";
                createRow();
                MessageBox.Show("dung roi");
            }else if(textBox1.TextLength == 1){
                
                state = "Restricted Access";
                createRow();
            }else
            {
               
                state = "Access denied";
                createRow();
            }
            
        }
        public void createCol()
        {
            ColumnHeader c1 = new ColumnHeader();
            c1.Text = "Time";
            c1.Width = 200;
            ColumnHeader c2 = new ColumnHeader();
            c2.Width = 100;
            c2.Text = "State";
            
            listView1.Columns.AddRange(new ColumnHeader[] { c1, c2 });
        }
        //anh row
        public void createRow()
        {
            ListViewItem i1 = new ListViewItem();
            i1.Text = DateTime.Now.ToString();
            ListViewItem.ListViewSubItem sb1 = new ListViewItem.ListViewSubItem();
            sb1.Text = state;
            i1.SubItems.Add(sb1);
            listView1.Items.Add(i1);
            

        }
        public void createRow1(string a,string b)
        {
            ListViewItem i1 = new ListViewItem();
            i1.Text = a;
            ListViewItem.ListViewSubItem sb1 = new ListViewItem.ListViewSubItem();
            sb1.Text = b;
            i1.SubItems.Add(sb1);
            listView1.Items.Add(i1);


        }
        public void writeFileList()
        {
            if (listView1.Items != null)
            {

                openFile();

                string a = "";
                foreach (ListViewItem i in listView1.Items)
                {
                    a = "Time: " + i.Text + "\nState: " + i.SubItems[1].Text;
                    writeFile(a);
                }
                sw.Flush();
                sw.Close();
                fs.Close();

            }
        }

        

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            writeFileList();
            this.Dispose();
        }
    }
}
