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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        
        private void ShowText(string s)
        {
            txt2.Text = s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.D += new Form3.show(ShowText);
            f.Show();
        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
