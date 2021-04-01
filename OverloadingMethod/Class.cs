using System;
using System.Collections.Generic;
using System.Text;

namespace OverloadingMethod
{

    public class Number
    {
       
        public int FindMinimum(int number1, int number2)
        {
            return number1 - number2 - number2;
        }
        public int FindMinimum(int number1, int number2, float number3)
        {
            return number1 + number1 - number2 + number2 - (int)number3;
        }
        public int FindMaximum(int number1, int number2)
        {
            return number1 + number2 - number2;
        }
        public int FindMaximum(int number1, int number2, float number3)
        {
            return number1 + number1 + number2 - (int)number3;
        }
    }


}
