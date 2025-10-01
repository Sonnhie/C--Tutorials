namespace Day3
{
    class AbsoluteDifference
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int n = Convert.ToInt32(Console.ReadLine());

            int result = ReturnAbsoluteDifference(n);

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("The absolute difference is: " + result);

            Console.WriteLine("Press any key....");
            Console.ReadKey();
        }

        public static int ReturnAbsoluteDifference(int n)
        {
            int subtractor = 51;
            int difference = 0;

            if (n < subtractor)
            {
                difference = subtractor - n;
            }

            if (n > subtractor)
            {
                difference = (n - subtractor) * 3;
            }

            return difference;
        }
    }
}