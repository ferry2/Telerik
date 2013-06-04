using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class GSMTest
    {
        GSM[] testGSM = new GSM[5];

        string[] models = { "Samsung Galaxy S3", "HTC Evo3D", "LG Nexus 4", "Motorola Droid Razr", "HTC Droid DNA" };
        string[] manufacturers = { "Samsung", "HTC", "LG", "Motorola", "HTC" };
        decimal[] prices = { 800, 630, 1080, 699, 350 };
        string[] owners = { "Ivan", "Dragan", "Petar", "Galina", "Boris" };

        Battery[] batteries = new Battery[5];

        string[] batteryModels = { "Mugen Power", "Force", "BTD", "iLi", "Electric" };
        double[] hoursIdle = { 900, 358, 390, 372, 353 };
        double[] hoursTalk = { 61, 9, 15, 32, 12 };
        BatteryType[] types = { BatteryType.LiIon, BatteryType.LiIon, BatteryType.LiPo, BatteryType.LiIon, BatteryType.LiIon };

        Display[] displays = new Display[5];

        double[] sizes = { 4.8, 4.3, 4.7, 4.7, 5.0 };
        double[] colors = { 16000000, 16000000, 16000000, 16000000, 16000000 };

        public void Fill()
        {
            for (int i = 0; i < testGSM.Length; i++)
            {
                testGSM[i] = new GSM(models[i], manufacturers[i], prices[i], owners[i], 
                    new Battery(batteryModels[i], hoursIdle[i], hoursTalk[i], types[i]), new Display(sizes[i], colors[i]));

                Console.WriteLine("Mobile phone: {0}", testGSM[i].Model);
                Console.WriteLine(testGSM[i]);
                Console.WriteLine();
                Console.WriteLine("------------------------------------------------");
            }
        }
    }
}
