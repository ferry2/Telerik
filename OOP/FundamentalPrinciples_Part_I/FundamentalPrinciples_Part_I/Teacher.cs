using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalPrinciples_Part_I
{
    public class Teacher : People
    {
        private List<Discipline> disciplines;
        public List<Discipline> Disciplines
        {
            get 
            {
                var listDisciplines = (from disc in disciplines select disc).ToList();
                return listDisciplines; 
            }            
        }

        private string comment;
        public string Comment
        {
            get { return this.comment; }
            set { this.comment = value; }
        }

        public Teacher(string _name)
            : base(_name)
        {
            this.disciplines = new List<Discipline>();
        }

        public Teacher(string _name, Discipline _discipline) 
            : base(_name)
        {            
            this.disciplines = new List<Discipline>();
            this.disciplines.Add(_discipline);            
        }

        public Teacher(string _name, Discipline _discipline, string _comment)
            : base(_name)
        {            
            this.disciplines = new List<Discipline>();
            this.disciplines.Add(_discipline);
            this.comment = _comment;
        }

        public void AddDiscipline(Discipline _discipline)
        {
            this.disciplines.Add(_discipline);
        }

        public void RemoveDiscipline(Discipline _discipline)
        {
            if (!this.disciplines.Contains(_discipline))
            {
                throw new ArgumentException("The discipline does not exists!");
            }
            else
            {
                this.disciplines.Remove(_discipline);
            }
        }        
    }
}
