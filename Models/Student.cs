using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Student
    {
        public string fName;
        public string lName;
        public int yearOfBirth;
        public int class_;

        public Student(string fName, string lName, int yearOfBirth, int class_)
        {
            this.fName = fName;
            this.lName = lName;
            this.yearOfBirth = yearOfBirth;
            this.class_ = class_;
        }
    }
}