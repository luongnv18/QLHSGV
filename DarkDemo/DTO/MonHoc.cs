using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkDemo.DTO
{
    public class MonHoc
    {
        public MonHoc(string iD, string name)
        {
            this.ID = iD;
            this.Name = name;
        }

        public MonHoc()
        {
            this.ID = iD;
            this.Name = name;
        }

        public MonHoc(DataRow row)
        {
            this.ID = row["mamonhoc"].ToString();
            this.Name = row["tenmon"].ToString();
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
