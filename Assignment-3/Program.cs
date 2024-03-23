using System;
using ShapeSpace;
using VehicleSpace;
using SumAndAverageSpace;
using MinAndMaxSpace;
using ReverseAnArraySpace;
using RemoveDuplicatesSpace;

namespace ProgramSpace
{
    class Program
    {

        public void CreateCircleAndRectangleObjects()
        {
            int choice;
            Console.WriteLine("Enter 1 for Circle and 2 for Rectangle");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the radius of the circle");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    Circle circle = new Circle(radius);
                    Console.WriteLine("The Area of the circle : " +  circle.getArea());
                    Console.WriteLine("The Perimeter of the circle : "+ circle.getPerimeter());
                    circle.draw();
                    break;
                case 2:
                    Console.WriteLine("Enter the length of the rectangle");
                    double length = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the breadth of the rectangle");
                    double breadth = Convert.ToDouble(Console.ReadLine());
                    Rectangle rectangle = new Rectangle(length,breadth);
                    Console.WriteLine("The Area of the Rectangle : " + rectangle.getArea());
                    Console.WriteLine("The Perimeter of the Rectangle : "+ rectangle.getPerimeter());
                    rectangle.draw();
                    break;
                default:
                    Console.WriteLine("Invalid Choice...");
                    break;

            }
        }

        public void CreateCarAndMotorcycleObjects()
        {
            int choice;
            Console.WriteLine("Enter 1 for Car and 2 for Motorcycle");
            choice = Convert.ToInt32(Console.ReadLine());
            switch ( choice )
            {
                case 1:
                    Console.WriteLine("Enter the brand of the car");
                    string brand = Console.ReadLine();
                    Console.WriteLine("Enter the model of the car");
                    string model = Console.ReadLine();
                    Car car = new Car(brand, model);
                    car.Draw();
                    car.displayInfo();
                    car.start();
                    car.stop();
                    break;
                case 2:
                    Console.WriteLine("Enter the brand of the Motorcycle");
                    string brandMotorcycle = Console.ReadLine();
                    Console.WriteLine("Enter the model of the Motorcycle");
                    string modelMotorcycle = Console.ReadLine();
                    Motorcycle motorcycle = new Motorcycle(brandMotorcycle, modelMotorcycle);
                    motorcycle.Draw();
                    motorcycle.displayInfo();
                    motorcycle.start();
                    motorcycle.stop();
                    break;
                default:
                    Console.WriteLine("Invalid Choice...");
                    break;
            }
        }

        public void CreateSumAndAverageObject()
        {
            Console.Write("Enter the number of elements in the array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter element {i + 1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            SumAndAverage sumAndAverage = new SumAndAverage(numbers);
            sumAndAverage.getSum();
            sumAndAverage.getAverage();

        }

        public void CreateMinAndMaxObject()
        {
            Console.Write("Enter the number of elements in the array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter element {i + 1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            MinAndMax minAndMax = new MinAndMax(numbers);
            minAndMax.getMin();
            minAndMax.getMax();

        }

        public void CreateReverseAnArrayObject()
        {
            Console.Write("Enter the number of elements in the array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter element {i + 1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            ReverseAnArray reverseArray = new ReverseAnArray(numbers);
            reverseArray.reverseWithAdditionSpace();
            reverseArray.reverseInPlace();
        }

        public void CreateRemoveDuplicatesObject()
        {
            Console.Write("Enter the number of elements in the array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter element {i + 1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            RemoveDuplicates removeDuplicates = new RemoveDuplicates();
            Console.WriteLine("Original Array : ");
            removeDuplicates.PrintArray(numbers);
            Console.WriteLine("\nArray after removing duplicates:");
            int[] uniqueArray = removeDuplicates.removeDuplicates(numbers);
            removeDuplicates.PrintArray(uniqueArray);
        }

        public static void Main()
        {
            //Program exercise1_3 = new Program();
            //exercise1_3.CreateCircleRectangleObjects();

            //Program exercise2_4 = new Program();
            //exercise2_4.CreateCarAndMotorcycleObjects();

            //Program exercise6 = new Program();
            //exercise6.CreateSumAndAverageObject();

            //Program exercise7 = new Program();
            //exercise7.CreateMinAndMaxObject();

            //Program exercise8 = new Program();
            //exercise8.CreateReverseAnArrayObject();

            //Program exercise9 = new Program();
            //exercise9.CreateRemoveDuplicatesObject();
        }
    }
}