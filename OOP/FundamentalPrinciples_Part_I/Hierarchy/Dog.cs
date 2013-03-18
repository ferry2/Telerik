using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    public class Dog : Animal, ISound
    {        
        public Dog()
        {            
        }

        public Dog(string _name, int _age, _Sex _sex) 
            : base(_name, _age, _sex)
        {            
        }

        public void GetSound()
        {
            Console.WriteLine("The Dog say: Bau!");
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
