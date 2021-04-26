using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace thigiuakicsharp
{
    class CSDL
    {
        public DataTable TacGia { get; set; }
        public DataTable NXB { get; set; }
        public DataTable Sach { get; set; }
        private static CSDL _instance;
        public static CSDL instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CSDL();

                }
                return _instance;

            }
            private set
            {

            }
        }
        public CSDL()
        {
            Sach = new DataTable();

            Sach.Columns.Add("MaSach", typeof(int));
            Sach.Columns.Add("TenSach", typeof(string));
            Sach.Columns.Add("SoLuong", typeof(int));
            Sach.Columns.Add("MaNXB", typeof(int));
            Sach.Columns.Add("MaTG", typeof(string));

            DataRow d = Sach.NewRow();
            d["MaSach"] = 1;
            d["TenSach"] = "sach1";
            d["SoLuong"] =10;
            d["MaNXB"] = 1;
            d["MaTG"] = "1";
            DataRow d1 = Sach.NewRow();
            d1["MaSach"] = 2;
            d1["TenSach"] = "sach2";
            d1["SoLuong"] = 11;
            d1["MaNXB"] = 4;
            d1["MaTG"] = "2";
            DataRow d2 = Sach.NewRow();
            d2["MaSach"] = 3;
            d2["TenSach"] = "sach3";
            d2["SoLuong"] = 31;
            d2["MaNXB"] = 3;
            d2["MaTG"] = "3";

            Sach.Rows.Add(d);
            Sach.Rows.Add(d1);
            Sach.Rows.Add(d2);
            NXB = new DataTable();
            NXB.Columns.Add("MaNXB", typeof(int));
            NXB.Columns.Add("TenNXB", typeof(string));
            DataRow n = NXB.NewRow();
            n["MaNXB"] = 1;
            n["TenNXB"] = "NXB1";
            DataRow n1 = NXB.NewRow();
            n1["MaNXB"] = 2;
            n1["TenNXB"] = "NXB2";
            DataRow n2 = NXB.NewRow();
            n2["MaNXB"] = 3;
            n2["TenNXB"] = "NXB3";
            DataRow n3 = NXB.NewRow();
            n3["MaNXB"] = 4;
            n3["TenNXB"] = "NXB4";
            DataRow n4 = NXB.NewRow();
            n4["MaNXB"] = 5;
            n4["TenNXB"] = "NXB5";
            NXB.Rows.Add(n);
            NXB.Rows.Add(n1);
            NXB.Rows.Add(n2);
            NXB.Rows.Add(n3);
            NXB.Rows.Add(n4);
            TacGia = new DataTable();
            TacGia.Columns.Add("MaTG", typeof(string));
            TacGia.Columns.Add("TenTG", typeof(string));
            DataRow t = TacGia.NewRow();
            t["MaTG"] = "1";
            t["TenTG"] = "Tac gia 1";
            DataRow t1 = TacGia.NewRow();
            t1["MaTG"] = "2";
            t1["TenTG"] = "Tac gia 2";
            DataRow t2 = TacGia.NewRow();
            t2["MaTG"] = "3";
            t2["TenTG"] = "Tac gia 3";
            DataRow t3 = TacGia.NewRow();
            t3["MaTG"] = "4";
            t3["TenTG"] = "Tac gia 4";
            DataRow t4 = TacGia.NewRow();
            t4["MaTG"] = "5";
            t4["TenTG"] = "Tac gia 5";
            TacGia.Rows.Add(t);
            TacGia.Rows.Add(t1);
            TacGia.Rows.Add(t2);
            TacGia.Rows.Add(t3);
            TacGia.Rows.Add(t4);

        }
        public void AddDataRowSV(Sach s)
        {
            DataRow d = Sach.NewRow();
            d["MaSach"] = s.MaSach;
            d["TenSach"] = s.TenSach;
            d["SoLuong"] = s.SoLuong;
            d["MaNXB"] = s.MaNXB;
            d["MaTG"] = s.MaTG;
            Sach.Rows.Add(d);

        }
        public void EditDataRowSV(Sach s)
        {
            //
            for (int i = 0; i < Sach.Rows.Count; i++)
            {
                if (Sach.Rows[i]["MaSach"].Equals(s.MaSach))
                {
                    Sach.Rows[i]["TenSach"] = s.TenSach;
                    Sach.Rows[i]["SoLuong"] = s.SoLuong;
                    Sach.Rows[i]["MaNXB"] = s.MaNXB;
                    Sach.Rows[i]["MaTG"] = s.MaTG;
                    break;

                }
            }

        }
        public void DeleteDataRow(int MaSach)
        {
            //
            for (int i = 0; i < Sach.Rows.Count; i++)
            {
                if (Sach.Rows[i]["MaSach"].Equals(MaSach))
                {
                    Sach.Rows.RemoveAt(i);
                    break;

                }
            }

        }
    }
}
