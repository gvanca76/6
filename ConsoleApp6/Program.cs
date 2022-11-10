using System;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main()
        {

            //Console.WriteLine("gvanca eliauri");
            //Console.BackgroundColor = ConsoleColor.Blue;
            //Console.WriteLine(Console.ReadLine());


            // Varibles


            int MyFirstInt = 5;
            Console.WriteLine(MyFirstInt);

            //string MyString = "random string";
            //string MyAnotherString = Console.ReadLine();
            //Console.WriteLine($"You Entered : {MyAnotherString}");

            double myDouble = 3.14;

            var thisIsInt = 5;
            var thisIsString = "Test";

            bool myFirstBool = true;
            bool mySecondBool = false;

            // Implicit

            byte valueOfLowerByte = 255;
            byte valueOfHigherByte = valueOfLowerByte;


            Console.WriteLine(valueOfLowerByte);
            Console.WriteLine(valueOfHigherByte);

            // Explicit
            int valueOfUpperNumber = 256;
            byte valueOfLowerByte2 =(byte) valueOfUpperNumber;

            Console.WriteLine(valueOfUpperNumber);
            Console.WriteLine(valueOfLowerByte2);

            //string x = Console.ReadLine();
            //int converted = Convert.ToInt32(x);


            Console.WriteLine(5+5);
            Console.WriteLine(10-5);
            Console.WriteLine(10*5);
            Console.WriteLine(10/5);
            Console.WriteLine(10%5);
            var z = 5;
            var y = 5;
            Console.WriteLine($"z : {z}");
            Console.WriteLine(z++);
            Console.WriteLine($" y : {y}");
            Console.WriteLine(y--);


            char FirstChar = 'A';
            char SecondChar = 'B';

            Console.WriteLine(FirstChar > SecondChar);

            Console.WriteLine("___________________");


            Level myLevel = Level.Medium;
            Console.WriteLine("your level is");
            Console.WriteLine(myLevel);

            if (myLevel == Level.Low)
            {
            Console.WriteLine( "Level is Low");
            }
            
            else if (myLevel == Level.Medium)
            {
                Console.WriteLine("Level is Medium");

            }

            Console.WriteLine("____________________________");
            //Logical Operations

           

            bool raining = false;

            if (raining)
            {
                Console.WriteLine("i am going to gym");
            }
            else
            {

                Console.WriteLine("i am not going");
            }

            Console.WriteLine("________ while loop ___________");

            var myNumber = 5;

            while (myNumber < 0)
            {
                Console.WriteLine("while");
                Console.WriteLine(myNumber);
                myNumber--;
            }

            do
            {
                Console.WriteLine("do while");
                myNumber--; 
               
            } while (myNumber < 0) ;


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }


            // amocana

            const decimal discountPersentage = 20;
            decimal total = 0;
            decimal amountToPay = 0;
            decimal result = 0;
            Console.WriteLine("enter price");
            var price = Convert.ToDecimal (Console.ReadLine());

            Console.WriteLine("enter length");
            var length = Convert.ToDecimal(Console.ReadLine());
            result = price * length;

            if (length > 100)
            {
               total = price * length;

               amountToPay = total - (total * discountPersentage / 100);
               result = amountToPay;
            }

            else
            {
                result = total;
            }
            
            Console.WriteLine($"you have to pay : {result}");








        }

        public enum Level
        {

            Low,
            Medium,
            High,
        }
    }
}