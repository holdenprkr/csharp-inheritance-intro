using System;

namespace inheritance
{
    public class Ram : Vehicle
    { // Gas powered truck
        public double FuelCapacity { get; set; }

        public void RefuelTank() { }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram goes rrrrrrrrrrrrumble!");
        }

        public void Turn(string direction)
        {
            Console.WriteLine($"The Ram carefully turns {direction}");
        }

        public void Stop()
        {
            Console.WriteLine($"The Ram rolls to the stop as if it were going to explode.");
        }
    }
}