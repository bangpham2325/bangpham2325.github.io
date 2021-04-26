using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT03_102190202.DTO
{
    class CBBItem
    {
        public int Value { get; set; }
        public string tenLop { get; set; }
        public override string ToString()
        {
            return tenLop;
        }
    }
}
