using System;

namespace MinAndMaxSpace
{
    //class
    class MinAndMax
    {
        //field
        int[] numbers;
        //constructor
        public MinAndMax(int[] numbers) 
        {
        this.numbers = numbers;
        }

        //method to print the minimum element
        public void getMin()
        {
            Console.WriteLine("The minimum of given numbers is : " + numbers.Min());
        }
        //method to print the maximum element
        public void getMax()
        {
            Console.WriteLine("The minimum of given numbers is : " + numbers.Max());
        }
    }
}
