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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        Point ps;
        private void Form4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ps = e.Location;
            }
        }

        private void Form4_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Graphics g = CreateGraphics();
                Pen p = new Pen(Color .Red, 2f);
                g.DrawLine(p, ps, e.Location);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1.Text += e.KeyChar;
        }

        private void Form4_KeyDown(object sender, KeyEventArgs e)
        {
            label2.Text = "key down: " + "key code: " + e.KeyCode + " key value= "
+ e.KeyValue + "key data= " + e.KeyData;        }
    }
}
