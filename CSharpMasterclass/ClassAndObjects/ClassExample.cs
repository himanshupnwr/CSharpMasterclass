using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMasterclass.ClassAndObjects
{
    internal class ClassExample
    {
        static void Main(string[] args)
        {
            Human sissy = new Human("Sissy", "Wagner");
            sissy.IntroduceMyself();


            Console.ReadKey();
        }
    }
    class Human
    {
        // member variable
        public string firstName;
        public string lastName;

        // constructor
        public Human(string myFirstName, string lastName)
        {
            firstName = myFirstName;
            this.lastName = lastName;

        }


        // member method
        public void IntroduceMyself()
        {
            Console.WriteLine("Hi, I'm {0} {1}", firstName, lastName);
        }
    }
}
