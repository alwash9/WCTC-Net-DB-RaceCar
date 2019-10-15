using System;
using System.Threading;
using RaceTrack.RaceTrack.Drivers;
using RaceTrack.RaceTrack.Cars;
using System.Collections.Generic;

namespace RaceTrack.RaceTrack.Cars
{
    public abstract class RaceCar
    {
        protected RaceCar()
        {
            Position = 0;
        }

        public string Name { get; set; }
        public int Position { get; set; }
        public int TopSpeed { get; set; }

        public void Accelerate(int driverSkill)
        {
            // applying a random amount of variability to affect the outcome
            var random = new Random();
            var randomRange = random.Next(-1, 20);
            Position += driverSkill * TopSpeed * randomRange;

            if (Position > 0)
                Console.WriteLine($"{Name} moves ahead to {Position}!");
            else if (Position < 0)
                Console.WriteLine($"{Name} moves backwards to {Position}!??");
            else
                Console.WriteLine($"{Name} has stopped!?");
        }

        public abstract void StartEngine();

        public virtual void Brake()
        {
            Console.WriteLine($"The {Name} ends in position {Position}!");
        }

        public virtual void StopEngine()
        {
            Console.WriteLine($"The driver cuts off the engine");
        }
    }
}