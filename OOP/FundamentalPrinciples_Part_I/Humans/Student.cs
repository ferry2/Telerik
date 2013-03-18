using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humans
{
    public class Student : Human
    {
        private int grade;
        public int Grade
        {
            get { return this.grade; }
            set { this.grade = value; }
        }

        public Student()
        {            
        }

        public Student(string _firstName, string _lastName)
            : base(_firstName, _lastName)
        {            
        }

        public Student(string _firstName, string _lastName, int _grade)
            : base(_firstName, _lastName)
        {
            this.grade = _grade;
        }
    }
}
