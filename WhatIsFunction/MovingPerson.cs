using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsFunction
{
    internal class MovingPerson
    {
        public static void Main()
        {
            /**
             * 22.12.26 과제
             * 보드를 돌아다니는 사람
             * w,a,s,d를 입력받아 빈 곳을 이동하는 프로그램을 작성
             * - 사람은 빈 곳으로 이동할 수 있음
             * - 사람은 벽을 넘을 수 없음
             */

            // { 보드 생성
            const int BOARD_X = 10;
            const int BOARD_Y = 10;

            string[,] board = new string[BOARD_X,BOARD_Y];

            // 현 위치
            int personX = BOARD_X / 2;
            int personY = BOARD_Y / 2;
            string position = string.Empty;

            for (int y = 0; y < BOARD_Y; y++)
            {
                for (int x = 0; x < BOARD_X; x++)
                {
                    if(y == personY && x == personX )
                    {
                        board[y, x] = "8 ";
                        continue;
                    }
                    if(y == BOARD_Y-1 || y == 0)
                    {
                        board[y, x] = "□";
                        continue;
                    }   
                    if (x == BOARD_X-1 || x == 0)
                    {
                        board[y,x] = "□";
                        continue;
                    }
                    board[y, x] = ". ";
                }
            }
            // } 보드 생성

            // { 이동해도 꺼지지 않음
            bool end = false;
            while (!end)
            {
                Console.Clear();
                // { 보드 출력
                for (int y = 0; y < BOARD_Y; y++)
                {
                    for (int x = 0; x < BOARD_X; x++)
                    {
                            Console.Write(board[y, x]);
                    }
                    Console.WriteLine();
                }
                // } 보드 출력

                Console.WriteLine();
                Console.WriteLine("w,a,s,d를 입력해주세요. -> ");
                position = Console.ReadLine();
                while (true)
                {
                    if(position == "w" || position == "a" || position == "s" || position == "d")
                    {
                        break;
                    }
                    else if(position == "q")
                    {
                        end = true;
                        break;
                    }
                    Console.WriteLine("w,a,s,d를 입력해주세요. -> ");
                    position = Console.ReadLine();
                }

                switch(position)
                {
                    case "w":
                        if (personY - 1 == 0) { break; }
                        personY = personY - 1;
                        break;
                    case "a":
                        if (personX - 1 == 0) { break; }
                        personX = personX - 1;
                        break;
                    case "s":
                        if (personY + 1 == BOARD_Y-1) { break; }
                        personY = personY + 1;
                        break;
                    case "d":
                        if (personX + 1 == BOARD_X-1) { break; }
                        personX = personX + 1;
                        break;
                    default:
                        break;
                }

                for (int y = 0; y < BOARD_Y; y++)
                {
                    for (int x = 0; x < BOARD_X; x++)
                    {
                        if (y == personY && x == personX)
                        {
                            board[y, x] = "8 ";
                            continue;
                        }
                        if (y == BOARD_Y - 1 || y == 0)
                        {
                            board[y, x] = "□";
                            continue;
                        }
                        if (x == BOARD_X - 1 || x == 0)
                        {
                            board[y, x] = "□";
                            continue;
                        }
                        board[y, x] = ". ";
                    }
                }
            }
            Console.WriteLine("이동을 정지합니다.");
            // } 이동해도 꺼지지 않음

        }
    }
}
