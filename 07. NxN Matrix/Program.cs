namespace _07._NxN_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int digit = int.Parse(Console.ReadLine());
            PrintMatrix(digit);
        }
        static void PrintMatrix(int digit)
        {
            for (int i = 1; i <= digit; i++)
            {
                Console.WriteLine();
                for(int j = 1; j <= digit; j++)
                    Console.Write(digit + " ");
            }
        }
    }
}
