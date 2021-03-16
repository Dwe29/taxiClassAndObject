using System;

namespace tugas_Taxi_class_and_object
{
    class Program
    {
        static void Main(string[] args)
        {
            taxi driver = new taxi();
            driver.driverName = "Jono";
            driver.onDuty = true;
            driver.numPassenger = 10;
            driver.taxiInfo();
            driver.pickUpPassenger();
            driver.dropOfPassenger();
        }
    }
}
