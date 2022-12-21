//System 이라는 어셈블리에서 기능 가져오기
using System;

// 내 프로그램 이름. 내가 정함.
namespace WhatisArray
{
    // C#에서는 모든 요소들이 클래스 안에 있어야함
    internal class Program
    {
        // C# 콘솔(검은 창) 사용시 메인 메소드가 무조건 1개는 있어야 함
        static void Main(string[] args)
        { // 프로그램은 여기서부터 읽기 시작함

            // 22.12.21 오전
            // 조건문 반복문 복습

            // 3의 배수를 제외한 수
            //int variable_ = 100;
            //bool isRealThree = (variable_ % 3 == 0);

            //Console.WriteLine($"{variable_} -> 3의 배수인가? : {isRealThree}");

            // 1~100숫자 중 3의 배수를 제외한 수의 합 구하기
            //int sumNum = 0;

            //for (int i = 0; i <= 100; i++)
            //{
            //    bool isRealThree = (i % 3 == 0);
            //    Console.WriteLine($"{i} -> 3의 배수인가? : {isRealThree}");
            //    if (isRealThree == false)
            //    {// 3의 배수가 아니다(false) 라면 이쪽이 실행
            //        sumNum += i;
            //        Console.WriteLine($"더해진 값 : {sumNum}");
            //    }// 실행 후 조건문 탈출
            //    Console.WriteLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("==============================");
            //Console.WriteLine($"1~100숫자 중 3의 배수를 제외한 수의 합 : {sumNum}");
            //Console.WriteLine("==============================");

            //string 어떤변수 = "남자";
            //if(/*여기서 조건문 검사*/ 어떤변수 == "남자") // 조건문 A
            //{ // 저 조건문이 참이면 내부 실행
            //    Console.WriteLine("너는 남자구나!");

            //}// 조건문이 여기서 끝남
            //else if (/*여기서 조건문 검사*/ 어떤변수 == "여자") // 조건문 B
            //{// 바로 위 조건문이 참이면 내부 실행
            //    Console.WriteLine("너는 여자구나!");
            //}// 조건문이 여기서 끝남
            //else
            //{ // 모든 조건문이 거짓(False)이면 여기부터 시작
            //    Console.WriteLine("너는 남자도 여자도 아니구나!");
            //} // 조건문이 여기서 끝남

            // 조건문을 실행했으면 다시 여기서부터 프로그램 시작.

            //for (int i = 0; i < 50; i++)
            //{
            //    Console.WriteLine();
            //}
            //Console.WriteLine("정말로 콘솔이 정리가 되었나?!");

            // if문의 조건 작성 연습하기
            // 양의 정수를 하나 입력 받아 그 수만큼 "Hello world!" 출력

            //int someNum = 100;
            //bool isPositiveInteger = (someNum > 0);

            //// 사용자로부터 계속 정수 입력받고 모든 정수를 더한다. 0이 나오면 모두 더한 값 출력 후 종료.
            //bool isNumZero = (someNum == 0);

            //// 프로그램 사용자로부터 입력 받은 숫자에 해당하는 구구단을 역순으로 출력
            //int userNum = 3;
            //for (int i = 9; 1 <= i; i--)
            //{
            //    Console.WriteLine($"{userNum} x {i} = {userNum*i}");
            //} // loop: 9번 도는 루프

            /**
             * 비밀 코드 맞추기
             * 컴퓨터가 숨기고 있는 비밀 코드를 추측하는 게임을 작성
             * 비밀 코드는 a~z 사이의 문자
             * 컴퓨터는 사용자의 추측을 읽고서 비밀 코드보다 앞인지 뒤인지 알려준다.
             * 정답을 맞추면 종료
             */
            //char secretCode = 'y';
            //char userAlpha = 'a';
            //bool isSmallAlphabet = ('a' <= userAlpha && userAlpha <= 'z');
            //// bool 값이 참이면 a에서 z 사이의 알파벳이다.

            //bool isAlphafront = userAlpha < secretCode;
            //bool isAlphaBack = userAlpha > secretCode;

            //if (isSmallAlphabet)
            //{
            //    // Do nothing //
            //}
            //else
            //{
            //    Console.WriteLine("알파벳 소문자만 입력해주세요.");
            //}

            //if(isAlphafront)
            //{
            //    Console.WriteLine("당신의 알파벳은 시크릿 코드보다 앞에 있습니다.");
            //}
            //else
            //{
            //    // Do nothing //
            //}
            //if (isAlphaBack)
            //{
            //    Console.WriteLine("당신의 알파벳은 시크릿 코드보다 뒤에 있습니다.");
            //}
            //else
            //{
            //    // Do nothing //
            //}

            // 1~100 숫자 중에서 3의 배수이면서 4의 배수인 정수의 합 구하기
            //int sumNum = 0;
            //int someNum = 100;
            //bool isThree = (someNum % 3 == 0);
            //bool isFour = (someNum % 4 == 0);

            //bool isOK = isThree && isFour;

            //if (isOK)
            //{
            //    sumNum += someNum;
            //}// if : 3의 배수이면서 4의 배수인 값

            // 반복문 복습

            // 별 100개 찍기
            //Console.WriteLine("{0} {1} {2} {3} {4}",
            //    "**********", "**********", "**********", "**********", "**********");
            //Console.WriteLine("{0} {1} {2} {3} {4}",
            //    "**********", "**********", "**********", "**********", "**********");

            //for (int i = 0; i < 100; i++)
            //{
            //    Console.Write("* ");
            //}

            //Console.WriteLine();
            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        Console.Write("* ");
            //    }// 밖의 루프가 1번 도는 동안 10번 도는 루프
            //    Console.WriteLine();
            //}// 10번 도는 루프

            //int hundredCount = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        for (int k = 0; k < 10; k++)
            //        {
            //            hundredCount++;
            //            if (hundredCount > 100)
            //            {
            //                break;
            //            }
            //            Console.Write("* ");
            //            if(hundredCount %10 == 0)
            //            {
            //                Console.WriteLine();
            //            }
            //        }// 1번 루프가 1번 도는동안 2번 루프가 10번 돌고 2번 루프가 1번 돌 때 3번 루프가 10번 돈다.
            //    }// 밖의 루프가 1번 도는 동안 10번 도는 루프
            //    Console.WriteLine();
            //}// 10번 도는 루프

            // 유저 입력을 받아 (1~20) 그만큼 *을 출력한다. 등차 수열로 한 단이 내려갈 때 마다 *이 하나 추가된다.

            int userNum = 0;
            Console.Write("몇 단을 출력할까요?");
            int.TryParse(Console.ReadLine(), out userNum);
            bool userNumArea = userNum > 0 && userNum <= 20;

            while(!userNumArea)
            {
                Console.Write("1~20 사이의 값을 입력해주세요. 몇 단을 출력할까요?");
                int.TryParse(Console.ReadLine(), out userNum);
                userNumArea = userNum > 0 && userNum <= 20;
            }
            for (int i = 0; i < userNum; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine();

            // 마름모 모양 출력

            int userNum2 = 0;
            Console.Write("몇 단을 출력할까요?");
            int.TryParse(Console.ReadLine(), out userNum2);
            bool userNumArea2 = userNum2 > 0 && userNum2 <= 20;

            while (!userNumArea2)
            {
                Console.Write("1~20 사이의 값을 입력해주세요. 몇 단을 출력할까요?");
                int.TryParse(Console.ReadLine(), out userNum2);
                userNumArea2 = userNum2 > 0 && userNum2 <= 20;
            }
            for (int i = 0; i < userNum2; i++)
            {
                if (i<userNum2/2)
                {
                    for (int k = userNum2/2-i; k > 0; k--)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write("* ");
                    }
                }
                else if(userNum2%2 !=0)
                {
                    for (int k = i - userNum2 / 2 - 1; k >= 0; k--)
                    {
                        Console.Write(" ");
                    }
                    for (int j = userNum2 / 2 + 1; j > i - userNum2 / 2; j--)
                    {
                        Console.Write("* ");
                    }
                }
                else
                {
                    for (int k = i - userNum2 / 2; k >= 0; k--)
                    {
                        Console.Write(" ");
                    }
                    for (int j = userNum2 / 2; j > i - userNum2 / 2; j--)
                    {
                        Console.Write("* ");
                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine();

        } // 프로그램은 여기서 끝남 // Main()
    }
}