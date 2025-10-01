namespace Day4
{
    class CheckedSumEquals
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int input2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--------------------------------------");
            bool result = CheckSum(input1, input2);
            Console.WriteLine("Result: " + result);

            Console.WriteLine("Press any key.......");
            Console.ReadKey();
        }

        public static bool CheckSum(int input1, int input2)
        {
            bool isSame = (input1 == 30 || input2 == 30);
            bool isSum = ((input1 + input2) == 30);

            if (isSame || isSum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}