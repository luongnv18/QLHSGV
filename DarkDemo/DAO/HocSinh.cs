using DarkDemo.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkDemo.DAO
{
    public class HocSinh
    {
        private static HocSinh instance;

        public static HocSinh Instance
        {
            get { if (instance == null) instance = new HocSinh(); return HocSinh.instance; }
            private set { HocSinh.instance = value; }
        }

        private HocSinh() { }

        public DataTable GetListProduct()
        {
            return DataProvider.Instance.ExcuseQuery("SELECT mahocsinh, ten, gioitinh, ngaysinh, dantoc, quequan, diachi, sdt, tenlop FROM dbo.HocSinh JOIN dbo.LopHoc ON LopHoc.malop = HocSinh.malop");
        }

        public DataTable GetList(string id)
        {
            string query = string.Format("SELECT mahocsinh,ten,gioitinh,ngaysinh,dantoc,quequan,diachi,sdt,tenlop FROM dbo.HocSinh JOIN dbo.LopHoc ON LopHoc.malop = HocSinh.malop WHERE HocSinh.malop = {0}", id);
            return DataProvider.Instance.ExcuseQuery(query);
        }

        public List<LopHoc> DanhSachLopHoc()
        {
            List<LopHoc> list = new List<LopHoc>();
            string query = "SELECT * FROM LopHoc";

            DataTable data = DataProvider.Instance.ExcuseQuery(query);

            foreach (DataRow item in data.Rows)
            {
                LopHoc model = new LopHoc(item);
                list.Add(model);
            }

            return list;
        }

        public List<LopHoc> DanhSachLopTheoKhoi(string khoi)
        {
            List<LopHoc> list = new List<LopHoc>();
            string query = string.Format("SELECT * FROM dbo.LopHoc WHERE khoi = N'{0}'", khoi);

            DataTable data = DataProvider.Instance.ExcuseQuery(query);

            foreach (DataRow item in data.Rows)
            {
                LopHoc model = new LopHoc(item);
                list.Add(model);
            }

            return list;
        }

        public bool Delete(string id)
        {
            string query = string.Format("DELETE dbo.HocSinh WHERE mahocsinh = '{0}'", id);
            int result = DataProvider.Instance.ExcuseNonQuery(query);

            return result > 0;
        }
              
        public DataTable SearchByname(string name)
        {
            string query = string.Format("EXEC dbo.USP_Search @key = N'{0}'", name);
            return DataProvider.Instance.ExcuseQuery(query);
        }
             
        public bool Insert(string ma, string ten, string gt, string ns, string dantoc, string quequan, string diachi, string sdt, string lop)
        {
            string query = string.Format("INSERT dbo.HocSinh( mahocsinh ,ten ,gioitinh ,ngaysinh ,dantoc ,quequan ,diachi ,sdt ,malop) VALUES({0}, N'{1}', '{2}', N'{3}','{4}',N'{5}', '{6}', '{7}', {8})",  ma,  ten,  gt,  ns,  dantoc,  quequan,  diachi,  sdt,  lop);
            int result = DataProvider.Instance.ExcuseNonQuery(query);

            return result > 0;
        }

        public bool Update(string ma, string ten, string gt, string ns, string dantoc, string quequan, string diachi, string sdt, string lop)
        {
            string query = string.Format("UPDATE dbo.HocSinh SET  ten=N'{0}' ,gioitinh=N'{1}' ,ngaysinh='{2}' ,dantoc='{3}' ,quequan=N'{4}' ,diachi='{5}' ,sdt='{6}' ,malop='{7}' where mahocsinh='{8}'", ten, gt, ns, dantoc, quequan, diachi, sdt, lop,ma);
            int result = DataProvider.Instance.ExcuseNonQuery(query);

            return result > 0;
        }
    }
}
