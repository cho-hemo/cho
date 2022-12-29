using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsFunction
{
    internal class PhoneNum
    {
        static string phoneNumber = "";
        public static void PhoneNumFunction()
        {
            /** 사용자가 입력하는 전화번호에서 소괄호를 삭제한 형태로 출력하는 프로그램 작성(함수 사용)
             *      - 전화번호를 입력 받는다. -> 소괄호 삭제한 형태로 출력.
             *      - quit 입력하면 프로그램 종료
             *      - 프로그램 종료 전까지 전화번호 입력받기
             */

            ReadNum();
            while (phoneNumber != "quit")
            {
                Console.Write("전화번호는 ");
                foreach (char Num in phoneNumber)
                {
                    if (Num == '(')
                    {
                        /* Do Nothing */
                    }
                    else if(Num == ')')
                    {
                        Console.Write("-");
                    }
                    else
                    {
                        Console.Write(Num);
                    }
                }
                Console.Write("입니다. \n\n");
                ReadNum();
            }
        }

        static void ReadNum()
        {
            Console.Write("전화번호를 입력해주세요. - > ");
            phoneNumber = Console.ReadLine();
        }

    }
}
