using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Manager
    {
        public string fname;
        public string lname;
        public int phone;

        public Manager(string fname, string lname, int phone)
        {
            this.fname = fname;
            this.lname = lname;
            this.phone = phone;
        }
    }
}