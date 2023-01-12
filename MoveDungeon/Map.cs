using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveDungeon
{
    public class Map
    {
        // 맵 가로
        public static int mapWidth = 10;
        // 맵 세로
        public static int mapHeight = 10;
        // 방 포탈 위치
        public uint roomportal = 0b_0000;
        // 맵 배열
        public int[,][,] mapSquare;
        // 방 크기 불러오기
        Room room = new Room();
        // 랜덤 함수
        Random random = new Random();

        // 맵 생성
        public void MapMake()
        {
            bool end = false;
            int randNum = 0;
            int posY = mapHeight / 2;
            int posX = mapWidth / 2;
            int roomCount = 0;
            int countErr = 0;
            List<int[]> round = new List<int[]>();
            int[] roundYX = new int[2];

            room.roomData = new int[Room.roomHeight, Room.roomWidth];

            // 빈칸 채우기
            mapSquare = new int[mapHeight, mapWidth][,];
            for (int i = 0; i < mapHeight; i++)
            {
                for (int j = 0; j < mapWidth; j++)
                {
                    mapSquare[i, j] = room.roomData;
                }
            }

            // 맵 중간에 사방이 열린 방을 하나 만든다
            mapSquare[posY, posX] = room.RoomMake();
            mapSquare[posY, posX] = room.RoomPortal(mapSquare[posY, posX], 15);
            roomportal = 15;

            // 그 주위로 방 생성
            while (!end)
            {
                if (posY + 1 >= mapHeight || posX + 1 >= mapWidth || posY - 1 < 0 || posX - 1 < 0)
                {
                    posY = mapHeight / 2;
                    posX = mapWidth / 2;
                    roomportal = PortalCheck(posY, posX);
                }
                if ((roomportal & 0b_1000) == 0b_1000)
                {
                    if (mapSquare[posY - 1, posX][0, 0] == 0)
                    {
                        mapSquare[posY - 1, posX] = room.RoomMake();
                        PortalPos(posY - 1, posX, 0, roomportal);
                        round.Add(new int[2] { posY - 1, posX });
                        roomCount++;
                    }
                    else
                    {
                        round.Add(new int[2] { posY - 1, posX });
                    }
                }
                if ((roomportal & 0b_0100) == 0b_0100)
                {
                    if (mapSquare[posY + 1, posX][0, 0] == 0)
                    {
                        mapSquare[posY + 1, posX] = room.RoomMake();
                        PortalPos(posY + 1, posX, 1, roomportal);
                        round.Add(new int[2] { posY + 1, posX });
                        roomCount++;
                    }
                    else
                    {
                        round.Add(new int[2] { posY + 1, posX });
                    }
                }
                if ((roomportal & 0b_0010) == 0b_0010)
                {
                    if (mapSquare[posY, posX - 1][0, 0] == 0)
                    {
                        mapSquare[posY, posX - 1] = room.RoomMake();
                        PortalPos(posY, posX - 1, 2, roomportal);
                        round.Add(new int[2] { posY, posX - 1 });
                        roomCount++;
                    }
                    else
                    {
                        round.Add(new int[2] { posY, posX - 1 });
                    }
                }
                if ((roomportal & 0b_0001) == 0b_0001)
                {
                    if (mapSquare[posY, posX + 1][0, 0] == 0)
                    {
                        mapSquare[posY, posX + 1] = room.RoomMake();
                        PortalPos(posY, posX + 1, 3, roomportal);
                        round.Add(new int[2] { posY, posX + 1 });
                        roomCount++;
                    }
                    else
                    {
                        round.Add(new int[2] { posY, posX + 1 });
                    }
                }

                if (countErr == roomCount)
                {
                    mapSquare[posY, posX] = room.RoomPortal(mapSquare[posY, posX], 15);
                    roomportal = 15;
                }
                else
                {
                    countErr = roomCount;
                }
                // 다음 방으로 이동
                if (round.Count > 0)
                {
                    roundYX = round[random.Next(0, round.Count)];
                    posY = roundYX[0];
                    posX = roundYX[1];
                    roomportal = PortalCheck(posY, posX);
                }
                round.Clear();


                if (roomCount >= 30)
                {
                    end = true;
                }
            }

            // 모든 방+사방 검사
            // 이어진 방이 없다면 포탈 막기/이어진 방이 있다면 옆방 포탈 만들기 
            for (int i = 0; i < mapSquare.GetLength(0); i++)
            {
                for (int j = 0; j < mapSquare.GetLength(1); j++)
                {
                    // i-1 이 0보다 작은 방은 검사하지 않는다.
                    // i+1 이 mapSquare.GetLength(0)와 같거나 큰 방은 검사하지 않는다.
                    // j-1 이 0보다 작은 방은 검사하지 않는다.
                    // j+1 이 mapSquare.GetLength(0)와 같거나 큰 방은 검사하지 않는다.
                    // 검사하지 않는 방과 이어진 포탈은 닫는다.
                    // 사방 중 포탈이 열려있으나 이어져 있지 않은 방의
                    // 포탈을 닫거나 그 방의 포탈을 연다.


                    // 현재 방의 포탈 위치 체크
                    roomportal = PortalCheck(i, j);
                    if (roomportal == 0)
                    {
                        continue;
                    }
                    // 포탈이 열려있지 않으면 그쪽 방향은 검사하지 않는다.
                    if ((roomportal & 0b_1000) == 0b_1000)
                    {
                        if (i - 1 < 0)
                        {
                            mapSquare[i, j] = room.WallLineMake(Room.roomHeight, Room.roomWidth, 0, mapSquare[i, j]);
                        }
                        else
                        {
                            // 사방 중 비어있는 칸이 있다면 그 방향의 포탈은 닫는다.
                            if (mapSquare[i - 1, j][0, 0] == 0)
                            {
                                mapSquare[i, j] = room.WallLineMake(Room.roomHeight, Room.roomWidth, 0, mapSquare[i, j]);
                            }
                            else
                            {
                                // 비어있지 않고 그 방의 문이 닫겨있다면 연다.
                                if ((PortalCheck(i - 1, j) & 0b_0100) == 0b_0000)
                                {
                                    mapSquare[i - 1, j] = room.PortalMake(Room.roomHeight, Room.roomWidth, 1, mapSquare[i - 1, j]);
                                }
                            }
                        }
                    }
                    if ((roomportal & 0b_0100) == 0b_0100)
                    {
                        if (i + 1 >= mapSquare.GetLength(0))
                        {
                            mapSquare[i, j] = room.WallLineMake(Room.roomHeight, Room.roomWidth, 1, mapSquare[i, j]);
                        }
                        else
                        {
                            if (mapSquare[i + 1, j][0, 0] == 0)
                            {
                                mapSquare[i, j] = room.WallLineMake(Room.roomHeight, Room.roomWidth, 1, mapSquare[i, j]);
                            }
                            else
                            {
                                // 비어있지 않고 그 방의 문이 닫겨있다면 연다.
                                if ((PortalCheck(i + 1, j) & 0b_1000) == 0b_0000)
                                {
                                    mapSquare[i + 1, j] = room.PortalMake(Room.roomHeight, Room.roomWidth, 0, mapSquare[i + 1, j]);
                                }
                            }
                        }
                    }
                    if ((roomportal & 0b_0010) == 0b_0010)
                    {
                        if (j - 1 < 0)
                        {
                            mapSquare[i, j] = room.WallLineMake(Room.roomHeight, Room.roomWidth, 2, mapSquare[i, j]);
                        }
                        else
                        {
                            if (mapSquare[i, j - 1][0, 0] == 0)
                            {
                                mapSquare[i, j] = room.WallLineMake(Room.roomHeight, Room.roomWidth, 2, mapSquare[i, j]);
                            }
                            else
                            {
                                // 비어있지 않고 그 방의 문이 닫겨있다면 연다.
                                if ((PortalCheck(i, j - 1) & 0b_0001) == 0b_0000)
                                {
                                    mapSquare[i, j - 1] = room.PortalMake(Room.roomHeight, Room.roomWidth, 3, mapSquare[i, j - 1]);
                                }
                            }
                        }
                    }
                    if ((roomportal & 0b_0001) == 0b_0001)
                    {
                        if (j + 1 >= mapSquare.GetLength(0))
                        {
                            mapSquare[i, j] = room.WallLineMake(Room.roomHeight, Room.roomWidth, 3, mapSquare[i, j]);
                        }
                        else
                        {
                            if (mapSquare[i, j + 1][0, 0] == 0)
                            {
                                mapSquare[i, j] = room.WallLineMake(Room.roomHeight, Room.roomWidth, 3, mapSquare[i, j]);
                            }
                            else
                            {
                                // 비어있지 않고 그 방의 문이 닫겨있다면 연다.
                                if ((PortalCheck(i, j + 1) & 0b_0010) == 0b_0000)
                                {
                                    mapSquare[i, j + 1] = room.PortalMake(Room.roomHeight, Room.roomWidth, 2, mapSquare[i, j + 1]);
                                }
                            }
                        }
                    }

                }
            }
            // 방 생성이 끝나면 클리어 포탈 만들기
            for (int i = 0; i < mapSquare.GetLength(0); i++)
            {
                for (int j = 0; j < mapSquare.GetLength(1); j++)
                {
                    switch (PortalCheck(i, j))
                    {
                        case 0b_0001:
                        case 0b_0010:
                        case 0b_0100:
                        case 0b_1000:
                            round.Add(new int[2] { i, j });
                            break;
                        default:
                            break;
                    }
                }
            }
            roundYX = round[random.Next(0, round.Count)];
            switch (PortalCheck(roundYX[0], roundYX[1]))
            {
                case 0b_0001:
                    mapSquare[roundYX[0], roundYX[1]] = room.ClearPortalMake(Room.roomHeight, Room.roomWidth, 2, mapSquare[roundYX[0], roundYX[1]]);
                    break;
                case 0b_0010:
                    mapSquare[roundYX[0], roundYX[1]] = room.ClearPortalMake(Room.roomHeight, Room.roomWidth, 3, mapSquare[roundYX[0], roundYX[1]]);
                    break;
                case 0b_0100:
                    mapSquare[roundYX[0], roundYX[1]] = room.ClearPortalMake(Room.roomHeight, Room.roomWidth, 0, mapSquare[roundYX[0], roundYX[1]]);
                    break;
                case 0b_1000:
                    mapSquare[roundYX[0], roundYX[1]] = room.ClearPortalMake(Room.roomHeight, Room.roomWidth, 1, mapSquare[roundYX[0], roundYX[1]]);
                    break;
                default:
                    break;
            }
        }       // MapMake();

        // 포탈 위치 체크
        public uint PortalCheck(int Y, int X)
        {
            uint portal = 0b_0000;

            if (mapSquare[Y, X][0, Room.roomWidth / 2] == 3)
            {
                portal = portal | 0b_1000;
            }
            if (mapSquare[Y, X][Room.roomHeight - 1, Room.roomWidth / 2] == 4)
            {
                portal = portal | 0b_0100;
            }
            if (mapSquare[Y, X][Room.roomHeight / 2, 0] == 5)
            {
                portal = portal | 0b_0010;
            }
            if (mapSquare[Y, X][Room.roomHeight / 2, Room.roomWidth - 1] == 6)
            {
                portal = portal | 0b_0001;
            }
            return portal;
        }
        // 이전 방이랑 포탈 추가
        public void PortalPos(int posY, int posX, int pos, uint roomPortal)
        {

            if (pos == 0 && (roomPortal & 0b_0100) != 0b_0100)
            {
                mapSquare[posY, posX] = room.RoomPortal(mapSquare[posY, posX], 0b_0100);
            }
            if (pos == 1 && (roomPortal & 0b_1000) != 0b_1000)
            {
                mapSquare[posY, posX] = room.RoomPortal(mapSquare[posY, posX], 0b_1000);
            }
            if (pos == 2 && (roomPortal & 0b_0001) != 0b_0001)
            {
                mapSquare[posY, posX] = room.RoomPortal(mapSquare[posY, posX], 0b_0001);
            }
            if (pos == 3 && (roomPortal & 0b_0010) != 0b_0010)
            {
                mapSquare[posY, posX] = room.RoomPortal(mapSquare[posY, posX], 0b_0010);
            }
        }
    }
}
