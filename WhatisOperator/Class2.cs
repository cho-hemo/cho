using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace WhatisOperator
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            /**
             * 순차문 : 순차 구조. Main() 메서드 시작 지점부터 끝 지점까지 코드가 나열되면 순서대로 실행 후 종료.
             * 제어문 : 프로그램 실행 순서를 제어, 내용을 반복하는 작업 등을 처리할 때 사용하는 구문. 조건문과 반복문.
             * 조건문 : 선택 구조. 조건의 참, 거짓에 따라 서로 다른 명령문을 실행할 수 있는 구조. (=분기문,비교판단문)
             * 반복문 : 반복 구조. 특정 명령문을 지정된 수만큼 반복해서 실행할 때나 조건식이 참일 동안 반복.
             * 
             * if / else 문
             * 프로그램 흐름을 여러갈래로 가지치기(Branching) 할 때 사용.
             * 조건을 비교해서 판단하는 구문으로 if, else if, else 세가지 키워드 사용.
             * 
             */

            // 두개의 정수 중 더 큰 수를 찾는 프로그램
            /*int numX,numY;
            Console.Write("X값을 입력하세요. -> ");
            int.TryParse(Console.ReadLine(), out numX);
            Console.Write("Y값을 입력하세요. -> ");
            int.TryParse(Console.ReadLine(), out numY);

            if (numX < numY)
            {
                Console.WriteLine("Y가 X보다 큽니다.");
            }
            else
            {
                Console.WriteLine("X가 Y보다 크거나 같습니다.");
            }
            Console.WriteLine();*/

            // 컵의 사이즈를 받아서 100ml 미만은 small, 100ml이상 200ml 미만은 medium, 200ml 이상은
            // large라고 출력하는 if-else문을 작성
            /*
            int sizeCup;
            Console.Write("컵 사이즈를 입력하세요. -> ");
            int.TryParse(Console.ReadLine(), out sizeCup);

            if(sizeCup < 100 && sizeCup > 0)
            {
                Console.WriteLine($"컵의 용량은 {sizeCup}ml이며 small입니다.");
            }
            else if(sizeCup >= 100 && sizeCup < 200)
            {
                Console.WriteLine($"컵의 용량은 {sizeCup}ml이며 medium입니다.");
            }
            else if (sizeCup > 200)
            {
                Console.WriteLine($"컵의 용량은 {sizeCup}ml이며 large입니다.");
            }
            else
            {
                Console.WriteLine($"컵이라고 부를 수 없습니다.");
            }*/

            // 비밀 코드 맞추기
            // 비밀 코드는 A부터 Z사이의 문자
            // 사용자는 컴퓨터에게 코드를 추측하고 컴퓨터는 정답 혹은 힌트를 준다.

            const char com = 'G';
            int comCode = Convert.ToInt32(com);
            Console.Write("비밀 코드를 입력하세요. -> ");

            char secret = Convert.ToChar(Console.ReadLine());
            int code = Convert.ToInt32(secret);

            

            for (int i = 2; i != 1; i++)
            {
                code = Convert.ToInt32(secret);
                if (code >= 65 && code <= 90)
                {

                }
                else if (code >= 97 && code <= 122)
                {
                    code = code - 32;
                }
                else
                {
                    Console.Write("비밀 코드를 제대로 입력하세요. -> ");
                    secret = Convert.ToChar(Console.ReadLine());
                }
                if (code == comCode)
                {
                    Console.WriteLine($"{secret}은(는) 정답입니다.");
                    break;
                }
                else if(code >= 65 && code <= 90)
                {
                    if (code < comCode)
                    {
                        Console.WriteLine($"{secret}은(는) 비밀 코드보다 앞에 있습니다.");
                    }
                    else
                    {
                        Console.WriteLine($"{secret}은(는) 비밀 코드보다 뒤에 있습니다.");
                    }
                    Console.Write("비밀 코드를 다시 입력하세요. -> ");
                    secret = Convert.ToChar(Console.ReadLine());
                }
            }

            // 세 개의 정수 중에서 큰 수 찾기
            // 사용자로부터 받은 3개의 정수 중에서 가장 큰 수를 찾는 프로그램 작성.
            // 3개의 정수를 한 번에 입력받아 가장 큰 수를 출력
            int num1,num2,num3;
            char delimiterChars = ' ';
            Console.Write("3개의 정수를 입력하세요. -> ");
            string three = Console.ReadLine();
            string[] threeNumber = three.Split(delimiterChars);

            for (int z = 1; z > 0; z++)
            {

                if (threeNumber.Length == 3)
                {
                    int.TryParse(threeNumber[0], out num1);
                    int.TryParse(threeNumber[1], out num2);
                    int.TryParse(threeNumber[2], out num3);

                    if (num1 > num2 && num1 > num3)
                    {
                        Console.WriteLine($"가장 큰 수는 {num1}입니다.");
                        break;
                    }
                    else if (num2 > num1 && num2 > num3)
                    {
                        Console.WriteLine($"가장 큰 수는 {num2}입니다.");
                        break;
                    }
                    else if (num3 > num1 && num3 > num2)
                    {
                        Console.WriteLine($"가장 큰 수는 {num3}입니다.");
                        break;
                    }
                    else if (num1 == num2 && num1 > num3) 
                    {
                        Console.WriteLine($"가장 큰 수는 {num1}입니다.");
                        break;
                    }
                    else if (num1==num3 && num1 > num2)
                    {
                        Console.WriteLine($"가장 큰 수는 {num1}입니다.");
                        break;
                    }
                    else if (num2==num3&& num2 > num1)
                    {
                        Console.WriteLine($"가장 큰 수는 {num2}입니다.");
                        break;
                    }
                    else if (num1 == num2 && num2 == num3)
                    {
                        Console.WriteLine($"가장 큰 수는 {num1}입니다.");
                        break;
                    }
                    else
                    {
                        Console.Write("3개의 정수를 제대로 입력하세요. -> ");
                        three = Console.ReadLine();
                        threeNumber = three.Split(delimiterChars);
                    }

                }
                else
                {
                    Console.Write("3개의 정수를 제대로 입력하세요. -> ");
                    three = Console.ReadLine();
                    threeNumber = three.Split(delimiterChars);
                }


            }


        }
    }
}
