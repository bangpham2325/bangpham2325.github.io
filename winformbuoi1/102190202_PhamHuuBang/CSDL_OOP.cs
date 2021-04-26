using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapquanlysinhvien
{
    class CSDL_OOP
    {
        //thuoc tinh bth:Chỉ có thể sử dụng sau khi khởi tạo đối tượng.

        //Được khởi tạo 1 lần duy nhất ngay khi biên dịch chương trình.
        //Có thể dùng chung cho mọi đối tượng.
        //Được gọi thông qua tên lớp.
        private static CSDL_OOP _Instance;
        public static CSDL_OOP Instance
        {
            get
            {
                if(_Instance == null)
                {
                    _Instance = new CSDL_OOP();
                }
                return _Instance;
            }
            private set { }
        }
        public CSDL_OOP()
        {

        }
        public List<SV> GetAllSV()
        {
            //tra ve tat ca cac doi tuong sinh vien tuong ung voi DataTable SV
            List<SV> data = new List<SV>();
            foreach(DataRow i in CSDL.instance.SV.Rows)
            {
                data.Add(GetSV(i));
            }
            return data;
        }
        public SV GetSV(DataRow i)
        {//tra ve 1 doi tuong sv tuong ung voi 1 datarow
            return new SV
            {
                MSSV = Convert.ToInt32(i["MSSV"].ToString()),
                Name = i["Name"].ToString(),
                Gender = Convert.ToBoolean(i["Gender"].ToString()),
                NS = Convert.ToDateTime(i["NS"].ToString()),
                Id_lop = Convert.ToInt32(i["Id_lop"])
            };
        }
        public List<LopSh> GetAllLSH()
        {
            //tra ve tat ca cac doi tuong lsh tuong ung Datatable LSH
            List<LopSh> data = new List<LopSh>();
            foreach(DataRow i in CSDL.instance.LopSH.Rows)
            {
                data.Add(GetLSH(i));
            }
            return data;
        }
        public LopSh GetLSH(DataRow i)
        {
            //tra ve 1 doi tuon LopSH tuong ung 1 DAtaRow trong datatable LopSH
            return new LopSh
            {
                Id_lop = Convert.ToInt32(i["Id_lop"].ToString()),
                NameLop = i["NameLop"].ToString()
            };
            //tra ve 1 doi tuong LSH tuong ung 1 DataROw trong datatable lsh
        }
        public List<SV> GetListSV(int Id_Lop,string Name)
        {
            //tra vve list<SV> tuong ung voi LSH va txtSearch(NAme)
            List<SV> data = new List<SV>();
            foreach(SV i in GetAllSV())
            {
                if (Id_Lop == 0 && i.Name.Contains(Name))
                {
                    data.Add(new SV
                    {
                        Name = i.Name,
                        MSSV = i.MSSV,
                        Gender = i.Gender,
                        NS = i.NS,
                        Id_lop = i.Id_lop
                    });
                }
                else if((i.Id_lop == Id_Lop) && (i.Name.Contains(Name)))
                {
                    data.Add(new SV
                    {
                        Name = i.Name,
                        MSSV = i.MSSV,
                        Gender = i.Gender,
                        NS = i.NS,
                        Id_lop = i.Id_lop
                    });
                }
            }
            return data;

        }

        public void ExecuteDB(SV s)
        {
            bool check = false;
            foreach(SV i in GetAllSV())
            {
                if(i.MSSV == s.MSSV)
                {
                    check = true;
                }
            }
            if (check)
            {
                CSDL.instance.EditDataRowSV(s);
            }
            else
            {
                CSDL.instance.AddDataRowSV(s);
            }
        }
        
        public SV getSVByMSSV(int Mssv)
        {
            SV s=new SV();
            try
            {
                foreach (SV i in GetAllSV())
                {
                    if (i.MSSV == Mssv)
                    {
                        s = i;
                    }
                }
                Console.WriteLine("hello: " + s);
                return s;
            }
            catch
            {
                return null;
            }
        }
        public void DeleteSV(int MSSV)
        {
            CSDL.instance.DeleteDataRow(MSSV);

        }
        public List<SV> getSVByTen(string ten)
        {
            List<SV> data = new List<SV>();
            try
            {
                foreach (SV i in GetAllSV())
                {
                    if (i.Name.Contains(ten))
                    {
                        data.Add(new SV
                        {
                            Name = i.Name,
                            MSSV = i.MSSV,
                            Gender = i.Gender,
                            NS = i.NS,
                            Id_lop = i.Id_lop
                        });
                    }
                }
                return data;
            }
            catch
            {
                return null;
            }
        }
        public delegate bool compare(SV s1, SV s2);
        public List<SV> sort(compare cp)
        {
            List<SV> data = new List<SV>();
            data = GetAllSV();
            for (int i = 0; i < data.Count - 1; i++)
            {
                for (int j = i; j < data.Count; j++)
                {
                    if (cp(data[i], data[j]))
                    {
                        SV temp = data[i];
                        data[i] = data[j];
                        data[j] = temp;

                    }
                }
            }
            return data;
        }
        public bool cpMaSV(SV s1, SV s2)
        {
            return s1.MSSV < s2.MSSV;
        }
        public bool cpMaTen(SV s1, SV s2)
        {
            if (string.Compare(s1.Name, s2.Name) > 0)
            {
                return true;
            }
            return false;
        }
        //public void AddSV(SV s)
        //{
        //    CSDL.instance.AddDataRowSV(s);
        //}
        //public void Edit(SV s)
        //{
        //   CSDL.instance.EditDataRowSV(s);
        // }

    }
}
