using System;

namespace Day1
{
    class BiggestNumber
    {
        static void Main(string[] args)
        {
            int[] numberList = { 1, 18, 5, 12, 11, 0, 33, 105, 20, 88, 9, 32 };
            int biggestNumber = FindBiggestNumber(numberList);
            Console.WriteLine("The biggest number in the list is: " + biggestNumber);
        }

        public static int FindBiggestNumber(int[] numbersList)
        {
            int biggestNumber = numbersList[0];

            //using foreach loop
            // foreach (int number in numbersList)
            // {
            //     if (number > biggestNumber)
            //     {
            //         biggestNumber = number;
            //     }
            // }

            //using for loop
            // for (int i = 1; i < numbersList.Length; i++)
            // {
            //     if (numbersList[i] > biggestNumber)
            //     {
            //         biggestNumber = numbersList[i];
            //     }
            // }

            //while loop
            // int i = 1;
            // while (i < numbersList.Length)
            // {
            //     if (numbersList[i] > biggestNumber)
            //     {
            //         biggestNumber = numbersList[i];
            //     }

            //     i++;
            // }

            //using do while loop
            int i = 1;

            do
            {
                if (numbersList[i] > biggestNumber)
                {
                    biggestNumber = numbersList[i];
                }

                i++;
            }
            while (i < numbersList.Length);

            return biggestNumber;
        }
    }
}