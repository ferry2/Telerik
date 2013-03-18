using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalPrinciples_Part_I
{
    public class SchoolClass
    {
        private string iD;
        public string ID
        {
            get { return this.iD; }
            set { this.iD = value; }
        }

        private List<Student> students;
        public List<Student> Students
        {
            get { return this.students; }
            set { this.students = value; }
        }

        private List<Teacher> teachers;
        public List<Teacher> Teachers
        {
            get { return this.teachers; }
            set { this.teachers = value; }
        }
        private string comment;
        public string Comment
        {
            get { return this.comment; }
            set { this.comment = value; }
        }

        public SchoolClass()
        {
            this.students = new List<Student>();
            this.teachers = new List<Teacher>();
        }

        public SchoolClass(string _ID)
        {
            this.iD = _ID;
            this.students = new List<Student>();
            this.teachers = new List<Teacher>();
        }

        public SchoolClass(string _ID, Student _student)
        {
            this.iD = _ID;
            this.students = new List<Student>();
            this.students.Add(_student);
            this.teachers = new List<Teacher>();
        }

        public SchoolClass(string _ID, Student _student, Teacher _teacher)
        {
            this.iD = _ID;
            this.students = new List<Student>();
            this.students.Add(_student);
            this.teachers = new List<Teacher>();
            this.teachers.Add(_teacher);            
        }

        public SchoolClass(string _ID, Student _student, Teacher _teacher, string _comment)
        {
            this.iD = _ID;
            this.students = new List<Student>();
            this.students.Add(_student);
            this.teachers = new List<Teacher>();
            this.teachers.Add(_teacher);
            this.comment = _comment;
        }

        public void AddStudent(Student student)
        {
            foreach (Student item in students)
            {
                if (item.ClassNumber == student.ClassNumber)
                {
                    throw new ArgumentException("Already exist student with this class number.");
                }    
                else
                {
                    this.students.Add(student);
                }
            }                       
        }

        public void AddTeacher(Teacher teacher)
        {
            this.teachers.Add(teacher);
        }
    }
}
