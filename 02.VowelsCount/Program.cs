namespace _02.VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            PrintVowelsCount(input);
        }
        static void PrintVowelsCount(string input)
        {
            int counter = 0;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (input[i] == vowels[j]) { counter++; }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
