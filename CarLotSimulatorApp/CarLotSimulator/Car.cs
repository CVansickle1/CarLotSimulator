using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{    
     
    internal class Car
    {
        public Car()
        {

        }
        public Car(int year, string make, string model, string engine, string honk, bool drivable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engine;
            HonkNoise = honk;
            IsDrivable = drivable;
        }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDrivable { get; set; }

        public void MakeEngineNoise(string engineVolume)
        {
            Console.WriteLine($"Your car goes {engineVolume}");
        }

        public void MakeHonkNoise(string honkVolume)
        {
            Console.WriteLine($"When you Honk your horn it makes a {honkVolume} sound");
        }

    }
}
