using System;

namespace Properties_Morgan_Daniel
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(); // Car object
            car.Make = "Ford"; // Assigns the Car object a make
            car.Model = "Mustang"; // Assigns the Car object a model

            Console.WriteLine($"Make: {car.Make}, Model: {car.Model}"); // Prints the make and model to the console

            Car car2 = new Car(); // A second car object
            car2.Make = "Chevy";  // Assigns the Car object a make
            car2.Model = "Camero"; // Assigns the Car object a model

            Console.WriteLine($"Make: {car2.Make}, Model: {car2.Model}"); // Prints both the make and model to the console
        }
    }
}
