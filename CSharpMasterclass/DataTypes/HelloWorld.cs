using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMasterclass.DataTypes
{
    internal class HelloWorld
    {
        static void Main(string[] args)
        {
            /* Variables and Datatypes*/
            int num1 = 13;
            int num2 = 5;
            int sum = num1 + num2;

            double d1 = 3.5;
            double d2 = 1.337;
            double sumD = d1 / d2;

            Console.WriteLine("The sum of " + num1 + " and " + num2 + " is " + sum);
            Console.WriteLine(d1 + " devided by " + num2 + " is " + sumD);
            Console.Read();

            /*Strings*/
            string myname = "Denis";

            string message = "My name is " + myname;

            string capsMessage = message.ToUpper();

            string lowerCaseMessage = message.ToLower();

            Console.WriteLine(capsMessage);
            Console.WriteLine(lowerCaseMessage);
            Console.Read();

            // impicit conversion
            int num = 12390532;
            long bigNum = num;

            float myFloat = 13.37F;
            double myNewDouble = myFloat;

            double myDouble = 13.37;
            int myInt;
            // explicit conversion
            // cast double to int;
            myInt = (int)myDouble;

            // typeConversion 
            string myString = myDouble.ToString(); // "13.37"
            string myFloatString = myFloat.ToString();
            bool sunIsShining = false;

            string myBoolString = sunIsShining.ToString();

            Console.WriteLine(myBoolString);
            Console.Read();

            //Parsing
            string myString1 = "15";
            string mySecondString = "13";
            int num11 = Int32.Parse(myString1);
            int num21 = Int32.Parse(mySecondString);
            int resultInt = num11 + num21;
            string result = myString + mySecondString;

            Console.WriteLine(resultInt);
            Console.Read();

            //DataTypes examples
            byte myByte = 25;
            Console.WriteLine(myByte);
            sbyte mySbyte = -15;
            Console.WriteLine(mySbyte);
            int myInttest = -12318925;
            Console.WriteLine(myInttest);
            uint myUint = 123091;
            Console.WriteLine(myUint);
            short myShort = -32768;
            Console.WriteLine(myShort);
            ushort myUShort = 65535;
            Console.WriteLine(myUShort);
            float myFloattest = -31.1289f;
            Console.WriteLine(myFloattest);
            double myDoubletest = -12.1231250;
            Console.WriteLine(myDoubletest);
            char myCharacter = 'A';
            Console.WriteLine(myCharacter);
            bool myBool = true;
            Console.WriteLine(myBool);
            string myText = "I control text";
            Console.WriteLine(myText);
            string numText = "15";

            int myNumFromText = int.Parse(numText);
            Console.WriteLine(myNumFromText);
            Console.ReadLine();

            //Constants
            // constants as fields
            const double PI = 3.14159265359;
            const int weeks = 52, months = 12;
            // Create a constant of type string with your birthday as its value
            const string birthday = "31.05.1988";
            const string birthday2 = "05.31.1988";
            const string birthday3 = "2018-05-31";

        }
    }
}
