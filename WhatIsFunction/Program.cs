using System;

namespace WhatIsFunction
{
    internal class Program
    {
        // 이곳에 작성하는 변수가 전역 변수
        static int _number1 = 0;
        static int _number2 = 0;
        // 함수스코프 내에 변수가 있으면 그것을 우선으로 사용

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

            //Show();
            //Hi();
            //Hi();
            //Hi();
            //int num1 = 0;
            //int num2 = 0;
            //Console.Write("첫번째 숫자를 입력하세요. -> ");
            //int.TryParse(Console.ReadLine(), out num1);
            //Console.Write("두번째 숫자를 입력하세요. -> ");
            //int.TryParse(Console.ReadLine(), out num2);
            //Console.WriteLine($"두 수의 합 : {ex1.SumNum(num1, num2)}");
            //Console.WriteLine($"두 수 중 큰 값 : {ex1.BigNum(num1, num2)}");
            //Console.WriteLine($"두 수 중 작은 값 : {ex1.SmallNum(num1, num2)}");
            //Console.WriteLine($"첫번째 수의 절댓값 : {ex1.PlusNum(num1)}");
            //Console.WriteLine($"두번째 수의 절댓값 : {ex1.PlusNum(num2)}");

            //// 오버로드!
            //Multi();
            //Multi("대박임");
            //Multi("이열", 3);

            // 재귀 함수
            //Console.WriteLine($"{Factorial(5)}");

            //int number1 = 1;
            //int number2 = 4;

            //_221227class3.Swap(number1, number2);
            //// 값만 전송
            //Console.WriteLine($"메인의 넘버 값은? : {number1}, {number2}");

            //_221227class3.chocho();
            //_221227class3.Multiply(5, 6);

            //// 22.12.27 3교시 예제
            //int x = 15;
            //int y = 95;
            //int z = 42;
            //_221227class3.Maximum(x, y, z);
            //Console.WriteLine();
            //_221227class3.SayHello(3);
            //Console.WriteLine();
            //_221227class3.Hypot(3, 7);
            //Console.WriteLine();
            //_221227class3.Prime();
            //Console.WriteLine();
            //Console.WriteLine();
            //PhoneNum.PhoneNumFunction();

            // 문자열 거꾸로 출력하기

            Console.Write("제대로 입력한 문장 : ");
            string retxt = Console.ReadLine();
            _221227class3.ReverseText(retxt);


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

        static int Hi()
        {
            /**
             * 함수 생성 및 반복 사용
             * 함수를 만드는 목적 중 하나는 반복 사용에 있다.
             * 함수를 만들고 여러번 호출해서 사용하는 방법을 알아보자.
             */
            Console.WriteLine("앗뇽!");
            return 0;
        }

        static int Hi(string text)
        {
            Console.WriteLine(text);
            return 0;
        }

        static void ParameterAndReturn()
        {
            /**
             * 기능이 동일한 함수만 사용하지는 않음
             * 호출할 때마다 조금씩 다른 기능을 적용하고 싶을 때는
             * 함수의 매개변수를 달리하여 호출 가능
             * 매개변수(인자, 파라미터)는 함수에 어떤 정보를 넘겨주는 데이터를 나타낸다.
             * 매개변수는 콤마를 기준으로 여러개 설정 가능
             * 문자열과 숫자 등 모든 데이터 형식을 사용가능
             * 
             * 매개변수가 없는 함수 : +반환값도 없는 가장 단순한 형태
             *  모든 변수 값을 문자열로 변환시키는 Tostring() 메서드처럼 빈 괄호만 있는 함수 형식.
             * 매개변수가 있는 함수 : 특정 함수에 인자 값을 1개 이상 전달하는 방식.
             *  정수형, 실수형, 문자형, 문자열형, 개체형 등 여러가지 데이터 형식을 인자 값으로
             *  전달 가능
             * 반환값(리턴값)이 있는 함수 : 함수의 처리 결과를 함수를 호출한 쪽으로 반환.
             *  return 키워드를 사용하여 데이터를 돌려줄 수 있다.
             *  
             * 매개변수가 가변(여러 개)인 함수 : C#에서는 클래스 하나에 매개변수의 형식과 개수를
             *  달리하여 이름이 동일한 함수를 여러개 만들 수 있다.(=함수 중복=함수 오버로드(Overload)) 
             */
        }

        static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

        static string GetString()
        {
            return "반환값(Return Value)";
        }

        static int SquareFunction(int x)
        {
            int r = x * x;
            return r;
        }

        /**
         * 함수 오버로드 : 다중 정의
         * 클래스 하나에 매개변수를 달리해서 이름이 동일한 함수 여러개를 정의
         * 우리말로 여러번 정의한다는 의미
         * 매개변수가 같으면 함수 타입이 다르더라도 못 찾는다.
         */

        //! 숫자를 받아서 출력하는 함수
        /**
         * @param number int type number for print
         * ㄴ오버로드 설명
         */
        static void GetNuber(int n)
        {
            Console.WriteLine($"Int32 : {n}");
            Console.WriteLine($"4바이트 정수 : {n}");
        }
        //! 숫자를 받아서 출력하는 함수
        /**
         * @param number long type number for print
         */
        static void GetNuber(long n)
        {
            Console.WriteLine($"Int64 : {n}");
            Console.WriteLine($"8바이트 정수 : {n}");
        }
        static void Multi()
        {
            Console.WriteLine("안냥!");
        }
        static void Multi(string message)
        {
            Console.WriteLine(message);
        }

        static void Multi(string message, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(message);
            }
        }

        static void Recursionfunction()
        {
            /**
             * 재귀 함수
             * 재귀(Recursion)(= 재귀 함수) : 함수에서 함수 자신을 호출하는 것
             */
            //Recursionfunction();
        }

        static int Factorial(int n)
        {
            // 여기서 탈출!
            if(n == 0||n==1)
            {
                Console.WriteLine($"n의 값은 {n}");
                return 1;
            }
            Console.WriteLine($"n의 값은 {n}");
            return n * Factorial(n-1);      // 재귀 호출
            // 함수는 호출로 부담이기에 재귀 함수는 자주 쓰이지 않는다. 계속 호출!
        }

    }       // class
}