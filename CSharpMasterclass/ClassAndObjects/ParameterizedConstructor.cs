using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMasterclass.ClassAndObjects
{
    internal class ParameterizedConstructor
    {
        static void Main(string[] args)
        {
            Human denis = new Human("Denis", "Panjuta", "green", 29);
            denis.IntroduceMyself();

            Human amalia = new Human("Amalia", "Panjuta", "blue");
            amalia.IntroduceMyself();

            Human basicHuman = new Human();
            basicHuman.IntroduceMyself();

            Human natalie = new Human("Natalie");
            natalie.IntroduceMyself();

            Human michael = new Human("Michael", "Miller");
            michael.IntroduceMyself();

            Human frank = new Human("Frank", "Walter", 25);
            frank.IntroduceMyself();

            Console.ReadKey();
        }

        class Human
        {
            // member variable
            private string firstName;
            private string lastName;
            private string eyeColor;
            private int age;

            // default constructor
            public Human()
            {
                Console.WriteLine("Constructor called. Object created");
            }

            public Human(string firstName)
            {
                this.firstName = firstName;
            }

            public Human(string firstName, string lastName)
            {
                this.firstName = firstName;
                this.lastName = lastName;
            }

            public Human(string firstName, string lastName, string eyeColor)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.eyeColor = eyeColor;
            }

            public Human(string firstName, string lastName, int age)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.age = age;
            }

            // parameterized constructor
            public Human(string firstName, string lastName, string eyeColor, int age)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.eyeColor = eyeColor;
                this.age = age;
            }



            // member method
            public void IntroduceMyself()
            {
                if (age != 0 && lastName != null && eyeColor != null && firstName != null)
                    Console.WriteLine("Hi, I'm {0} {1} and {2} years old. My eye color is {3}", firstName, lastName, age, eyeColor);
                else if (age != 0 && lastName != null && firstName != null)
                {
                    Console.WriteLine("Hi, I'm {0} {1} and {2} years old.", firstName, lastName, age);
                }
                else if (lastName != null && firstName != null)
                {
                    Console.WriteLine("Hi, I'm {0} {1}.", firstName, lastName);
                }
                else if (firstName != null)
                {
                    Console.WriteLine("Hi, I'm {0} ", firstName);
                }

            }
        }
    }
}
