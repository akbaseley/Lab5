using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anna_Baseley_Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool UserContinue = true;
            Console.WriteLine("Welcome to the Factorial Calculator!");

            while (UserContinue)
            {

                int UserNumber = GetNumber("Please enter a number between 1 and 10!", 1, 10);

                GetFactorial(UserNumber);

                UserContinue = Continue("Would you like to go again? y/n");

                if (UserContinue == false)
                {
                    Console.WriteLine("Okay!  See you next time.");
                }   
            }
        }
        public static int GetNumber(string message, int start, int end)
        {
            int userNumber;
            Console.WriteLine(message);
            while (!int.TryParse(Console.ReadLine(), out userNumber)) ;

            while(userNumber < start || userNumber > end)
            {
                Console.WriteLine(message);
                while (!int.TryParse(Console.ReadLine(), out userNumber)) ;
            }

            return userNumber;
        }
        public static void GetFactorial(int UserNumber)
        {
            int Factorial = UserNumber;
            for (int i = UserNumber-1; i >= 1; i--)
            {
                Factorial = Factorial * i;
            }

            Console.WriteLine($"The Factorial of {UserNumber} is {Factorial}");
        }
        public static bool Continue(string message)
        {
            bool UserContinue;
            Console.WriteLine(message);
            string UserChoice = Console.ReadLine();
            while(UserChoice != "y" && UserChoice != "n")
            {
                Console.WriteLine("I'm sorry! I didn't quite get that.  Would you like to continue? y/n");
                UserChoice = Console.ReadLine();
            }
            if(UserChoice == "y")
            {
                UserContinue = true;
            }
            else
            {
                UserContinue = false;
            }
            return UserContinue;
        }
    }
}
