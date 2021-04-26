using BT03_102190202.DAL;
using BT03_102190202.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT03_102190202.BLL
{
    class QLSV_BLL
    {
        private static QLSV_BLL _Instance;
        public static QLSV_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new QLSV_BLL();
                }
                return _Instance;
            }
            private set
            {

            }
        }
        public List<SV> getListSV_BLL()
        {
            return DAL_QLSV.Instance.getListSV_DAL();
        }
        //Lasy list LopHP
        public List<LopHP> getListLopHP_BLL()
        {
            return DAL_QLSV.Instance.getListLopHP_DAL();
        }

        //lay sinh vien theo demand
        public List<SV> getSVByID_Name_BLL(int idlop, string name)
        {
            return DAL_QLSV.Instance.GetListSV(idlop, name);
        }
        //Làm một hàm để check MSSV chỗ hàm add trước khi đưa vào inset
        public void ExecuteDB(SV s)
        {
            bool check = false;
            foreach (SV i in getListSV_BLL())
            {
                if (i.MSSV == s.MSSV)
                {
                    check = true;
                }
            }
            if (check)
            {
                DAL_QLSV.Instance.updateSV_DAL(s);
            }
            else
            {
                DAL_QLSV.Instance.Add_SV_DAL(s);
            }
        }

       
        public void deleteSV_BLL(string ms)
        {
            DAL_QLSV.Instance.deleteSV_DAL(ms);
        }
        public List<CBBItem> getCBBSort()
        {
            return DAL_QLSV.Instance.getCBBSort_DAL();
        }
        //Thuwjc hien ham sort
        public delegate bool Compare(SV s1, SV s2);
        public List<SVView> SortListSVByDemand(string demand)
        {
            List<SV> list = getListSV_BLL();
            Compare cmp;
            switch (demand)
            {
                case "MSSV":
                    {
                        cmp = SV.CmpMSSV;
                        break;
                    }
                case "NameSV":
                    {
                        cmp = SV.CmpNameSV;
                        break;
                    }
                
                case "NS":
                    {
                        cmp = SV.CmpNS;
                        break;
                    }
               
                default:
                    {
                        cmp = SV.CmpMSSV;
                        break;
                    }
            }

            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (cmp(list[i], list[j]))
                    {
                        SV temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }
            return getListSVView_BLL(list);
        }
        //Làm một hàm để đổi từ idlop sang namelop
        public CBBItem NameLop(int id)
        {
            CBBItem lsh = new CBBItem();
            foreach (LopHP i in getListLopHP_BLL())
            {
                if (i.Id_lop == id)
                {
                    lsh.Value = i.Id_lop;
                    lsh.tenLop = i.NameLop;
                }
            }
            return lsh;

        }

        //Hàm thay đổi giao diện 
        public List<SVView> getListSVView_BLL(List<SV> list)
        {

            List<SVView> listView = new List<SVView>();
            foreach (var i in list)
            {
                listView.Add(new SVView
                {
                    Name = i.Name,
                    Gender = i.Gender,
                    NS = i.NS,
                    NameLop = NameLop(i.Id_lop).tenLop
                });
            }
            return listView;

        }
        //lay mssv dua vao index
        public string getMSSVByIndex_BLL(int index)
        {
            return DAL_QLSV.Instance.getMSSVByIndex_DAL(index);
        }
        public SV getSVByMSSV_BLL(string Mssv)
        {
            return DAL_QLSV.Instance.getSVByMSSV_DAL(Mssv);
        }
        public bool validateId(string a)
        {
            foreach(char i in a)
            {
                if((byte)(i) <=9 && (byte)(i) >= 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
