using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkDemo.DTO
{
    public class LopHoc
    {
        public LopHoc(string iD, string name)
        {
            this.ID = iD;
            this.Name = name;
        }

        public LopHoc(DataRow row)
        {
            this.ID = row["malop"].ToString();
            this.Name = row["tenlop"].ToString();
            this.Grade = row["khoi"].ToString();
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

        private string grade;

        public string Grade
        {
            get { return grade; }
            set { grade = value; }
        }
    }
}
