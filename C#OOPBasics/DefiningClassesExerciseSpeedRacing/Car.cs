using System;

namespace DefiningClassesExerciseSpeedRacing
{
    public class Car
    {
        public string model;
        public double fuel;
        public double fuelConsumtion; 
        public double distanceTraveled;

        public Car(string model, double fuel, double fuelConsumtion)
        {
            this.model = model;
            this.fuel = fuel;
            this.fuelConsumtion = fuelConsumtion;
            this.distanceTraveled = 0;   
        }

        public void Drive(int amountOfKilometers)
        {
            if (amountOfKilometers <= this.fuel / this.fuelConsumtion)
            {
                this.distanceTraveled += amountOfKilometers;
                this.fuel -= this.fuelConsumtion * amountOfKilometers;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

    }
}
