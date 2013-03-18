using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    public class Kitten : Cat, ISound
    {        
        public Kitten()
        {            
        }

        public Kitten(string _name, int _age, _Sex _sex)
            : base(_name, _age, _sex)
        {
            if (_sex != _Sex.Female)
            {
                throw new ArgumentException("Kittens must be female!");
            }    
        }

        new public void GetSound()
        {
            Console.WriteLine("The Kitten say: Miaou!");
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
