using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkDemo.DTO
{
    public class GiaoVien
    {
        public GiaoVien(string iD, string name)
        {
            this.ID = iD;
            this.Name = name;
        }

        public GiaoVien(DataRow row)
        {
            this.ID = row["magiaovien"].ToString();
            this.Name = row["ten"].ToString();
        }

        private string iD;

        public string ID
        {
            get { return iD; }
            set { iD = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
