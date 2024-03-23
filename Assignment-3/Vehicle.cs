using System;

namespace VehicleSpace
{
    public interface IDrawable
    {
        public void Draw();
    }

    //abstract vehicle class
    public abstract class Vehicle : IDrawable
    {
        //fields
        protected String brand;
        protected String model;

        //constructor
        public Vehicle(String brand, String model)
        {
            this.brand = brand;
            this.model = model;
        }

        //abstract methods
        public abstract void start();
        public abstract void stop();

        //method to display information
        public void displayInfo()
        {
            Console.WriteLine("Brand: " + brand);
            Console.WriteLine("Model: " + model);
        }

        public void Draw()
        {
            Console.WriteLine("The vehicle is constructed");
        }
    }
    
    //car class inherited from vehicle class
    class Car : Vehicle
    {
        //constructor
        public Car(string brand, string model) : base(brand, model) { }

        //abstarct method to start the car
        public override void start()
        {
            Console.WriteLine("The Car is Started...");
        }
        //abstarct method to stop the car
        public override void stop()
        {
            Console.WriteLine("The Car is Stopped....");
        }

        public void Draw()
        {
            Console.WriteLine("The car is manfactured");
        }
    }

    //motorcycle class inherited from vehicle class
    class Motorcycle : Vehicle
    {
        //constructor
        public Motorcycle(string brand, string model) : base(brand, model) { }
        
        //abstarct method to start the Motorcycle
        public override void start()
        {
            Console.WriteLine("The Motorcycle is Started...");
        }
        //abstarct method to stop the car
        public override void stop()
        {
            Console.WriteLine("The Motorcycle is Stopped....");
        }
        public void Draw()
        {
            Console.WriteLine("The Mototrcycle is manfactured");
        }
    }
}
