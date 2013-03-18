using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    public class Cat : Animal, ISound
    {
        public Cat()
        {            
        }

        public Cat(string _name, int _age, _Sex _sex)
            : base(_name, _age, _sex)
        {            
        }

        public void GetSound()
        {
            Console.WriteLine("The cat say: Miauuu!");
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
