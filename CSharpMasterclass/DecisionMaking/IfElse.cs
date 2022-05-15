using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMasterclass.DescisionMaking
{
    internal class IfElse
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's the temperature like?");
            string temperature = Console.ReadLine();
            int numTemp = int.Parse(temperature);

            if (numTemp < 20)
            {
                Console.WriteLine("Take the coat");
            }

            if (numTemp == 20)
            {
                Console.WriteLine("Pants and Pull Over should be fine");
            }

            if (numTemp > 20)
            {
                Console.WriteLine("Shorts are enough today");
            }

            Console.Read();

            Register();
            Login();
            Console.Read();
        }

        public static void Register()
        {
            Console.WriteLine("Please enter your username");
            username = Console.ReadLine();
            Console.WriteLine("Please enter your password");
            password = Console.ReadLine();
            Console.WriteLine("Registration completed");
            Console.WriteLine("-------------------------------------------");
        }

        public static void Login()
        {
            Console.WriteLine("Please enter your username");
            if (username == Console.ReadLine())
            {
                Console.WriteLine("Please enter your password");
                if (password == Console.ReadLine())
                {
                    Console.WriteLine("Login successful");
                }
                else
                {
                    Console.WriteLine("Login failed, wrong password. Restart Program");
                }
            }
            else
            {
                Console.WriteLine("Login failed, wrong username. Restart Program");
            }
        }
    }
}
