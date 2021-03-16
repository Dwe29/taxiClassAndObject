using System;

namespace tugas_Taxi_class_and_object
{
    public class taxi
    {
        public String driverName { get; set; }
        public bool onDuty { get; set; }
        public int numPassenger { get; set; }

        public void taxiInfo()
        {
            Console.WriteLine($"Driver Name: {driverName}");
            if (onDuty)
            {
                Console.WriteLine("On Duty: Yes");
            }
            else
            {
                Console.WriteLine("On Duty: No");
            }
            Console.WriteLine("Number of Passenger: {0}", numPassenger);
        }

        public void pickUpPassenger()
        {
            Console.WriteLine("\n{0} Sedang menjemput Penumpang", driverName);
        }

        public void dropOfPassenger()
        {
            Console.WriteLine("{0} Selesai Mengantar Penumpang", driverName);
        }
    }
}
