using System;

namespace Homework_No._6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[Electricity Bill Calculator (per month)]");

            int DeviceWattage; 
            int AmountofDevices;
            double Hours;
            char Finished;
            decimal Bill1 = 0;
            do
            {
                Console.Write("Please input The device's Wattage (Watt): ");
                DeviceWattage = int.Parse(Console.ReadLine());

                Console.Write("Please input The Amount of Device you Used: ");
                AmountofDevices = int.Parse(Console.ReadLine());

                Console.Write("Please input The Amount of Time you Used the Device (Hours): ");
                Hours = double.Parse(Console.ReadLine());

                decimal Bill = CalculateElectricityBill(DeviceWattage, AmountofDevices, Hours);
                Bill1 = Bill1 + Bill;
                
                Console.Write("Finished?? Y/N: ");
                Finished = char.Parse(Console.ReadLine());

            } while (Finished != 'Y');

            Console.WriteLine("This month you use {0}", Bill1);
            PayMoney(Bill1);
        }


        static decimal CalculateElectricityBill(int DeviceWattage, int AmountofDevices, double Hours)
        {
            decimal BillperDay = (((decimal)DeviceWattage * (decimal)AmountofDevices) / 1000) * (decimal)Hours;
            Console.WriteLine("You use {0} per day.", BillperDay);

            decimal BillperMonth = (decimal)BillperDay * 30;
            Console.WriteLine("You use {0} per month.", BillperMonth);

            return BillperMonth;
        }

        static void PayMoney(decimal Bill1)
        {
            decimal Money = 0;
            if (Bill1 <= 35)
            {
                Money = Money + (decimal)85.21;
            }
            else if (Bill1 > 35 && Bill1 <= 150)
            {
                Money = Money + (decimal)85.21 + (((decimal)Bill1 - 35) * (decimal)1.1236);
            }
            else if (Bill1 > 150 && Bill1 <= 400)
            {
                Money = Money + (decimal)214.424 + ((Bill1 - 150) * (decimal)2.1329);
            }
            else if (Bill1 > 400)
            {
                Money = Money + (decimal)747.649 + ((Bill1 - 400) * (decimal)2.4226);
            }

            Console.WriteLine("You need to pay {0} Baht this month.", Money);
        }
    }
}
