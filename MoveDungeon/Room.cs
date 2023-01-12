using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveDungeon
{
    public class Room
    {
        // 방 가로
        public static int roomWidth = 15;
        // 방 세로
        public static int roomHeight = 15;
        // 포탈 위치
        public uint roomPortal = 0b_0000;
        // 클리어룸 조건 달성
        public bool clearRoom;
        // 방 배열
        public int[,] roomData = new int[roomHeight, roomWidth];
        // 랜덤 함수
        Random random = new Random();

        // { 방 생성
        public int[,] RoomMake()
        {
            // 기본 배열 생성
            roomData = new int[roomHeight, roomWidth];
            uint randNum = (uint)random.Next(1, 16);
            int randItem = 0;
            // 벽 생성
            roomData = WallMake(roomHeight, roomWidth, roomData);
            // 포탈 생성
            // randNum 비트 연산해서 해당되면 포탈 만들기
            roomData = RoomPortal(roomData, randNum);
            
            // 방 하나당 아이템 하나
            for (int i = 1; i < roomHeight-1; i++)
            {
                for (int j = 1; j < roomWidth-1; j++)
                {
                    randItem = random.Next(0, 165);
                    if (randItem < 1 && roomData[i, j] == 0)
                    {
                        roomData[i, j] = 1;
                    }
                }
            }
            // 방 하나당 함정 2개
            for (int i = 1; i < roomHeight - 1; i++)
            {
                for (int j = 1; j < roomWidth - 1; j++)
                {
                    randItem = random.Next(0, 165);
                    if (randItem < 2 && roomData[i, j] == 0)
                    {
                        roomData[i, j] = 2;
                    }
                }
            }

            return roomData;
        }
        // } 방 생성

        // 포탈 생성 위치
        public int[,] RoomPortal(int[,] roomData, uint Num)
        {
            if ((Num & 0b_1000) == 0b_1000)
            {
                roomData = PortalMake(roomHeight, roomWidth, 0, roomData);
                roomPortal = roomPortal | 0b_1000;
            }
            if ((Num & 0b_0100) == 0b_0100)
            {
                roomData = PortalMake(roomHeight, roomWidth, 1, roomData);
                roomPortal = roomPortal | 0b_0100;
            }
            if ((Num & 0b_0010) == 0b_0010)
            {
                roomData = PortalMake(roomHeight, roomWidth, 2, roomData);
                roomPortal = roomPortal | 0b_0010;
            }
            if ((Num & 0b_0001) == 0b_0001)
            {
                roomData = PortalMake(roomHeight, roomWidth, 3, roomData);
                roomPortal = roomPortal | 0b_0001;
            }
            return roomData;
        }

        // 클리어 포탈 생성
        public int[,] ClearPortalMake(int maxY, int maxX, int pos, int[,] roomData)
        {

            switch (pos)
            {
                case 0:
                    for (int i = (maxX / 2) - 3; i < (maxX / 2) + 3; i++)
                    {
                        roomData[0, i] = 7;
                    }
                    break;
                case 1:
                    for (int i = (maxX / 2) - 3; i < (maxX / 2) + 3; i++)
                    {
                        roomData[maxY-1, i] = 7;
                    }
                    break;
                case 2:
                    for (int i = (maxY / 2) - 3; i < (maxY / 2) + 3; i++)
                    {
                        roomData[i, 0] = 7;
                    }
                    break;
                case 3:
                    for (int i = (maxY / 2) - 3; i < (maxY / 2) + 3; i++)
                    {
                        roomData[i, maxX-1] = 7;
                    }
                    break;
                default:
                    break;
            }
            return roomData;
        }

        // 벽 생성
        public int[,] WallMake(int maxY, int maxX, int[,] roomData)
        {
            for (int i = 0; i < maxY; i++)
            {
                for (int j = 0; j < maxX; j++)
                {
                    if (i == 0 || j == 0 || i == maxY-1 || j == maxX-1)
                    {
                        roomData[i, j] = 8;
                    }
                }
            }
            return roomData;
        }

        // 포탈 생성
        public int[,] PortalMake(int maxY, int maxX, int pos, int[,] roomData)
        {
            switch (pos)
            {
                case 0:
                    for (int i = (maxX / 2) - 3; i < (maxX / 2) + 3; i++)
                    {
                        roomData[0, i] = 3;
                    }
                    break;
                case 1:
                    for (int i = (maxX / 2) - 3; i < (maxX / 2) + 3; i++)
                    {
                        roomData[maxY-1, i] = 4;
                    }
                    break;
                case 2:
                    for (int i = (maxY / 2) - 3; i < (maxY / 2) + 3; i++)
                    {
                        roomData[i, 0] = 5;
                    }
                    break;
                case 3:
                    for (int i = (maxY / 2) - 3; i < (maxY / 2) + 3; i++)
                    {
                        roomData[i, maxX-1] = 6;
                    }
                    break;
                default:
                    break;
            }
            return roomData;
        }

        // 한쪽 벽 생성
        public int[,] WallLineMake(int maxY, int maxX, int pos, int[,] roomData)
        {
            switch (pos)
            {
                case 0:
                    for (int i =0; i<maxX ; i++)
                    {
                        roomData[0, i] = 8;
                    }
                    break;
                case 1:
                    for (int i =0; i<maxX ; i++)
                    {
                        roomData[maxY-1, i] = 8;
                    }
                    break;
                case 2:
                    for (int i = 0; i < maxY; i++)
                    {
                        roomData[i, 0] = 8;
                    }
                    break;
                case 3:
                    for (int i = 0; i < maxY; i++)
                    {
                        roomData[i, maxX-1] = 8;
                    }
                    break;
                default:
                    break;
            }
            return roomData;
        }
    }
}
