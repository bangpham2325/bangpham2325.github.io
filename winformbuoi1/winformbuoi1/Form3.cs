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
    public partial class Form3 : Form
    {
        public delegate void show(string s);
        public show D { get; set; }
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string s = txt3.Text;
            if(D!=null)
             D(s);
        }
    }
}
