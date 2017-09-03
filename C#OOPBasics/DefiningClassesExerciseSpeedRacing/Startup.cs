using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClassesExerciseSpeedRacing
{
    public class Startup
    {
        public static void Main()
        {
            List<Car> cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string model = input[0];
                double fuel = double.Parse(input[1]);
                double fuelConsumption = double.Parse(input[2]);
                Car car = new Car(model, fuel, fuelConsumption);
                cars.Add(car);
            }
            string driveCommand = Console.ReadLine();
            while (driveCommand != "End")
            {
                string[] driveCommandArgs = driveCommand.Split();
                string carModel = driveCommandArgs[1];
                int amountOfKilometers = int.Parse(driveCommandArgs[2]);
                var carToDrive = cars.First(c => c.model == carModel);
                carToDrive.Drive(amountOfKilometers);
                driveCommand = Console.ReadLine();
            }
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.model} {car.fuel:f2} {car.distanceTraveled}");
            }
        }
    }
}
