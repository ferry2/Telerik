using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    public enum _Sex { Male, Female }

    public class Animal
    {
        private string name;
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        private int age;
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        private _Sex sex;
        public _Sex Sex
        {
            get { return this.sex; }
            set { this.sex = value; }
        }

        public Animal()
        {
        }

        public Animal(string _name, int _age, _Sex _sex)
        {
            this.name = _name;
            this.age = _age;
            this.sex = _sex;
        }

        public override string ToString()
        {
            return String.Format("Name: {0}, age: {1}, sex: {2}", this.name, this.age, this.sex);
        }
    }
}
