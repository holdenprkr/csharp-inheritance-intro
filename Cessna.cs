using System;

namespace inheritance
{
    public class Cessna : Vehicle
    { // Propellor light aircraft
        public double FuelCapacity { get; set; }

        public void RefuelTank() { }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna goes zoooooom!");
        }

        public void Turn(string direction)
        {
            Console.WriteLine($"The Cessna carefully turns {direction}");
        }

        public void Stop()
        {
            Console.WriteLine($"The Cessna about crashes while it comes to a stop.");
        }
    }
}