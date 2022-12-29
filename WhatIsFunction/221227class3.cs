using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsFunction
{
    internal class _221227class3
    {
        // 이곳에 작성하는 변수가 전역 변수
        
        static void FunctionScope()
        {

            /**
             * 함수 범위 : 전역 변수와 지역 변수
             * 전역 변수(Global Variable)(=필드(Field)) : 클래스와 같은 레벨에서 선언된 변수
             * 지역 변수(Local Variable) : 함수 레벨에서 선언된 변수
             * 동일한 이름으로 변수를 전역 변수와 함수 내의 지역 변수로 선언 가능
             * 함수 내에서는 함수 범위에 있는 지역 변수를 사용하나,
             * 함수 범위 내에 선언된 변수가 없으면 전역 변수 내에 선언된 변수 사용
             * 단, C#에서는 필드라는 단어를 주로 사용.
             * 전역 변수는 언더스코어(_) 또는 m_접두사를 붙이는 경향이 있다.
             */

        }   // FunctionScope()


        public static void Swap(int intValue1, int intValue2)
        {
            Console.WriteLine($"바뀌기 전 : {intValue1} , {intValue2}");
            
            int temp;
            temp = intValue1;
            intValue1 = intValue2;
            intValue2 = temp;

            Console.WriteLine($"바뀐 후 : {intValue1} , {intValue2}");
        }

        static void ArrowFunction()
        {
            /**
             * 화살표 함수(Arrow Function)
             * 화살표 모양의 연산자인 화살표 연산자(=>)를 사용하여 메서드 코드를 줄일 수 있다.
             * 프로그래밍에서 화살표 함수(=화살표 메서드)는 람다 식(Lambda Expression)의 또다른 이름.
             * 화살표 함수를 사용하면 함수를 줄여서 표현 가능.
             * 처음에는 어색해도 익숙해지면 차후에는 코드의 간결함 유지 가능.
             */
        }

        // 람다 식(화살표 함수, 화살표 연산자)
        public static void chocho() => Console.WriteLine("초초초초초초초");
        public static void Multiply(int a, int b) => Console.WriteLine(a + b);


        // 22.12.27 3교시 예제
        /**
         * 3개 정수 중에서 최대 값을 찾는 함수 Maximum(x,y,z)를 정의
         * 
         * 화면에 "안녕!!!!!!!!!!"을 출력하는 SayHello() 함수를 작성.
         *      - int 타입 매개변수를 받아 그 횟수만큼 반복 출력
         * 
         * 다른 두 변이 주어졌을 때, 직각 삼각형의 빗변을 계산하는 함수 Hypot()를 정의
         *      - 매개변수 2개 타입은 doudle 형
         *      - 리턴 타입 double 형
         *      
         * 주어진 숫자가 소수인지 여부를 찾는 함수 Prime()을 작성
         *      - 판별할 값의 범위는 2~100 사이의 값에서 소수 모두 출력
         *      
         * 사용자가 입력하는 전화번호에서 소괄호를 삭제한 형태로 출력하는 프로그램 작성(함수 사용)
         *      - 전화번호를 입력 받는다. -> 소괄호 삭체한 형태로 출력.
         *      - quit 입력하면 프로그램 종료
         *      - 프로그램 종료 전까지 전화번호 입력받기
         */

        public static void Maximum(int x, int y, int z)
        {
            if (x >= y && x >= z)
            {
                Console.WriteLine($"{x}, {y}, {z} 중 가장 큰 값은 {x}입니다.");
            }
            else if(y >= x && y >= z)
            {
                Console.WriteLine($"{x}, {y}, {z} 중 가장 큰 값은 {y}입니다.");
            }
            else
            {
                Console.WriteLine($"{x}, {y}, {z} 중 가장 큰 값은 {z}입니다.");
            }
        }
        public static void SayHello(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("안녕!!!!!!!!!!");
            }

            Console.WriteLine($"총 반복 횟수는 {count}야!");
        }
        public static void Hypot(double x, double y)
        {
            Console.WriteLine($"직각 삼각형의 양 변이 각각 {x}이고 {y}일 때");
            double hypot = Math.Sqrt(x * x + y * y);
            Console.WriteLine($"빗변의 길이는 {hypot}이다.");
        }
        public static void Prime()
        {
            int check = 0;
            Console.WriteLine("2~100까지 중 소수만 출력 : ");
            for (int i = 2; i <= 100; i++)
            {
                check = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i%j == 0)
                    {
                        check++;
                    }
                }
                if(check == 2)
                {
                    Console.Write($"{i} ");
                }
            }
        }
        public static void ReverseText(string text)
        {
            char[] reverseTxt = new char[text.Length];
            int count = 0;
            foreach(char one in text)
            {
                reverseTxt[count] = one;
                count++;
            }
            Console.Write("반대로 출력한 문장 : ");
            for (int i = count-1; i >= 0; i--)
            {
                Console.Write($"{reverseTxt[i]}");
            }
            Console.WriteLine();
        }
    }
}
