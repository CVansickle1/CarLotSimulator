using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            CarLot inStock = new CarLot();

            Car carOne = new Car();
            Console.WriteLine($"Number of Cars in the Lot: {CarLot.numberOfCars}");
            Car carTwo = new Car(2022, "Hyundai", "Elantra", "Hum", "Beep", true);
            Console.WriteLine($"Number of Cars in the Lot: {CarLot.numberOfCars}");
            Car carThree = new Car() { Year = 1985, Make = "Ford", Model ="Mustang", EngineNoise = "vroom", HonkNoise = "awoogah", IsDrivable = true};
            Console.WriteLine($"Number of Cars in the Lot: {CarLot.numberOfCars}");



            carOne.Year = 2002;
            carOne.Make = "Toyota";
            carOne.Model = "Camry";
            carOne.EngineNoise = "Buzz";
            carOne.HonkNoise = "Honk";
            carOne.IsDrivable = false;

            
            inStock.CarsInStock.Add(carOne);
            inStock.CarsInStock.Add(carTwo);
            inStock.CarsInStock.Add(carThree);


            foreach(var item in inStock.CarsInStock)
            {
                Console.WriteLine(item.Year);
                Console.WriteLine(item.Make);
                Console.WriteLine(item.Model);
                Console.WriteLine();
            }
           

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
