using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
       
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car-DONE
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable-DONE
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise() -Done
            //The methods should take one string parameter: the respective noise property -Done

            var lot = new CarLot();
            
            //Now that the Car class is created we can instanciate 3 new cars-done

            //Set the properties for each of the cars-done
            //Call each of the methods for each car-done

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            var car1 = new Car();
            Console.WriteLine($"Number of cars: {CarLot.numberOfCars}");
            car1.Year = 2020;
            car1.Make = "Toyota";
            car1.Model = "Supra";
            car1.EngineNoise = "Vroom";
            car1.HonkNoise = "Beep Beep";
            car1.IsDriveable = true;

            car1.MakeEngineNoise();
            car1.MakeHonkNoise();



            var car2 = new Car();

            car2.Year = 1965;
            car2.Make = "Ford";
            car2.Model = "F-100";
            car2.EngineNoise = "Nothing";
            car2.HonkNoise = "Help"; 
            car2.IsDriveable = false;
            
            Console.WriteLine($"Number of cars: {CarLot.numberOfCars}");
            car2.MakeEngineNoise();
            car2.MakeHonkNoise();

           

            var car3 = new Car();
            Console.WriteLine($"Number of cars: {CarLot.numberOfCars}");

            car3.Year = 1999;
            car3.Make = "Nissan";
            car3.Model = "Skyline GTR";
            car3.EngineNoise = "Braaaap";
            car3.HonkNoise = "Boop Boop";
            car3.IsDriveable = true;

            car3.MakeEngineNoise();
            car3.MakeHonkNoise();
            Console.WriteLine();

            var car4 = new Car();
            car4.Year = 2020;
            car4.Make = "Challenger";
            car4.Model = "Demon";
            car4.EngineNoise = "Roar";
            car4.HonkNoise = "Honk Honk";
            car4.IsDriveable = false;

            car4.MakeEngineNoise();
            car4.MakeHonkNoise();


            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            Console.WriteLine($"Number of cars created {CarLot.numberOfCars}");
            lot.Cars.Add(car1);
            lot.Cars.Add(car2);
            lot.Cars.Add(car3);
            lot.Cars.Add(car4);


            foreach (var car in lot.Cars)
            {
                Console.WriteLine($"Year {car.Year} Make {car.Make} Model {car.Model} ");
                car.MakeEngineNoise();
                car.MakeHonkNoise();
                Console.WriteLine("------------------------");



            }
            Console.WriteLine($"Number of cars: {CarLot.numberOfCars}");
        }
        
    }
}
