using System;

namespace WhatisArray
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            // 22.12.21 11:50~

            /**
             * 숫자 야구
             * 3자리 숫자를 임의로 정한 뒤 사용자가 3자리 숫자를 맞추게 함
             * 숫자는 맞고 자리만 맞은 경우 볼.
             * 숫자와 자리가 모두 맞은 경우 스트라이크.
             * 아무것도 맞지 않았으면 아웃.
             */

            Random random= new Random();
            int Num1 = random.Next(1, 10);
            int Num2 = random.Next(1, 10);
            while (Num1 == Num2)
            {
                Num2 = random.Next(1, 10);
            }
            int Num3 = random.Next(1, 10);
            while (Num3 == Num2 || Num3 == Num1)
            {
                Num3 = random.Next(1, 10);
            }

            
            int round = 0;

            int strike = 0;
            int ball = 0;
            int userNum1 = 0;
            int userNum2 = 0;
            int userNum3 = 0;

            bool isUserCollect1 = userNum1 == Num1;
            bool isUserCollect2 = userNum2 == Num2;
            bool isUserCollect3 = userNum3 == Num3;

            Console.WriteLine($"{Num1} {Num2} {Num3} ");

            while (!isUserCollect1 || !isUserCollect2 || !isUserCollect3)
            {

                round++;
                if (round >= 9)
                    break;

                Console.Write("첫번째 숫자를 입력해주세요. -> ");
                int.TryParse(Console.ReadLine(), out userNum1);

                while (userNum1 > 9 || userNum1 < 0)
                {
                    Console.Write("첫번째 숫자를 0~9 중 입력해주세요. -> ");
                    int.TryParse(Console.ReadLine(), out userNum1);
                }

                Console.Write("두번째 숫자를 입력해주세요. -> ");
                int.TryParse(Console.ReadLine(), out userNum2);

                while (userNum1 == userNum2 || userNum2 > 9 || userNum2 < 0)
                {
                    Console.Write("서로 다른 두번째 숫자를 0~9 중 입력해주세요. -> ");
                    int.TryParse(Console.ReadLine(), out userNum2);
                }

                Console.Write("마지막 숫자를 입력해주세요. -> ");
                int.TryParse(Console.ReadLine(), out userNum3);

                while (userNum2 == userNum3 || userNum1 == userNum3 || userNum3 > 9 || userNum3 < 0)
                {
                    Console.Write("서로 다른 마지막 숫자를 0~9 중 입력해주세요. -> ");
                    int.TryParse(Console.ReadLine(), out userNum3);
                }

                isUserCollect1 = userNum1 == Num1;
                isUserCollect2 = userNum2 == Num2;
                isUserCollect3 = userNum3 == Num3;


                strike = 0;
                ball = 0;

                bool isUserBall1 = userNum1 == Num2 || userNum1 == Num3;
                bool isUserBall2 = userNum2 == Num1 || userNum2 == Num3;
                bool isUserBall3 = userNum3 == Num1 || userNum3 == Num2;

                if (isUserBall1)
                    ball++;
                if(isUserBall2)
                    ball++;
                if(isUserBall3)
                    ball++;

                if (isUserCollect1)
                    strike++;
                if (isUserCollect2)
                    strike++;
                if (isUserCollect3)
                    strike++;

                if (ball == 0 && strike == 0)
                    Console.WriteLine("아웃");
                else if (strike == 3)
                    break;
                else
                    Console.WriteLine($"{strike}S {ball}B");

            }
            if(round>=9)
            Console.WriteLine("9회말 아웃. 컴퓨터의 승리입니다.");
            else
            Console.WriteLine($"{strike}S {ball}B 정답입니다.");


            //Console.Write("3자리 숫자를 맞춰보세요. 각 숫자는 띄어쓰기로 구분합니다. -> ");
            //string[] userNum = Console.ReadLine().Split(' ');

            //while(userNum.Length > 3 && userNum.Length <= 0) 
            //{
            //    Console.Write("3자리 숫자를 맞춰보세요. 각 숫자는 띄어쓰기로 구분합니다. -> ");
            //    userNum = Console.ReadLine().Split(' ');
            //}


        }

    }
}
