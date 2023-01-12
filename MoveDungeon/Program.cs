using System;
using System.Drawing;

namespace MoveDungeon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
             * 포탈 던전
             * 
             *  - 플레이어는 움직인다.
             *  - 플레이어는 벽에 막히면 움직일 수 없다.
             *  - 사방에는 벽이 있다.
             *  - 그러나 열린 벽(포탈)도 있다.
             *  - 포탈에 들어가면 다른 방으로 입장한다.
             *  - 다른 방 입장 시 입장 방향 반대로 포탈이 생성
             *  - 입장방향 반대로 캐릭터 생성
             *  - 들어왔던 곳으로 다시 돌아가면 원래 방이 나온다.
             *  - 클리어 포탈을 나가면 게임이 종료된다.
             *  
             * 필요 클래스
             *  - 플레이어
             *  - 벽(포탈)
             *  - 방(클리어 포탈)
             *  - 전체 맵
             *  - 출력
             *  
             */
            // 게임 실행
            MoveDungeon();
        }

        // 메인 게임
        static void MoveDungeon()
        {
            // 게임 클리어 체크
            bool isClear = false;
            // 체력 소진 체크
            bool isGameOver = false;
            // 플레이어 이름
            string userName = "김용사";
            // 현재 방 정보
            int[,] nowRoom;
            // 현재 방 위치
            int nowY = Map.mapHeight / 2;
            int nowX = Map.mapWidth / 2;
            // 맵 인스턴스화
            Map map = new Map();
            // 플레이어 인스턴스화
            Player player = new Player();
            // 출력 인스턴스화
            Print print = new Print();
            // 입력 키 정보 생성 
            ConsoleKeyInfo consoleKey;

            // { 초기 세팅
            // 맵 생성
            map.MapMake();
            // 현재 방 불러오기
            nowRoom = print.RoomArray(nowY, nowX, map.mapSquare);
            // 플레이어 위치 세팅
            player.playerY = Room.roomHeight / 2;
            player.playerX = Room.roomWidth / 2;
            // 플레이어 체력 세팅
            player.health = 3;
            // 현재 방 출력
            print.RoomPrint(nowRoom, player.playerY, player.playerX);
            // 현재 정보 출력
            print.PrintName(userName, player.health, player.point,nowY,nowX);
            // } 초기 세팅

            while (!isGameOver && !isClear)
            {
                // 입력 받기
                consoleKey = Console.ReadKey();
                switch (consoleKey.Key)
                {
                    case ConsoleKey.UpArrow:
                        // 벽 있는지 체크
                        if (nowRoom[player.playerY - 1, player.playerX] == 8)
                        {
                            /* Do Nothing */
                        }
                        else
                        {
                            // 없으면 입력에 따라 이동
                            player.playerY = player.PlayerUp(player.playerY);
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (nowRoom[player.playerY + 1, player.playerX] == 8)
                        {
                            /* Do Nothing */
                        }
                        else
                        {
                            player.playerY = player.PlayerDown(player.playerY);
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (nowRoom[player.playerY, player.playerX - 1] == 8)
                        {
                            /* Do Nothing */
                        }
                        else
                        {
                            player.playerX = player.PlayerLeft(player.playerX);
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (nowRoom[player.playerY, player.playerX + 1] == 8)
                        {
                            /* Do Nothing */
                        }
                        else
                        {
                            player.playerX = player.PlayerRight(player.playerX);
                        }
                        break;
                    default:
                        break;
                }// switch()

                // { 플레이어 이동 위치에 있는 것 체크
                // 1 : 아이템 / 2 : 함정 / 3~6 : 포탈 상하좌우 / 7 : 클리어 포탈
                switch (nowRoom[player.playerY, player.playerX])
                {
                    case 1:
                        player.point = player.PlusPoint(player.point);
                        nowRoom[player.playerY, player.playerX] = 0;
                        break;
                    case 2:
                        player.health = player.MinusHP(player.health);
                        nowRoom[player.playerY, player.playerX] = 0;
                        break;
                    case 3:
                        nowY = nowY - 1;
                        nowRoom = map.mapSquare[nowY, nowX];
                        player.playerY = nowRoom.GetLength(0)-2;
                        break;
                    case 4:
                        nowY = nowY + 1;
                        nowRoom = map.mapSquare[nowY, nowX];
                        player.playerY = 1;
                        break;
                    case 5:
                        nowX = nowX - 1;
                        nowRoom = map.mapSquare[nowY, nowX];
                        player.playerX = nowRoom.GetLength(1)-2;
                        break;
                    case 6:
                        nowX = nowX + 1;
                        nowRoom = map.mapSquare[nowY, nowX];
                        player.playerX = 1;
                        break;
                    case 7:
                        player.clearCheck = true;
                        break;
                    default:
                        break;
                }
                // 현재 룸 덮어쓰기
                map.mapSquare[nowY, nowX] = nowRoom;
                // 현재 방 출력
                print.RoomPrint(nowRoom, player.playerY, player.playerX);
                // 현재 정보 출력
                print.PrintName(userName, player.health, player.point,nowY,nowX);

                // 체력이 0인지 체크 0이면 isGameOver = true
                if (player.health <= 0)
                {
                    isGameOver = true;
                }
                // 클리어 포탈에 도달하면 isClear = true
                if (player.clearCheck)
                {
                    isClear = true;
                }

            } // 체력이 다 하거나 클리어 하기 전까지 반복

            if (isGameOver)
            {
                Console.WriteLine($"{userName}의 체력이 다했습니다.");
                Console.WriteLine("던전을 빠져나오지 못했습니다.");
            }
            else
            {
                Console.WriteLine($"{userName}은 던전을 빠져나왔습니다.");
                Console.WriteLine("던전을 클리어했습니다!");
            }
        }


    }
}