using System;
using System.Linq;

namespace CALC
{
    class Program
    {
        static void Main(string[] args)
        {
            string restart__operators  = "no";
            string[] operator_array = new string[4] { "+", "-", "*", "/" };
            int number1;
            int number2;

            do
            {
                //frist run and the loop

                Console.WriteLine("from your right please select the sign/operator of your choise: (/ or * or + or -)");
                string calculation = Console.ReadLine();

                //exeption for invalid operator

                while (!operator_array.Contains(calculation))
                {
                    Console.WriteLine("that is not a valid operator...");
                   calculation = Console.ReadLine();
                }

                Console.WriteLine("enter your first number: ");
                string input = Console.ReadLine();

                //expetsion for users number of option

                while (int.TryParse(input, out int n) == false)
                {
                    Console.WriteLine("pleae enter an actual number: ");
                    input = Console.ReadLine();

                }

                number1 = Int32.Parse(input);

                Console.WriteLine("enter your second number of your choise:  ");
                input = Console.ReadLine();

                //exeptiin for second number

                while (int.TryParse(input, out int n) == false)
                {
                    Console.WriteLine("pleae enter an actual number: ");
                    input = Console.ReadLine();

                }
                number2 = Int32.Parse(input);


                if (calculation == "+")
                {
                    Console.WriteLine("your answer is : " + Operators.Add(number1, number2));
                    Console.WriteLine("please type yes to make another calculation");
                    restart__operators = Console.ReadLine();
                }

                else if (calculation == "-")
                {
                    Console.WriteLine("your answer is : " + Operators.subtract(number1, number2));
                    Console.WriteLine("please type yes to make another calculation");
                    restart__operators = Console.ReadLine();

                }

                else if (calculation == "*")
                {
                    Console.WriteLine("your answer is : " + Operators.times(number1, number2));
                    Console.WriteLine("please type yes to make another calculation");
                    restart__operators = Console.ReadLine();

                }

                else if (calculation == "-")
                {
                    Console.WriteLine("your answer is : " + Operators.devide(number1, number2));
                    Console.WriteLine("please type yes to make another calculation");
                    restart__operators = Console.ReadLine();
                 

                }
                else if (number1 < number2)
                {
                    Console.WriteLine("your second number should not be grater than your forst number pleasetry again");

                }
              

                else
                {
                    Console.WriteLine("error not known");

                }





            }

            while (restart__operators == "yes");
            System.Environment.Exit(0);
        }
    }
}
