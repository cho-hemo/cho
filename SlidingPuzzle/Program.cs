using System;

namespace SlidingPuzzle
{
    internal class Program
    {
        // 22.12.27 과제 슬라이딩 퍼즐
        static int[,] collectBoard = new int[3, 3];
        static int[,] playBoard = new int[3, 3];
        static int posX = 0;
        static int posY = 0;
        static bool isGameEnd = false;
        static Random random = new Random();
        static int[] randNum = new int[9];
        static bool anotherNum = true;
        static int moveNum = 0;
        static int num = 0;
        static int inv = 0;

        static void Main(string[] args)
        {
            
            // { 정답 보드
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    num++;
                    collectBoard[i, j] = num;
                }
            }
            // } 정답 보드
            randPuzzle(); // 랜덤 생성
            printBoard();
            ConsoleKeyInfo checkKey;
            while (!isGameEnd)
            {
                checkKey = Console.ReadKey(true);
                switch (checkKey.Key)
                {
                    case ConsoleKey.W:
                        inputW();
                        break;
                    case ConsoleKey.A:
                        inputA();
                        break;
                    case ConsoleKey.S:
                        inputS();
                        break;
                    case ConsoleKey.D:
                        inputD();
                        break;
                    default:
                        break;
                }
                printBoard();
                isGameEnd = collectCheck();
            }

            // 끝났을 때
            Console.WriteLine("모두 맞췄습니다!");

        }
        // 퍼즐 랜덤 생성 함수

        static void randPuzzle()
        {
            // { 플레이 보드
            num = 0;
            inv = 1;
            while (inv % 2 == 1)
            {
                for (int i = 0; i < 9; i++)
                {
                    num = random.Next(1, 10);
                    while (anotherNum)
                    {
                        if (Array.Exists(randNum, x => x == num))
                        {
                            anotherNum = true;
                            num = random.Next(1, 10);
                        }
                        else
                        {
                            anotherNum = false;
                            randNum[i] = num;
                        }
                    }
                    anotherNum = true;
                }

                inv = 0;
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (randNum[i] > randNum[j])
                        {
                            inv = inv + 1;
                        }
                    }
                }
                
            }
            
            num = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    playBoard[i,j] = randNum[num];
                    num++;
                }
            }
            // } 플레이 보드
        }

        // { 보드 출력 함수
        static void printBoard()
        {
            Console.Clear();
            Console.WriteLine("=========================");
            Console.WriteLine("===== 슬라이딩 퍼즐 =====");
            Console.WriteLine("=========================\n\n");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("        ");
                for (int j = 0; j < 3; j++)
                {
                    if (playBoard[i, j] == 9 )
                    {
                        Console.Write($" X ");
                        posY= i;
                        posX= j;
                        continue;
                    }
                    Console.Write($" {playBoard[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\n=========================");
        }
        // } 보드 출력 함수

        // 입력 w
        static void inputW()
        {
            if (posY == 0)
            {
                /* Do nothing */
            }
            else
            {
                moveNum = playBoard[posY-1, posX];
                playBoard[posY-1,posX] = 9;
                playBoard[posY,posX] = moveNum;
                posY--;
            }
        }

        // 입력 a
        static void inputA()
        {
            if (posX == 0)
            {
                /* Do nothing */
            }
            else
            {
                moveNum = playBoard[posY, posX-1];
                playBoard[posY, posX-1] = 9;
                playBoard[posY, posX] = moveNum;
                posX--;
            }
        }

        // 입력 s
        static void inputS()
        {
            if (posY == 2)
            {
                /* Do nothing */
            }
            else
            {
                moveNum = playBoard[posY+1, posX];
                playBoard[posY+1, posX] = 9;
                playBoard[posY, posX] = moveNum;
                posY++;
            }
        }

        // 입력 d
        static void inputD()
        {
            if (posX == 2)
            {
                /* Do nothing */
            }
            else
            {
                moveNum = playBoard[posY, posX+1];
                playBoard[posY, posX+1] = 9;
                playBoard[posY, posX] = moveNum;
                posX++;
            }
        }

        // 정답인지 체크
        static bool collectCheck()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if(playBoard[i,j] == collectBoard[i, j])
                    {
                        continue;
                    }
                    else
                        return false;
                }
            }
            return true;
        }



    }
}