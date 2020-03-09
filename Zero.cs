using System;

namespace inheritance
{
    public class Zero : Vehicle
    { // Electric motorcycle
        public double BatteryKWh { get; set; }
        public void ChargeBattery() { }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero goes pew pew pew!");
        }

        public void Turn(string direction)
        {
            Console.WriteLine($"The Zero carefully turns {direction}");
        }

        public void Stop()
        {
            Console.WriteLine($"The Zero gently comes to a stop.");
        }
    }
}