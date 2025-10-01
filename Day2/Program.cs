namespace Day2
{
    class TripleSumofEqualInteger
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int result = TripleSum(num1, num2);
            Console.WriteLine("-------------------------------------");

            Console.WriteLine("The result is: " + result);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        public static int TripleSum(int number1, int number2)
        {
            int total = 0;

            if (number1 != number2)
            {
                total = number1 + number2;
            }
            else if (number1 == number2)
            {
                total = (number1 + number2) * 3;
            }

            return total;
        }
    }
}
