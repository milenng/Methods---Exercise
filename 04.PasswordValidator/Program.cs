
namespace _04.PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool rule1IsTrue = Rule1(password);
            bool rule2IsTrue = Rule2(password);
            bool rule3IsTrue = Rule3(password);
            if (rule1IsTrue == true && rule2IsTrue == true && rule3IsTrue == true)
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                if (rule1IsTrue == false)
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }
                if (rule2IsTrue == false)
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }
                if (rule3IsTrue == false)
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }
            static bool Rule1(string password)
            {
                if (password.Length >= 6 && password.Length <= 10) { return true; }
                else { return false; }
            }

            static bool Rule2(string password)
            {
                bool isTrueRule2 = true;
                for (int i = 0; i < password.Length; i++)
                {
                    bool isTrueLoop = true;
                    if (((int)password[i] >= 48 && (int)password[i] <= 57)
                        || ((int)password[i] >= 65 && (int)password[i] <= 90)
                        || ((int)password[i] >= 97 && (int)password[i] <= 122))
                    {
                        isTrueLoop = true;
                    }
                    else { isTrueLoop = false; }
                    isTrueRule2 &= isTrueLoop;
                }
                return isTrueRule2;

            }

            static bool Rule3(string password)
            {
                bool isTrueRule3 = false;
                int counter = 0;
                for (int i = 0; i < password.Length; i++)
                {

                    if ((int)password[i] >= 48 && (int)password[i] <= 57)
                    {
                        counter++;
                    }
                }
                if (counter >= 2) { isTrueRule3 = true; }
                return isTrueRule3;

            }
        }
    }
}
