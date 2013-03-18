using System;
using System.Linq;

namespace GSMProgram
{
    class TestClass
    {
        static void Main()
        {
            GSM[] arrayOfGSMs =
            {
                new GSM("Asha", "Nokia"),
                new GSM("Duos", "Samsung", 500, "Me"),
                new GSM("Desire", "HTC", 250, "Him"),
                new GSM("STYLISTIC S01", "Fujitsu", 100, "You",
                    new Display(100,200,15),
                    new Battery(15,15,Battery.Type.NiMH),
                    new Call(DateTime.Now,"+359888586586",25))
            };

            arrayOfGSMs[1].AddCall(new Call(DateTime.Now, "0888586771", 1));
            arrayOfGSMs[1].AddCall(new Call(DateTime.Now, "2345242", 2));
            arrayOfGSMs[1].AddCall(new Call(DateTime.Now, "456456456", 3));
            arrayOfGSMs[1].AddCall(new Call(DateTime.Now, "234234", 4));

            for (int i = 0; i < arrayOfGSMs.Length; i++)
            {
                Console.WriteLine(arrayOfGSMs[i].ToString());
                Console.WriteLine();
            }            
        }
    }
}