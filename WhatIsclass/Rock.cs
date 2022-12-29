using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsclass
{
    internal class Rock
    {
        public static void RSP()
        {
            string userInput = Console.ReadLine();
            while (userInput != "quit")
            {

                while (true)
                {
                    if (userInput == "가위" || userInput == "바위" || userInput == "보")
                        break;
                    Console.Write("당신이 낸 것은? ->  ");
                    userInput = Console.ReadLine();
                }

                Random random = new Random();
                int comInput = random.Next(0, 3);
                switch (comInput)
                {
                    case 0:
                        Console.Write("컴퓨터가 낸 것은? -> 가위");
                        break;
                    case 1:
                        Console.Write("컴퓨터가 낸 것은? -> 바위");
                        break;
                    case 2:
                        Console.Write("컴퓨터가 낸 것은? -> 보");
                        break;
                    default:
                        break;
                }   // switch
                Console.WriteLine();

                switch (userInput)
                {
                    case "가위":
                        if (comInput == 0)
                        {
                            Console.WriteLine("비겼습니다.");
                        }
                        else if (comInput == 1)
                        {
                            Console.WriteLine("졌습니다.");
                        }
                        else
                        {
                            Console.WriteLine("이겼습니다.");
                        }
                        break;
                    case "바위":
                        if (comInput == 0)
                        {
                            Console.WriteLine("이겼습니다.");
                        }
                        else if (comInput == 1)
                        {
                            Console.WriteLine("비겼습니다.");
                        }
                        else
                        {
                            Console.WriteLine("졌습니다.");
                        }
                        break;
                    case "보":
                        if (comInput == 0)
                        {
                            Console.WriteLine("졌습니다.");
                        }
                        else if (comInput == 1)
                        {
                            Console.WriteLine("이겼습니다.");
                        }
                        else
                        {
                            Console.WriteLine("비겼습니다.");
                        }
                        break;
                    default:
                        break;
                }   // switch

                Console.Write("당신이 낸 것은? ->  ");
                userInput = Console.ReadLine();

            }
        }

    }
}
