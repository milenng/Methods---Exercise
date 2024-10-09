using System;

namespace _03.CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char char1 = char.Parse(Console.ReadLine());
            char char2 = char.Parse(Console.ReadLine());
            if (char1 > char2) { char temp = char1; char1 = char2; char2 = temp; }
            PrintCharactersInRange(char1, char2);
        }
        static void PrintCharactersInRange(char char1, char char2)
        {
            for (int i = (int)char1 + 1; i < (int)char2; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
