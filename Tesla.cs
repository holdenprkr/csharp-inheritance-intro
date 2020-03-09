using System;

namespace inheritance
{
    public class Tesla : Vehicle
    { // Electric car
        public double BatteryKWh { get; set; }

        public void ChargeBattery() { }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla goes rumble rumble!");
        }

        public void Turn(string direction)
        {
            Console.WriteLine($"The Tesla skrrrrts to the {direction}");
        }

        public void Stop()
        {
            Console.WriteLine($"The Tesla rolls to the stop as if it never moved.");
        }

    }
}