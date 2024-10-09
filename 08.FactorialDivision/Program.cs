namespace _08.FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
                        
            long factorial1 =Factorial(long.Parse(Console.ReadLine()));
            long factorial2 = Factorial(long.Parse(Console.ReadLine()));
            Console.WriteLine($"{(double)factorial1/factorial2:f2}");
        }

        private static long Factorial(long number)
        {
            long rezult = 1;
            for (int i = 1; i <= number; i++)
            {
                rezult *= i;
            }
            return rezult;
        }
    }
}
