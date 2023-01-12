using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveDungeon
{
    public class Print
    {

        // { 현재 방 배열 불러오기
        public int[,] RoomArray(int y, int x, int[,][,] map)
        {
            return map[y,x];
        } 

        // } 현재 방 배열 불러오기

        // { 방 내부 출력
        public void RoomPrint(int[,] room,int playerY,int playerX)
        {
            Console.Clear();
            int temp = 0;
            temp = room[playerY, playerX];
            room[playerY, playerX] = 9;

            string printString="";
            for (int i = 0; i < room.GetLength(0); i++)
            {
                for (int j = 0; j < room.GetLength(1); j++)
                {
                    switch (room[i,j])
                    {
                        // 0 : 빈칸
                        // 1 : 아이템
                        // 2 : 함정
                        // 3~6 : 포탈 상하좌우
                        // 7 : 클리어 포탈
                        // 8 : 벽
                        // 9 : 캐릭터
                        case 1:
                            printString = "$ ";
                            break;
                        case 2:
                            printString = "# ";
                            break;
                        case 0:
                        case 3:
                        case 4:
                        case 5:
                        case 6:
                            printString = ". ";
                            break;
                        case 7:
                            printString = "* ";
                            break;
                        case 8:
                            printString = "■";
                            break;
                        case 9:
                            printString = "옷";
                            break;
                        default:
                            break;
                    }
                    Console.Write(printString);
                }
                Console.WriteLine();
            }

            room[playerY, playerX] = temp;
        }

        // } 방 내부 출력

        // { 이름, 체력, 포인트 출력

        public void PrintName(string name,int HP, int point, int y, int x)
        {
            Console.WriteLine($"이름 : {name}");
            Console.WriteLine($"현재 체력 : {HP}");
            Console.WriteLine($"현재 점수 : {point}");
            Console.WriteLine($"현재 방 좌표 : {y}, {x}");
        }

        // } 이름, 체력, 포인트 출력
    }
}
