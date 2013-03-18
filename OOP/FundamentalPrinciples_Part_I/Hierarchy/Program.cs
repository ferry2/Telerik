using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Frog[] frog = new Frog[]
            {
                new Frog("Green frog", 15, _Sex.Female),
                new Frog("Aga", 25, _Sex.Male),
                new Frog("Jaburana", 19, _Sex.Female),
                new Frog("Frog", 1, _Sex.Male),
                new Frog("Darvesna jaba", 7, _Sex.Male)
            };            
            AverageAge(frog);
            

            Dog[] dog = new Dog[]
            {
                new Dog("Husky", 4, _Sex.Female),
                new Dog("Koli", 14, _Sex.Male),
                new Dog("Nemska Ovcharka", 6, _Sex.Male),
                new Dog("Pekinez", 9, _Sex.Male),
                new Dog("pitbull", 24, _Sex.Female)
            };
            AverageAge(dog);
            
            Cat[] cat = new Cat[]
            {
                new Cat("Siam", 4, _Sex.Female),        
                new Cat("Maca", 15, _Sex.Female),
                new Cat("kote", 8, _Sex.Male),
                new Cat("Suzi", 3, _Sex.Male),
                new Cat("Mutzi", 9, _Sex.Male)
            };
            AverageAge(cat);

            Kitten[] kitten = new Kitten[]
            {
                new Kitten("Motzi", 16, _Sex.Female),
                new Kitten("Sali", 6, _Sex.Female),
                new Kitten("Koki", 3, _Sex.Female),
                new Kitten("Loli", 2, _Sex.Female),
                new Kitten("Susi", 26, _Sex.Female)
            };
            AverageAge(kitten);

            Tomcat[] tomcat = new Tomcat[]
            {
                new Tomcat("Tom", 18, _Sex.Male),        
                new Tomcat("Jerry", 3, _Sex.Male),
                new Tomcat("Bobi", 6, _Sex.Male),
                new Tomcat("Rijo", 10, _Sex.Male),
                new Tomcat("Vasko", 7, _Sex.Male)
            };
            AverageAge(tomcat);
        }

        public static void AverageAge(Animal[] animals)
        {
            var average = (from animal in animals
                             select animal.Age).Average();
            Console.WriteLine("The average age of {0} is {1} г.", animals.GetType().Name, average);
        }
    }
}
