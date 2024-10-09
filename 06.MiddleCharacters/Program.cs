namespace _06.MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            PrintMiddleCaracters(input);
        }
        static void PrintMiddleCaracters(string input)
        {
            int middleCharacter = input.Length;
            if (input.Length % 2 != 0) 
            {
                
                Console.WriteLine($"{input[(middleCharacter- 1)/2]}");
            }
            else 
            {
                Console.WriteLine($"{input[(middleCharacter - 2) / 2]}{input[middleCharacter/2]}");
            }
        }
    }
}
