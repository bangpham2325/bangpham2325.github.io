using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class UserControl1 : UserControl
    {
        //private string _Name;
        //private string _Pw;
        public UserControl1()
        {
            InitializeComponent();
        }
        public string Name
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;

            }
        }
        public string Pw
        {
            get
            {
                return textBox2.Text;
            }
            set
            {
                textBox2.Text = value;

            }
        }
    }
}
