using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Teacher
    {
        public string fname;
        public string lname;
        public int yearofbirth;
        public int selery;

        public Teacher(string fname, string lname, int yearofbirth, int selery)
        {
            this.fname = fname;
            this.lname = lname;
            this.yearofbirth = yearofbirth;
            this.selery = selery;
        }
    }
}