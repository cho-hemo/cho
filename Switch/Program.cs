using System;

namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * switch문
             * 값에 따라 다양한 제어 처리 가능.
             * 조건을 처리할 내용이 많은 경우 유리.
             * switch, case, default 키워드를 사용하여 조건을 처리.
             */

            /*Console.Write("정수 1,2,3 중 하나를 입력하시오 -> ");
            int switchNum = 0;
            int.TryParse(Console.ReadLine(), out switchNum);

            switch(switchNum)
            {
                case 1:
                    Console.WriteLine("1을 입력했습니다.");
                    break;
                case 2:
                    Console.WriteLine("2을 입력했습니다.");
                    break;
                case 3:
                    Console.WriteLine("3을 입력했습니다.");
                    break;
                default:
                    Console.WriteLine("처리하지 않은 예외입력입니다.");
                    break;
            
            }// switch
            */

            //Console.Write("정수 1,2,3 중 하나를 입력하시오 -> ");
            //int switchNum = 0;
            //int.TryParse(Console.ReadLine(), out switchNum);

            //switch(switchNum)
            //{
            //    case 1:
            //    case 2:
            //    case 3:
            //        Console.WriteLine("3을 입력했습니다.");
            //        break;
            //    default:
            //        Console.WriteLine("처리하지 않은 예외입력입니다.");
            //        break;
            //}// switch

            //Console.Write("정수 1,2,3 중 하나를 입력하시오 -> ");
            //int switchNum = 0;
            //int.TryParse(Console.ReadLine(), out switchNum);

            //switch (switchNum)
            //{
            //    case 1:
            //        Console.WriteLine("1을 입력했습니다.");
            //        goto case 3;
            //    case 2:
            //        Console.WriteLine("2를 입력했습니다.");
            //        break;
            //    case 3:
            //        Console.WriteLine("3을 입력했습니다.");
            //        break;
            //    default:
            //        Console.WriteLine("처리하지 않은 예외입력입니다.");
            //        break;
            //}// switch

            //Console.WriteLine("가장 좋아하는 프로그래밍 언어는?");
            //Console.WriteLine("1. C \t");
            //Console.WriteLine("1. C++ \t");
            //Console.WriteLine("1. C# \t");
            //Console.WriteLine("1. Java \t");

            //int choice = Convert.ToInt32(Console.ReadLine());

            //switch(choice)
            //{
            //    case 1:
            //        Console.WriteLine("C를 가장 좋아하시는군요!");
            //        break;
            //    case 2:
            //        Console.WriteLine("C++를 가장 좋아하시는군요!");
            //        break;
            //    case 3:
            //        Console.WriteLine("C#을 가장 좋아하시는군요!");
            //        break;
            //    case 4:
            //        Console.WriteLine("Java를 가장 좋아하시는군요!");
            //        break;
            //    default:
            //        Console.WriteLine("보기에 없는 항목입니다.");
            //        break;
            //}

            //Console.Write("오늘 날씨는 어떤가요? -> (맑음, 흐림, 비, 눈, ...");
            //string weather = Console.ReadLine();

            //switch(weather)
            //{
            //    case "맑음":
            //        Console.WriteLine("오늘 하늘은 화창합니다.");
            //        break;
            //    case "흐림":
            //        Console.WriteLine("오늘은 구름이 많습니다.");
            //        break;
            //    case "비":
            //        Console.WriteLine("비가 오고 있으니 우산을 챙기세요.");
            //        break;
            //    default:
            //        Console.WriteLine("혹시 눈이 오고 있나요?");
            //        break;
            //}   // switch

            /**
             * while 문
             * 조건식이 참일 동안 문장을 반복 실행.
             */            //int loopCount = 0;
            //while (loopCount<5)
            //{
            //    Console.WriteLine($"{loopCount+1}회 실행되었습니다.");
            //    loopCount++;
            //}   // 5번 도는 루프

            //// 10 ~ 1 카운트 후 발사
            //loopCount= 10;
            //while (loopCount>0) 
            //{
            //    Console.WriteLine($"{loopCount}");
            //    loopCount--;
            //}
            //Console.WriteLine("발사!");


            // 구구단 출력
            // user input 받아서 해당 단 출력
            //Console.Write("구구단 중에서 출력하고 싶은 단을 입력해주세요 -> ");
            //int userGugu = 0;
            //int.TryParse(Console.ReadLine(), out userGugu);

            //const int GUGU_LOOP_COUNT = 9;
            //int guguLoopIdx = 1;
            //if (userGugu > 9 || userGugu < 1)
            //{
            //    Console.WriteLine("구구단에 포함되어 있지 않습니다.");
            //}
            //else {
            //    while (guguLoopIdx <= GUGU_LOOP_COUNT)
            //    {
            //        Console.WriteLine($"{userGugu}x{guguLoopIdx}={userGugu*guguLoopIdx}");
            //        guguLoopIdx++;
            //    }
            //}

            // 사용자로부터 양의 정수를 하나 입력 받아서 그 수만큼 헬로 월드 출력

            Console.Write("양의 정수를 입력해주세요. -> ");
            int Num = 0;
            int loopCount = 0;
            int.TryParse(Console.ReadLine(), out Num);
            if(Num < 0)
            {
                Console.WriteLine("양의 정수를 입력해주세요.");
            }
            else
            {
                while (loopCount < Num)
                {
                    Console.WriteLine("헬로초초월드!");
                    loopCount++;
                }
            }
            Console.WriteLine("");



            // 사용자로부터 양의 정수를 하나 입력 받아서 그 수만큼 3의 배수 출력

            Console.Write("양의 정수를 입력해주세요. -> ");
            int.TryParse(Console.ReadLine(), out Num);
            loopCount = 0;
            if (Num < 0)
            {
                Console.WriteLine("양의 정수를 입력해주세요.");
            }
            else
            {
                while (loopCount < Num)
                {
                    Console.Write($"{3*(loopCount+1)} ");
                    loopCount++;
                }
            }
            Console.WriteLine("");



            // 사용자로부터 계속해서 정수를 입력받고 그 값을 계속 더한다.
            // 사용자가 0을 입력하면 입력된 모든 정수의 합을 출력 후 정지.

            int sumNum = 0;
            loopCount= 0;

            Console.Write("정수를 입력해주세요. 0을 입력하면 합이 출력됩니다. -> ");
            int.TryParse(Console.ReadLine(), out Num);
            sumNum = sumNum + Num;
            while (Num != 0)
            {
                Console.Write("정수를 입력해주세요. 0을 입력하면 합이 출력됩니다. -> ");
                int.TryParse(Console.ReadLine(), out Num);
                sumNum = sumNum + Num;
            }

            Console.WriteLine($"입력한 값의 합 : {sumNum}");


            // 사용자로부터 입력받은 숫자에 해당하는 구구단을 역순으로 출력

            Console.Write("구구단 중에서 출력하고 싶은 단을 입력해주세요 -> ");
            int userGugu = 0;
            int.TryParse(Console.ReadLine(), out userGugu);

            const int GUGU_LOOP_COUNT = 1;
            int guguLoopIdx = 9;
            if (userGugu > 9 || userGugu < 1)
            {
                Console.WriteLine("구구단에 포함되어 있지 않습니다.");
            }
            else {
                while (guguLoopIdx >= GUGU_LOOP_COUNT)
                {
                    Console.WriteLine($"{userGugu}x{guguLoopIdx}={userGugu*guguLoopIdx}");
                    guguLoopIdx--;
                }
            }

            // 사용자로부터 입력받은 정수의 평균을 출력하는 프로그램.
            // 몇 개의 정수를 입력할 것인지 사용자에게 질문. 그 수만큼 정수를 입력받는다.
            // 평균 값은 소수점 이하까지 계산해서 출력.


            int userEverCount = 0;
            int everCount = 0;
            int usereverNum = 0;
            float eversumNum = 0;
            float everNum = 0;

            Console.Write("숫자 몇 개 평균을 낼까요? -> ");
            int.TryParse(Console.ReadLine(), out userEverCount);

            while (everCount < userEverCount)
            {
                Console.Write($"[{userEverCount - everCount}/{userEverCount}]숫자를 입력해주세요. -> ");              
                int.TryParse(Console.ReadLine(), out usereverNum);
                eversumNum = eversumNum + usereverNum;
                everCount++;
            }
            everNum = eversumNum / userEverCount;
            Console.WriteLine($"입력한 숫자의 평균 값은 {everNum}입니다.");



        }   // Main()
    }
}