using System;

namespace RemoveDuplicatesSpace
{
    //class
    class RemoveDuplicates
    {
        //method to remove duplicates in an array
        public int[] removeDuplicates(int[] array)
        {
            int n = array.Length;

            // Check for edge case of empty array
            if (n == 0)
                return new int[0];

            // Count the occurrences of each element in the array
            int[] count = new int[n];
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (array[i] == array[j])
                    {
                        count[j]++;
                    }
                }
            }

            // Calculate the number of unique elements
            int uniqueCount = 1;
            for (int i = 1; i < n; i++)
            {
                if (count[i] == 0)
                {
                    uniqueCount++;
                }
            }

            // Create a new array to store unique elements
            int[] uniqueArray = new int[uniqueCount];
            uniqueArray[0] = array[0];
            int k = 1;

            // Copy unique elements to the new array
            for (int i = 1; i < n; i++)
            {
                if (count[i] == 0)
                {
                    uniqueArray[k++] = array[i];
                }
            }

            return uniqueArray;
        }

        //method to print array
        public void PrintArray(int[] array)
        {
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }

}