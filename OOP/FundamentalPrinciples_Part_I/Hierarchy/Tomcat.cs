using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    public class Tomcat : Cat, ISound
    {        
        public Tomcat()
        {            
        }

        public Tomcat(string _name, int _age, _Sex _sex)
            : base(_name, _age, _sex)
        {
            if (_sex != _Sex.Male)
            {
                throw new ArgumentException("Tomcats must be male!");
            }
        }

        new public void GetSound()
        {
            Console.WriteLine("The Tomcat say: Miaou!");
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
