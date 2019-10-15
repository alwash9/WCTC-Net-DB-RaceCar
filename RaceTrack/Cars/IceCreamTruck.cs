using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    class IceCreamTruck : RaceCar
    {
        public IceCreamTruck()
        {
            Name = "Ice Cream Truck";
            TopSpeed = 45;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"\"Pop Goes the Weasel\" begins to play in the {Name}'s speaker.");
        }

        public override void Brake()
        {
            Console.WriteLine($"Bomb Pops are starting to fall out of the back of the {Name}. Please keep your children off the track.");
            base.Brake();
        }

        public override void StopEngine()
        {
            Console.WriteLine($"The {Name}'s hood bubbles with melted ice cream");
        }

    }
}
