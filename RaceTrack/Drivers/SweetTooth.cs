using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaceTrack.RaceTrack.Cars;

namespace RaceTrack.RaceTrack.Drivers
{
    class SweetTooth : Driver
    {
        public SweetTooth(RaceCar car) : base(car)
        {
            Name = "Sweet Tooth the Clown";
            SkillLevel = 12;
        }

        public override void Drive()
        {
            Console.WriteLine($"Ice cream starts to fall out of the back of {Car.Name}");
            Car.Accelerate(SkillLevel);
        }

        public override void Accelerate()
        {

            var random = new Random();

            string[] sweetMessage = new string[]
            {
                "$Ice cream and candy are littering the race track!\n",
                "Sonic and Mario gumball ice cream is splatting all over the road!\n",
                "",
                $"Wait are those Oompa Loompas jumping out the back of the {Car.Name}?\n",
                $"Dipping Dots are bursting out of the {Car.Name}'s windows!\n"
            };


            Console.Write(sweetMessage[random.Next(0, 4)]);
            base.Accelerate();
        }

        public override void StopEngine()
        {
            Console.WriteLine($"{Name} gets out of the {Car.Name} licking a fudgesicle.");
        }

    }
}
