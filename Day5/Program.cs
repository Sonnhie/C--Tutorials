namespace Day5
{
    class WithinRange
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------------------------------");
            Console.WriteLine(testNumbers(n1));
            Console.WriteLine("Press any key.............");
            Console.ReadKey();
        }

        public static bool testNumbers(int n1)
        {
            return n1 >= 10 || n1 == 200;
        }
    }
}