using System;
using System.Linq;

namespace GSMProgram
{
    class GSMCallHistoryTest
    {
        static void Main()
        {
            GSM myGSM = new GSM("X510", "Philips");

            myGSM.AddCall(new Call(DateTime.Now, "0889 885 887", 15));
            myGSM.AddCall(new Call(DateTime.Now, "0889 332 774", 22));
            myGSM.AddCall(new Call(DateTime.Now, "0889 522 654", 377));
            myGSM.AddCall(new Call(DateTime.Now, "0889 653 123", 64));

            PrintCallHistory(myGSM);

            Console.WriteLine(Cost(myGSM));

            RemoveLongestCall(myGSM);

            Console.WriteLine(Cost(myGSM));

            myGSM.CallHistory.Clear();

            PrintCallHistory(myGSM);
        }

        private static void PrintCallHistory(GSM myGSM)
        {
            foreach (Call item in myGSM.CallHistory)
            {
                Console.WriteLine(item.ToString());
            }
        }

        private static void RemoveLongestCall(GSM myGSM)
        {
            int? longestCall = -1;
            int longestCallPosition = 0;

            for (int i = 0; i < myGSM.CallHistory.Count; i++)
            {
                if (myGSM.CallHistory[i].Duration > longestCall)
                {
                    longestCall = myGSM.CallHistory[i].Duration;
                    longestCallPosition = i;
                }
            }

            myGSM.CallHistory.RemoveAt(longestCallPosition);
        }

        private static double Cost(GSM myGSM)
        {
            double totalCost = 0;
            foreach (Call item in myGSM.CallHistory)
            {
                totalCost += item.Duration.Value * 0.37;
            }
            return totalCost;
        }
    }
}