using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMasterclass.ClassAndObjects
{
    internal class Constructor
    {
        static void Main(string[] args)
        {
            HumanCons denis = new HumanCons(29, "Denis", "Panjuta", "green");
            HumanCons frank = new HumanCons(35, "Frank", "TheTank", "awesome");
            denis.IntroduceOnceself();
            frank.IntroduceOnceself();
            Console.Read();
        }
       
    }

    public class HumanCons
    {
        // why private? https://softwareengineering.stackexchange.com/questions/143736/why-do-we-need-private-variables
        private int age;
        private string firstName;
        private string lastName;
        private string eyeColor;
        private bool isHuman = true;

        public HumanCons(int theAge, string firstName, string lastName, string eyeColor)
        {
            age = theAge;
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
        }


        public void IntroduceOnceself()
        {
            Console.WriteLine("My name is {0} {1}, and my eye color is {2}", firstName, lastName, eyeColor);

        }


    }
}
