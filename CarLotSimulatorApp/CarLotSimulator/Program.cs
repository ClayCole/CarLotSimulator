using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            var lot = new CarLot();
            




            //Done - Now that the Car class is created we can instanciate 3 new cars
            //Done - Set the properties for each of the cars
            //Call each of the methods for each car

            Car myCar = new Car();

            myCar.Year = 2012;
            myCar.Make = "Buick";
            myCar.Model = "Regal";
            myCar.EngineNoise = "quite";
            myCar.HonkNoise = "weird";
            myCar.IsDriveable = true;

            // , name of the collection , dot.Add , pass in the car:
            lot.Cars.Add(myCar); //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list. - NEEDED TO ADD THEM TO LOT LIST

            Console.WriteLine($" Here is your Car details: " +
                $"Year: {myCar.Year}," +
                $"Make: {myCar.Make}," +
                $"Model: {myCar.Model}," +
                $"Engine Noise: {myCar.EngineNoise}," +
                $"Honk: {myCar.HonkNoise}," +
                $"Drivable: {myCar.IsDriveable}");

            Console.WriteLine();
            Console.WriteLine();

            Car nextCar = new Car()
            {
                Year = 2024,
                Make = "Tesla",
                Model = "Model X",
                EngineNoise = "None",
                HonkNoise = "Loud",
                IsDriveable = true,
            };

            lot.Cars.Add(nextCar);

            Console.WriteLine($" Here is your Next Car details: " +
                $"Year: {nextCar.Year},Make: {nextCar.Make},Model: {nextCar.Model},Engine Noise: {nextCar.EngineNoise},Honk: {nextCar.HonkNoise},Drivable: {nextCar.IsDriveable}");

            Console.WriteLine();
            Console.WriteLine();

            Car dreamCar = new Car (2025, "BMW", "MX4", "Quite", "Different", true);

            lot.Cars.Add(dreamCar);

            Console.WriteLine($" Here is your Dream Car details: " +
                $"Year: {dreamCar.Year},Make:  {dreamCar.Make},Model: {dreamCar.Model},Engine Noise: {dreamCar.EngineNoise},Honk: {dreamCar.HonkNoise},Drivable: {dreamCar.IsDriveable}");


            //*************BONUS*************//

            //Done - Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Done - Create a CarLot class

            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine($"Number of Cars created: {CarLot.numberOfCars}");

            foreach(var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year}, Make:  {car.Make}, Model: {car.Model}, Engine Noise: " +
                    $"{car.EngineNoise}, Honk: {car.HonkNoise}, Drivable: {car.IsDriveable}");
            }

            
           
        }
    }
}
