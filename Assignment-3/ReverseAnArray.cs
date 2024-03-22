using System;

namespace ReverseAnArraySpace
{ 
    //class
    class ReverseAnArray
    {
        //array
        public int[] numbers;

        //constructor
        public ReverseAnArray(int[] numbers)
        {
            this.numbers = numbers;
        }

        //method to reverse an array using additional space
        public void reverseWithAdditionSpace()
        {
            int[] temp = new int[numbers.Length];
             int length = numbers.Length;
            for (int i=0;i<numbers.Length; i++)
            {
                int req = length - i - 1;
                temp[i] = numbers[req];
            }
            Console.WriteLine("The reverse of array with using additional space : ");
            foreach (int i in temp)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");
        }

        //method to reverse an array without using additional space
        public void reverseInPlace()
        {
            int left = 0;
            int right = numbers.Length - 1;

            // Swap elements from both ends towards the middle
            while (left < right)
            {
                int temp = numbers[left];
                numbers[left] = numbers[right];
                numbers[right] = temp;
                left++;
                right--;
            }
            Console.WriteLine("The reverse of array without using additional space : ");
            foreach (int i in numbers)
            {
                Console.Write(i + " ");
            }
        }

    }
}
