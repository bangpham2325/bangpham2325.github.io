using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace thigiuakicsharp
{
    class CSDL_OOP
    {
        private static CSDL_OOP _Instance;
        public static CSDL_OOP Instance
        {
            get
            {
                if (_Instance == null)
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
        public List<Sach> GetAllSach()
        {
            //tra ve tat ca cac doi tuong sinh vien tuong ung voi DataTable SV
            List<Sach> data = new List<Sach>();
            foreach (DataRow i in CSDL.instance.Sach.Rows)
            {
                data.Add(GetSach(i));
            }
            return data;
        }
        public Sach GetSach(DataRow i)
        {//tra ve 1 doi tuong sv tuong ung voi 1 datarow
            return new Sach
            {
                MaSach = Convert.ToInt32(i["MaSach"].ToString()),
                TenSach = i["TenSach"].ToString(),
                SoLuong = Convert.ToInt32(i["SoLuong"].ToString()),
                MaNXB = Convert.ToInt32(i["MaNXB"].ToString()),
                MaTG = i["MaTG"].ToString()
            };
        }
        public List<NXB> GetAllNXB()
        {
            //tra ve tat ca cac doi tuong lsh tuong ung Datatable LSH
            List<NXB> data = new List<NXB>();
            foreach (DataRow i in CSDL.instance.NXB.Rows)
            {
                data.Add(GetNXB(i));
            }
            return data;
        }
        public NXB GetNXB(DataRow i)
        {
            //tra ve 1 doi tuon LopSH tuong ung 1 DAtaRow trong datatable LopSH
            return new NXB
            {
                MaNXB = Convert.ToInt32(i["MaNXB"].ToString()),
                TenNXB = i["TenNXB"].ToString()
            };
            //tra ve 1 doi tuong LSH tuong ung 1 DataROw trong datatable lsh
        }
        public List<TacGia> GetAllTG()
        {
            //tra ve tat ca cac doi tuong lsh tuong ung Datatable LSH
            List<TacGia> data = new List<TacGia>();
            foreach (DataRow i in CSDL.instance.TacGia.Rows)
            {
                data.Add(GetTG(i));
            }
            return data;
        }
        public TacGia GetTG(DataRow i)
        {
            //tra ve 1 doi tuon TG tuong ung 1 DAtaRow trong datatable LopSH
            return new TacGia
            {
                MaTG = i["MaTG"].ToString(),
                TenTG = i["TenTG"].ToString()
            };
            //tra ve 1 doi tuong LSH tuong ung 1 DataROw trong datatable lsh
        }
    
        public List<Sach> GetListSach(int MaNXB,int MaTG, string Name)
        {
            //tra vve list<SV> tuong ung voi LSH va txtSearch(NAme)
            List<Sach> data = new List<Sach>();
            
            foreach (Sach i in GetAllSach())
            {
                if (((MaNXB==0) && (MaTG==0)) && i.TenSach.Contains(Name))
                {
                   
                    data.Add(new Sach
                    {
                        MaSach = i.MaSach,
                        TenSach = i.TenSach,
                        SoLuong = i.SoLuong,
                        MaNXB = i.MaNXB,
                        MaTG = i.MaTG
                    });
                }
                else if ((i.MaNXB == MaNXB) && (MaTG == 0) && (i.TenSach.Contains(Name)))
                {
                   
                    data.Add(new Sach
                    {
                        MaSach = i.MaSach,
                        TenSach = i.TenSach,
                        SoLuong = i.SoLuong,
                        MaNXB = i.MaNXB,
                        MaTG = i.MaTG
                    });
                }
                else if((i.MaTG == MaTG.ToString()) && (MaNXB == 0) && (i.TenSach.Contains(Name)))
                {
                   
                    data.Add(new Sach
                    {
                        MaSach = i.MaSach,
                        TenSach = i.TenSach,
                        SoLuong = i.SoLuong,
                        MaNXB = i.MaNXB,
                        MaTG = i.MaTG
                    });
                }
                else if ((i.MaTG == MaTG.ToString()) && (i.MaNXB == MaNXB) && (i.TenSach.Contains(Name)))
                {
                  

                    data.Add(new Sach
                    {
                        MaSach = i.MaSach,
                        TenSach = i.TenSach,
                        SoLuong = i.SoLuong,
                        MaNXB = i.MaNXB,
                        MaTG = i.MaTG
                    });


                }
                
            }
            
            return data;

        }

        public void ExecuteDB(Sach s)
        {
            bool check = false;
            foreach (Sach i in GetAllSach())
            {
                if (i.MaSach == s.MaSach)
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

        public Sach getSachByMa(int Masach)
        {
            Sach s = new Sach();
            try
            {
                foreach (Sach i in GetAllSach())
                {
                    if (i.MaSach == Masach)
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
        public List<Sach> getSachByTen(string ten)
        {
            List<Sach> data = new List<Sach>();
            try
            {
                foreach (Sach i in GetAllSach())
                {
                    if (i.TenSach.Contains(ten))
                    {
                        data.Add(new Sach
                        {
                            MaSach = i.MaSach,
                            TenSach = i.TenSach,
                            SoLuong = i.SoLuong,
                            MaNXB = i.MaNXB,
                            MaTG = i.MaTG
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
        public void DeleteSach(int MaSach)
        {
            CSDL.instance.DeleteDataRow(MaSach);

        }

        public delegate bool compare(Sach s1, Sach s2);
        public List<Sach> sort(compare cp)
        {
            List<Sach> data = new List<Sach>();
            data = GetAllSach();
            for (int i = 0; i < data.Count - 1; i++)
            {
                for (int j = i; j < data.Count; j++)
                {
                    if (cp(data[i], data[j])){
                        Sach temp = data[i];
                        data[i] = data[j];
                        data[j] = temp;

                    }
                }
            }
            return data;
        }
        public bool cpMaSach(Sach s1,Sach s2)
        {
            return s1.MaSach < s2.MaSach;
        }
        public bool cpMaTen(Sach s1, Sach s2)
        {
            if (string.Compare(s1.TenSach, s2.TenSach)>0)
            {
                return true;
            }
            return false;
        }

    }
}
