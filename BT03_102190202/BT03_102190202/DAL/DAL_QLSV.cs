using BT03_102190202.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT03_102190202.DAL
{
    class DAL_QLSV
    {
        private static DAL_QLSV _Instance;
        public static DAL_QLSV Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_QLSV();

                }
                return _Instance;
            }
            private set
            {

            }
        }
        private DAL_QLSV()
        {

        }
        //lay du lieu tu lop SV
        public SV getSVByRow(DataRow dr)
        {
            return new SV
            {
                MSSV = dr["MSSV"].ToString(),
                Name = dr["NameSV"].ToString(),
                Gender = Convert.ToBoolean(dr["Gender"].ToString()),
                NS = dr["NgaySinh"].ToString(),
                Id_lop = Convert.ToInt32(dr["ID_Lop"].ToString()),

            };
        }
        //lay all du lieu SV
        public List<SV> getListSV_DAL()
        {
            List<SV> list = new List<SV>();
            string querry = "select * from SinhVien";
            foreach (DataRow dr in DBHelper.Instance.getRecords(querry).Rows)
            {
                list.Add(getSVByRow(dr));
            }
            return list;
        }
        //them SV vao csdl
        public void Add_SV_DAL(SV s)
        {
            string querry = "Insert into SinhVien values('" + s.MSSV + "',N'" + s.Name + "','" + s.Gender + "','"+ s.NS + "','" + s.Id_lop.ToString() + "')";
            DBHelper.Instance.ExecuteDB(querry);

        }

        //lay du lieu cua lop hp 
        public List<LopHP> getListLopHP_DAL()
        {
            List<LopHP> list = new List<LopHP>();
            string querry = "select * from lopHP";
            foreach (DataRow dr in DBHelper.Instance.getRecords(querry).Rows)
            {
                list.Add(new LopHP
                {
                    Id_lop = Convert.ToInt32(dr["Id_Lop"].ToString()),
                    NameLop = dr["TenLop"].ToString()
                });
            }
            return list;
        }
        //Lấy được những sinh viên theo yêu cầu , truyền vào id lớp và name chỗ txtName từ GUI
        public List<SV> GetListSV(int Id_Lop, string Name)
        {
            //tra vve list<SV> tuong ung voi LSH va txtSearch(NAme)
            List<SV> data = new List<SV>();
            
            foreach (SV i in getListSV_DAL())
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
                else if ((i.Id_lop == Id_Lop) && (i.Name.Contains(Name)))
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
        
        //ham de uppdate SV
        public void updateSV_DAL(SV s)
        {
            string querry = "update SinhVien set NameSV = '" + s.Name + "',Gender='" + s.Gender + "',NgaySinh='" + s.NS + "',Id_Lop='" + s.Id_lop + "' where MSSV='" + s.MSSV + "'";
            DBHelper.Instance.ExecuteDB(querry);
        }

        //lam mot ham xoa 
        public void deleteSV_DAL(string ms)
        {
            string querry = "delete from SinhVien where MSSV= " + ms;
            DBHelper.Instance.ExecuteDB(querry);
        }

        //lay nhung du lieu de do ra cbbSort 
        public List<CBBItem> getCBBSort_DAL()
        {
            List<CBBItem> list = new List<CBBItem>();
            string querry = "select * from SinhVien";
            int val = 1;
            foreach (DataColumn dc in DBHelper.Instance.getRecords(querry).Columns)
            {
                list.Add(new CBBItem
                {
                    Value = val,
                    tenLop = dc.ColumnName
                });
                val++;
            }
            return list;
        }

        //Lamf mojt ham getMSSV dua vao vi tri lua chon tu datagrid 
        public string getMSSVByIndex_DAL(int index)
        {
            List<SV> list = DAL_QLSV.Instance.getListSV_DAL();
            return list[index].MSSV;
        }
        public SV getSVByMSSV_DAL(string Mssv)
        {
            SV s = new SV();
            try
            {
                foreach (SV i in getListSV_DAL())
                {
                    if(i.MSSV.Trim() == Mssv)
                    {
                        s = i;
                        break;
                    }
                }
                
                return s;
            }
            catch(Exception)
            {
                return null;
            }
        }
    }
}
