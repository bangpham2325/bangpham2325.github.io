using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT03_102190202.DTO
{
    class SV
    {
        public string MSSV { get; set; }//automatic propety//o trong co truong privat tuong ung voi property
        public string Name { get; set; }
        public bool Gender { get; set; }
        public string NS { get; set; }
        public int Id_lop { get; set; }
        public static Boolean CmpMSSV(SV s1, SV s2)
        {
            return (String.Compare(s1.MSSV, s2.MSSV) > 0) ? true : false;
        }
        public static Boolean CmpNameSV(SV s1, SV s2)
        {
            return (String.Compare(s1.Name, s2.Name) > 0) ? true : false;
        }
        public static Boolean CmpNS(SV s1, SV s2)
        {
            return (String.Compare(Convert.ToString(s1.NS), Convert.ToString(s2.NS)) > 0) ? true : false;
        }
    }
}
