using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;

namespace CarLotSimulator
{
    public class Car
    {
        //DONE - Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
        //Done - Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
        //The methods should take one string parameter: the respective noise property
       
        public Car()
        {
            //Create a static field called numberOfCars inside of the CarLot class
            //Have this number only increment when we create a new car

            CarLot.numberOfCars++;

            // ^^ Classname . Static Member 
        }

        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;
        }

        //1)
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        //2)

        public void MakeEngineNoise(string engineNoise)
        {
            Console.WriteLine(engineNoise);

        }

        public void MakeHonkNoise(string honkNoise)
        {
            Console.WriteLine(honkNoise);

        }

        private static void CarPrinter<T>(T collection) where T : IEnumerable<int>
        {
            
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}


