using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    class MobilePhone
    {
        static void Main(string[] args)
        {            
            Battery battery = new Battery("cRU", 200, 8, BatteryType.LiIon);
            Display display = new Display(3.5, 16000000);
            GSM iPhone4 = new GSM("iPhone4S", "Apple", 969, "Владислав", battery, display);
                                 
            GSMTest test1 = new GSMTest();
            test1.Fill();
            Console.WriteLine("\nИнформация за:\n");
            Console.WriteLine(GSM.IPhone4S);
            Console.WriteLine("____________________________________________________________\n");

            GSMCallHistoryTest test2 = new GSMCallHistoryTest();
            test2.DataFill();
            test2.Print();
            test2.RemoveTheLongest();
            test2.ClearCallHistory();
            Console.WriteLine();
        }
    }
}
