using System;

namespace SumAndAverageSpace
{
    // class
    class SumAndAverage
    {
        //numbers array
        public int[] numbers;
        //constructor
        public SumAndAverage(int[] numbers)
        {
            this.numbers = numbers;
        }
        //method to print sum
        public void getSum()
        {
            int sum = 0;
            foreach(int num in numbers)
            {
                sum = sum + num;
            }
            Console.WriteLine("The sum of numbers is :" + sum);
        }
        //method to print average 
        public void getAverage()
        {
            int sum = 0;
            float avg;
            foreach (int num in numbers)
            {
                sum = sum + num;
            }
            int length = numbers.Length;
            avg = sum/length;
            Console.WriteLine("The average of numbers is :" + avg);
            
        }
    }
}
