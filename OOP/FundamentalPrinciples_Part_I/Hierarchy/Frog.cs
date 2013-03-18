using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    public class Frog : Animal, ISound
    {
        public Frog()
        {            
        }

        public Frog(string _name, int _age, _Sex _sex)
            : base(_name, _age, _sex)
        {            
        }

        public void GetSound()
        {
            Console.WriteLine("The Frog say: Croak!");
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
