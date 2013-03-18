using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalPrinciples_Part_I
{
    public class Student : People
    {
        private int classNumber;
        public int ClassNumber
        {
            get { return this.classNumber; }
        }

        private string comment;
        public string Comment
        {
            get { return this.comment; }
            set { this.comment = value; }
        }

        public Student()
        {            
        }

        public Student(string _name, int _classNumber)
        {
            this.name = _name;
            this.classNumber = _classNumber;
        }

        public Student(string _name, int _classNumber, string _comment)
        {
            this.name = _name;
            this.classNumber = _classNumber;
            this.comment = _comment;
        }       
    }
}
