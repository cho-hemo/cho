using System;
namespace WhatIsFunction
{
    internal class TicTacToe
    {
        enum TicTacToePlayerType
        {
            None = 0, PLAYER, COMPUTER
        }
        static void Main(string[] args)
        {
            /**
             * 22.12.26 오전 2교시
             * 
             * 틱택토 게임
             * 컴퓨터와 사람이 번갈아 가면서 O,X를 둔다.
             * 보드 크기는 3 x 3
             * 컴퓨터의 룰은 간단하게
             * 1. 중앙이 비었으면 중앙을 선점.
             * 2. 이후에 빈자리 랜덤하게 둔다.
             */

            int[,] board = new int[3, 3];
            int playerX, playerY = 0;
            bool isValidLocation = false;
            bool isPlayerTurn = false;
            bool isGameOver = false;

            string playerIcon = string.Empty;
            string playerType = string.Empty;

            while (!isGameOver)
            {
                // 플레이어 턴 진행
                isPlayerTurn= true;
                playerType = "[플레이어]";
                // { 플레이어에게서 좌표 입력받기
                playerX = 0;
                playerY = 0;
                isValidLocation= false;

                while (true)
                {
                    // 가독성을 위해 while을 무한으로 두고 탈출 조건 따로 주는 방법
                    if (isValidLocation == true)
                        break;

                    // 플레이어 턴 / 좌표 입력 받음
                    Console.Write("[플레이어] (X) 좌표 : ");
                    int.TryParse(Console.ReadLine(), out playerX );
                    Console.Write("[플레이어] (Y) 좌표 : ");
                    int.TryParse(Console.ReadLine(), out playerY );

                    if (board[playerY,playerX].Equals((int)TicTacToePlayerType.None))
                    {
                        board[playerY, playerX] = (int)(TicTacToePlayerType.PLAYER);
                        isValidLocation= true;
                    }// if: 보드가 빈 곳인 경우
                    else
                    {
                        Console.WriteLine("[해당 좌표는 비어있지 않습니다. / 다른 좌표를 입력하세요.]");
                        isValidLocation= false;
                    }// else : 보드가 빈 곳이 아닌 경우
                    
                } // loop 플레이어의 좌표 입력을 받는 루프
                // } 플레이어에게서 좌표 입력받기

                // { 플레이어의 턴 진행을 보드에 출력
                for (int y = 0; y <= board.GetUpperBound(0); y++) // 어퍼바운드 주는 이유 : 확장성
                {
                    Console.WriteLine("----|---|----");
                    Console.Write("|");
                    for (int x= 0; x <= board.GetUpperBound(1); x++)
                    {
                        switch (board[y, x])
                        {
                            case (int)TicTacToePlayerType.PLAYER:
                                playerIcon = "O";
                                break;
                            case (int)TicTacToePlayerType.COMPUTER:
                                playerIcon = "X";
                                break;
                            default:
                                playerIcon = " ";
                                break;
                        } // switch 
                        Console.Write($" {playerIcon} ");

                        // Print Separator
                        if (x == board.GetUpperBound(1)) { /* Do nothing */}
                        else{ Console.Write("|"); }
                    } // loop : 한줄에 출력할 내용을 연산
                    Console.WriteLine( "|");
                }// loop : 보드를 출력하는 루프
                Console.WriteLine("----|---|----");
                // } 플레이어의 턴 진행을 보드에 출력

                // { 게임이 끝났는지 보드 검사
                Console.WriteLine();
                isGameOver= false;
                for (int y = 0; y <= board.GetUpperBound(0); y++)
                {
                    if (board[y,0].Equals((int)TicTacToePlayerType.PLAYER) &&
                        board[y,1].Equals((int)TicTacToePlayerType.PLAYER) &&
                        board[y,2].Equals((int)TicTacToePlayerType.PLAYER) )
                    { 
                        isGameOver = true;
                    }
                    else
                    { continue; }
                }    // loop : 가로 방향 검사 루프
                for (int x = 0; x <= board.GetUpperBound(1); x++)
                {
                    if (board[0, x].Equals((int)TicTacToePlayerType.PLAYER) &&
                        board[1, x].Equals((int)TicTacToePlayerType.PLAYER) &&
                        board[2, x].Equals((int)TicTacToePlayerType.PLAYER))
                    {
                        isGameOver= true;
                    }
                    else { continue; } 
                } // loop : 세로 방향 검사 루프
                if (board[0, 0].Equals((int)TicTacToePlayerType.PLAYER) &&
                    board[1, 1].Equals((int)TicTacToePlayerType.PLAYER) &&
                    board[2, 2].Equals((int)TicTacToePlayerType.PLAYER))
                {
                    isGameOver= true;
                }
                if (board[0, 2].Equals((int)TicTacToePlayerType.PLAYER) &&
                    board[1, 1].Equals((int)TicTacToePlayerType.PLAYER) &&
                    board[2, 0].Equals((int)TicTacToePlayerType.PLAYER))
                {
                    isGameOver= true;
                }
                // } 게임이 끝났는지 보드 검사

                // 게임이 끝난 경우 루프 탈출
                if (isGameOver)
                {
                    break;
                }

                // { 게임이 끝나지 않은 경우 턴을 교체
                isPlayerTurn= false;
                playerType = "[컴퓨터]";
                bool isComputerDoing = false;

                Console.WriteLine($"{playerType}의 턴");
                // 컴퓨터의 간단한 룰
                // { 1. 중앙이 비어있으면 선점
                if (!isComputerDoing)
                {
                    if (board[1, 1].Equals((int)TicTacToePlayerType.None))
                    {
                        board[1, 1] = (int)TicTacToePlayerType.COMPUTER;
                        isComputerDoing= true;
                    }// if : 중앙이 비어있는 경우
                    else { /* Do Nothing */ }
                } // if : 컴퓨터가 아직 행동하지 않은 경우
                else { /* Do Nothing */}
                // } 1. 중앙이 비어있으면 선점
                // { 2. 이후 빈자리 찾아 배치
                if (!isComputerDoing)
                {
                    for (int y = 0; y <= board.GetUpperBound(0); y++)
                    {
                        for (int x = 0; x <= board.GetUpperBound(1); x++)
                        {
                            if(isComputerDoing == false &&
                                board[y, x].Equals((int)TicTacToePlayerType.None))
                            {
                                board[y, x] = (int)TicTacToePlayerType.COMPUTER;
                                isComputerDoing= true;
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        } // loop : 가로열 검색
                    } // loop : 세로열 검색
                } // if : 컴퓨터가 아직 행동하지 않은 경우
                else { /* Do Nothing */ }
                // } 2. 이후 빈자리 찾아 배치

                // { 컴퓨터의 턴 진행을 보드에 출력
                for (int y = 0; y <= board.GetUpperBound(0); y++) // 어퍼바운드 주는 이유 : 확장성
                {
                    Console.WriteLine("----|---|----");
                    Console.Write("|");
                    for (int x = 0; x <= board.GetUpperBound(1); x++)
                    {
                        switch (board[y, x])
                        {
                            case (int)TicTacToePlayerType.PLAYER:
                                playerIcon = "O";
                                break;
                            case (int)TicTacToePlayerType.COMPUTER:
                                playerIcon = "X";
                                break;
                            default:
                                playerIcon = " ";
                                break;
                        } // switch 
                        Console.Write($" {playerIcon} ");

                        // Print Separator
                        if (x == board.GetUpperBound(1)) { /* Do nothing */}
                        else { Console.Write("|"); }
                    } // loop : 한줄에 출력할 내용을 연산
                    Console.WriteLine("|");
                }// loop : 보드를 출력하는 루프
                Console.WriteLine("----|---|----");
                // } 컴퓨터의 턴 진행을 보드에 출력

                // { 게임이 끝났는지 보드 검사
                Console.WriteLine();
                isGameOver = false;
                for (int y = 0; y <= board.GetUpperBound(0); y++)
                {
                    if (board[y, 0].Equals((int)TicTacToePlayerType.COMPUTER) &&
                        board[y, 1].Equals((int)TicTacToePlayerType.COMPUTER) &&
                        board[y, 2].Equals((int)TicTacToePlayerType.COMPUTER))
                    {
                        isGameOver = true;
                    }
                    else
                    { continue; }
                }    // loop : 가로 방향 검사 루프
                for (int x = 0; x <= board.GetUpperBound(1); x++)
                {
                    if (board[0, x].Equals((int)TicTacToePlayerType.COMPUTER) &&
                        board[1, x].Equals((int)TicTacToePlayerType.COMPUTER) &&
                        board[2, x].Equals((int)TicTacToePlayerType.COMPUTER))
                    {
                        isGameOver = true;
                    }
                    else { continue; }
                } // loop : 세로 방향 검사 루프
                if (board[0, 0].Equals((int)TicTacToePlayerType.COMPUTER) &&
                    board[1, 1].Equals((int)TicTacToePlayerType.COMPUTER) &&
                    board[2, 2].Equals((int)TicTacToePlayerType.COMPUTER))
                {
                    isGameOver = true;
                }
                if (board[0, 2].Equals((int)TicTacToePlayerType.COMPUTER) &&
                    board[1, 1].Equals((int)TicTacToePlayerType.COMPUTER) &&
                    board[2, 0].Equals((int)TicTacToePlayerType.COMPUTER))
                {
                    isGameOver = true;
                }
                // } 게임이 끝났는지 보드 검사

                // 게임이 끝난 경우 루프 탈출
                if (isGameOver)
                {
                    break;
                }

            } // loop : 틱택토 게임 루프

            Console.WriteLine($"{playerType}의 승리입니다.");
        }
    }
}
