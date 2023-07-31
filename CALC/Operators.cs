using System;
using System.Collections.Generic;
using System.Text;

namespace CALC
{
    class Operators
    {
        public static int subtract (int x,int y)
        {
            int number1 = x;
            int number2 = y;
            int sum = number1 - number2;
            return sum;
                
        }
        public static int Add(int x, int y)
        {
            int number1 = x;
            int number2 = y;
            int sum = number1 + number2;
            return sum;

        }
        public static int devide(int x, int y)
        {
            int number1 = x;
            int number2 = y;
            int sum = number1 / number2;
            return sum;

        }

        public static int times(int x, int y)
        {
            int number1 = x;
            int number2 = y;
            int sum = number1* number2;
            return sum;

        }

    }
}
