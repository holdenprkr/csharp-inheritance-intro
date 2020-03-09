using System;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var myBike = new Zero();

            // I can still reference the inherited property
            myBike.MainColor = "Black";
            myBike.MaximumOccupancy = 2;
            myBike.BatteryKWh = 4.523;

            var myTesla = new Tesla();

            myTesla.MainColor = "Midnight Silver";
            myTesla.MaximumOccupancy = 6;
            myTesla.BatteryKWh = 3.221;

            var myCessna = new Cessna();

            myCessna.MainColor = "Sky Blue";
            myCessna.MaximumOccupancy = 12;
            myCessna.FuelCapacity = 52.5;

            var myRam = new Ram();

            myRam.MainColor = "Red";
            myRam.MaximumOccupancy = 5;
            myRam.FuelCapacity = 40.25;

            myBike.Drive();
            myBike.Turn("right");
            myBike.Stop();
            Console.WriteLine("");
            myTesla.Drive();
            myTesla.Turn("left");
            myTesla.Stop();
            Console.WriteLine("");
            myCessna.Drive();
            myCessna.Turn("up");
            myCessna.Stop();
            Console.WriteLine("");
            myRam.Drive();
            myRam.Turn("right");
            myRam.Stop();
            Console.WriteLine("");
        }
    }
}