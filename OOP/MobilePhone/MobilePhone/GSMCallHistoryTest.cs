using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class GSMCallHistoryTest
    {
        GSM gsmInstance = new GSM("Nokia Lumia 900", "Nokia", 1014, "Ivan Ivanov", 
            new Battery("Energy Life", 300, 7, BatteryType.LiIon), new Display(4.3, 16000000));

        Call[] calls = new Call[5];
        string[] dates = { "01.06.2012", "23.09.2012", "15.10.2012", "12.01.2013", "02.03.2013" };
        string[] times = { "12:33:45", "01:54:03", "16:24:22", "11:31:51", "09:00:17" };
        string[] phoneNumbers = { "0899152641", "0888426837", "0885124796", "0896123458", "0887442156" };
        int[] seconds = { 44, 851, 752, 453, 312 };

        public void DataFill()
        {
            for(int i = 1; i < calls.Length ; i++)
            {
                calls[i] = new Call(dates[i], times[i], phoneNumbers[i], seconds[i]);
                gsmInstance.AddCall(calls[i]);                                
            }                       
        }

        public void Print()
        {
            for(int i = 0; i < gsmInstance.CallHistory.Count; i++)
            {
                Console.WriteLine("Date: {0}, \n\nTime: {1}, \n\nPhone number: {2}, \n\nDuration: {3}", 
                    gsmInstance.CallHistory[i].Date, 
                    gsmInstance.CallHistory[i].Time,
                    gsmInstance.CallHistory[i].PhoneNumber, 
                    gsmInstance.CallHistory[i].Duration);
            }

            Console.WriteLine("____________________________________________________________________________\n");
            Console.WriteLine("The total sum is: {0}", gsmInstance.TotalPrice(0.37));

            for (int i = 0; i < gsmInstance.CallHistory.Count; i++)
            {
                
            }
        }
    }
}
