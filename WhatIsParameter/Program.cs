using System;

namespace WhatIsParameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ParameterDesc parameterDesc = new ParameterDesc();
            int num1 = 10;
            int num2 = 20;

            //parameterDesc.ValueTypeParam(num1,num2);

            //Console.WriteLine($"메인첫번째 : {num1} 메인두번째 : {num2}");

            //parameterDesc.RefTypeParam(ref num1, ref num2);

            //Console.WriteLine($"메인첫번째 : {num1} 메인두번째 : {num2}");

            //parameterDesc.OutTypeParam(out num1, out num2);

            //Console.WriteLine($"메인첫번째 : {num1} 메인두번째 : {num2}");

            parameterDesc.FlexibleTypeParam(1, 2, 3, 4, 9, 10, 85, 45);
        }
    }
}