using System;

namespace WhatIsFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string[,] starArray = new string[5, 5];
            // // 별찍기 직각 삼각형

            // for (int i = 0; i < 5; i++)
            // {
            //     for (int j = 0; j < 5; j++)
            //     {
            //         starArray[j, i] = "* ";
            //     }

            // }// 별을 배열에 초기화 하는 루프

            // // 별 출력 코드

            // for (int i = 0; i < 5; i++)
            // {
            //     for (int j = i; j >= 0; j--)
            //     {
            //         if (starArray[j, i].Equals("* "))
            //         {
            //             Console.Write($"{starArray[j, i]}");
            //         }
            //     }
            //     Console.WriteLine();
            // } // loop 배열에 담긴 별을 출력하는 루프

            //Console.WriteLine();

            /**
             * 22.12.26 오후 수업
             * 함수(Function) 또는 메서드(Method)
             * 재사용을 목적으로 만든 특정 작업을 수행하는 코드 블록
             * 함수
             * 메서드
             * 프로시저(Procedure)
             * 서브루틴(Subroutine)
             * 서브모듈(Submodule)
             * 
             * 같은 유형의 코드를 반복할 때 사용.
             * 사용 목적: 코드 재사용
             * 한 번 만들어 놓은 함수는 프로그램에서 한 번 이상 사용할 수 있다.
             * 지금까지 사용한 Main() 메서드는 C#의 시작 지점을 나타내는 특수 목적 함수.
             * 또, Console 클래스의 WriteLine() 메서드도 함수로 볼 수 있음.
             * 
             * - 함수란 어떤 값을 받아 그 값을 가지고 가공을 거쳐 어떤 결과 값을 반환시켜 주는 코드.
             * - 함수는 프로그램 코드 내에서 특정한 기능을 처리하는 독립적인 하나의 단위 또는 모듈.
             * 
             * 입력 -> 처리 -> 출력
             * 
             * 함수의 종류(내장 함수와 사용자 정의 함수)
             * 내장 함수(=API(Application Programming Interface)): C#이 자주 사용하는 기능을 미리 만들어 제공하는 함수, 특정 클래스의 함수로 표현.
             * 내장 함수도 그 용도에 따라 문자열 관련 함수, 날짜 및 시간 관련 함수,
             * 수학 관련 함수, 형식 변환 관련 함수 등으로 나눌 수 있다.
             * 사용자 정의 함수 : 사용자가 필요할 때마다 새롭게 기능을 추가하여 사용하는 함수
             * 
             * 함수 정의하고 사용하기
             * 함수 정의(Define)는 함수를 만드는 작업.
             * 함수 호출(Call)은 함수를 사용하는 작업.
             * 함수 생성 및 호출은 반드시 소괄호가 들어간다.
             * 함수 정의 형태는 지금까지 사용한 Main() 메서드와 유사함.
             * 
             * 함수의 가장 기본적인 형태
             * static void [함수이름]()
             * {
             *      함수내용
             * }
             * 
             * 함수를 호출하는 형태 3가지
             * [함수이름]();
             * [함수이름](매개변수);
             * 변수(결과값) = [함수이름](매개변수);
             */

            Show();

        }   // Main()

        // 초초월드! 출력하는 사용자 정의 함수
        static void Show()
        {
            Console.WriteLine("초초월드!");
            /**
             * 가장 간단한 형태의 함수.
             * 매개변수(Parameter)도 없고 반환값(Return value)도 없는 형태.
             */
        }

    }       // class
}