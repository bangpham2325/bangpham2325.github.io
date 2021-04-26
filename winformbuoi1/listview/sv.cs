using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listview
{
    class sv
    {
        public string masv { get; set; }
        public string ten { get; set; }
        public string diem { get; set; }
       public  bool genDer { get; set; }
        public override string ToString()
        {
            return masv + " ," + ten + " ," + diem + ", ";
        }
    }
}
