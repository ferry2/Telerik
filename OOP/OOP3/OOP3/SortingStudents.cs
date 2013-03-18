using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public class SortingStudents
    {
        private string firtsName;
        public string FirstName
        {
            get { return this.firtsName; }
            set { this.firtsName = value; }
        }

        private string lastName;
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        private int age;
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public SortingStudents(string _firstName, string _lastName, int _age)
        {
            this.firtsName = _firstName;
            this.lastName = _lastName;
            this.age = _age;
        }

        public SortingStudents()
        {
            
        }

        public void Sort(SortingStudents[] student)
        {
            if(student == null)
            {
                throw new ArgumentNullException("The array is empty!");
            }

            var names = from name in student
                            where name.FirstName.CompareTo(name.LastName) == -1
                            select name;

            foreach(var name in names)
            {
                Console.WriteLine(name.FirstName + " " + name.LastName);
            }
        }
    }
}
