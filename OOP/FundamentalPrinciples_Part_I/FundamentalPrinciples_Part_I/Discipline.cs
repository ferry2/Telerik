using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalPrinciples_Part_I
{
    public class Discipline
    {
        private string name;
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        private int numberOfLectures;
        public int NumberOfLectures
        {
            get { return this.numberOfLectures; }
            set { this.numberOfLectures = value; }
        }

        private int numberOfExercises;
        public int NumberOfExercises
        {
            get { return this.numberOfExercises; }
            set { this.numberOfExercises = value; }
        }

        private string comment;
        public string Comment
        {
            get { return this.comment; }
            set { this.comment = value; }
        }

        public Discipline()
        {            
        }

        public Discipline(string _name, int _numberOfLectures, int _numberOfExercises)
        {
            this.name = _name;
            this.numberOfLectures = _numberOfLectures;
            this.numberOfExercises = _numberOfExercises;
        }

        public Discipline(string _name, int _numberOfLectures, int _numberOfExercises, string _comment)
        {
            this.name = _name;
            this.numberOfLectures = _numberOfLectures;
            this.numberOfExercises = _numberOfExercises;
            this.comment = _comment;
        }

        public Teacher Teacher
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}
