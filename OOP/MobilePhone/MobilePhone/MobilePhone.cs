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
            GSM iPhone4 = new GSM("iPhone4S", "Apple", 969, "Vladisdlav", battery, display);
                                 
            GSMTest test1 = new GSMTest();
            test1.Fill();
            Console.WriteLine(GSM.IPhone4S);

            GSMCallHistoryTest test2 = new GSMCallHistoryTest();
            test2.DataFill();
            test2.Print();

            Console.WriteLine();


        }
    }
}
