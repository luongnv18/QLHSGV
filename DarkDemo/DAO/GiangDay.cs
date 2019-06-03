using DarkDemo.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkDemo.DAO
{
    public class GiangDay
    {
        private static GiangDay instance;

        public static GiangDay Instance
        {
            get { if (instance == null) instance = new GiangDay(); return GiangDay.instance; }
            private set { GiangDay.instance = value; }
        }

        private GiangDay() { }

        public List<MonHoc> DanhSachMon()
        {
            List<MonHoc> list = new List<MonHoc>();
            string query = "SELECT * FROM MonHoc";

            DataTable data = DataProvider.Instance.ExcuseQuery(query);

            foreach (DataRow item in data.Rows)
            {
                MonHoc model = new MonHoc(item);
                list.Add(model);
            }

            return list;
        }

        public List<GiaoVien> DanhSachGiaoVien()
        {
            List<GiaoVien> list = new List<GiaoVien>();
            string query = "SELECT * FROM GiaoVien";

            DataTable data = DataProvider.Instance.ExcuseQuery(query);

            foreach (DataRow item in data.Rows)
            {
                GiaoVien model = new GiaoVien(item);
                list.Add(model);
            }

            return list;
        }
        public List<GiaoVien> DanhSachGVtheoMon(string mamon)
        {
            List<GiaoVien> list = new List<GiaoVien>();
            string query = string.Format("SELECT * FROM GiaoVien WHERE mamongiangday = {0} ", mamon);

            DataTable data = DataProvider.Instance.ExcuseQuery(query);

            foreach (DataRow item in data.Rows)
            {
                GiaoVien model = new GiaoVien(item);
                list.Add(model);
            }

            return list;
        }

        public DataTable DanhSachMontheoGV(string magv)
        {
            string query = string.Format("SELECT mamonhoc,tenmon FROM GiaoVien,MonHoc WHERE mamongiangday = mamonhoc AND magiaovien = {0} ", magv);

            return DataProvider.Instance.ExcuseQuery(query);
        }

        public DataTable GetList1(string mamon)
        {
            string query = string.Format("SELECT magiangday,dbo.GiaoVien.ten,dbo.LopHoc.tenlop,thoigian FROM dbo.GiangDay JOIN dbo.GiaoVien ON GiaoVien.magiaovien = GiangDay.magiaovien JOIN dbo.LopHoc ON LopHoc.malop = GiangDay.malop WHERE GiaoVien.mamongiangday = {0} ", mamon);
            return DataProvider.Instance.ExcuseQuery(query);
        }

        public DataTable GetList2(string malop)
        {
            string query = string.Format("SELECT magiangday,dbo.GiaoVien.ten, tenmon,thoigian FROM dbo.GiangDay JOIN dbo.GiaoVien ON GiaoVien.magiaovien = GiangDay.magiaovien JOIN dbo.LopHoc ON LopHoc.malop = GiangDay.malop JOIN dbo.MonHoc ON mamongiangday = mamonhoc WHERE GiangDay.malop = {0} ", malop);
            return DataProvider.Instance.ExcuseQuery(query);
        }

        public bool Insert1(string ma, string malop, string time)
        {
            string query = string.Format("INSERT dbo.GiangDay( magiaovien, malop, thoigian ) VALUES  ( {0},{1},N'{2}')", ma, malop, time);
            int result = DataProvider.Instance.ExcuseNonQuery(query);
            return result > 0;
        }

        public bool Update1(string ma, string malop, string time, string magd)
        {
            string query = string.Format("UPDATE dbo.GiangDay SET magiaovien = {0} , malop = {1}, thoigian = N'{2}' WHERE magiangday = {3}", ma, malop, time, magd);
            int result = DataProvider.Instance.ExcuseNonQuery(query);
            return result > 0;
        }

        public bool Delete1(string magd)
        {
            string query = string.Format("DELETE dbo.GiangDay WHERE magiangday = {0}", magd);
            int result = DataProvider.Instance.ExcuseNonQuery(query);
            return result > 0;
        }


    }
}
