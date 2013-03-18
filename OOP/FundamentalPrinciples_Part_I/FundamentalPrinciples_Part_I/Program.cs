using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalPrinciples_Part_I
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Teacher teach = new Teacher("Vladislav");

            Discipline disc1 = new Discipline("Math", 30, 45);
            Discipline disc2 = new Discipline("Biology", 35, 70);
            Discipline disc3 = new Discipline("Informatics", 22, 60);
            Discipline disc4 = new Discipline("Physics", 30, 60);
            Discipline disc5 = new Discipline("Chemistry", 30, 60);

            teach.AddDiscipline(disc1);
            teach.AddDiscipline(disc2);
            teach.AddDiscipline(disc3);

            teach.AddDiscipline(disc4);

            teach.RemoveDiscipline(disc5);

            foreach (Discipline disc in teach.Disciplines)
            {
                Console.WriteLine(disc.Name);
            }
        }

    }     
 }

