using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsFunction
{
    internal class ex1
    {
        public static int SumNum(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int BigNum(int num1, int num2)
        {
            if (num1 <= num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }
        public static int SmallNum(int num1, int num2)
        {
            if (num1 >= num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }
        public static int PlusNum(int num)
        {
            if (num < 0)
            {
                return -num;
            }
            else
                return num;
        }


    }
}
