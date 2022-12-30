using System;
using System.Security.Cryptography.X509Certificates;
using System.Timers;
using System.Threading.Tasks;

namespace CoinGetGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MovingPerson.CoinGame();
        }
    }
    internal class MovingPerson
    {
        static int CoinX = 0;
        static int CoinY = 0;
        static Random random;
        const int playboard_X = 16;
        const int playboard_Y = 16;
        static int[,] board;
        static string[,] playboard;
        static int score = 0;
        const int BLOCKCOUNT = 20;
        private static Timer cTimer;
        private static Timer bTimer;
        static int personX;
        static int personY;

        public static void CoinGame()
        {
            /**
             * 22.12.30 과제
             * 보드를 돌아다니는 사람
             * w,a,s,d를 입력받아 빈 곳을 이동하는 프로그램을 작성
             * - 사람은 빈 곳으로 이동할 수 있음
             * - 사람은 벽을 넘을 수 없음
             * 
             * + 랜덤한 빈 곳에서 코인 생성
             * + 랜덤한 빈 곳에서 바나나 생성
             * + 랜덤한 빈 곳에서 2개의 벽 생성
             */

            // { 보드 생성
            playboard = new string[playboard_X, playboard_Y];
            board = new int[playboard_X, playboard_Y];
            // 현 위치
            personX = playboard_X / 2;
            personY = playboard_Y / 2;
            newBoard();
            CoinMake();

            for (int i = 0; i < BLOCKCOUNT; i++)
            {
                Block_();
            }
            playboardIn(personY,personX);
            // } 보드 생성
            // 타이머 돌려서 생성
            cTimer = new Timer(4000);
            cTimer.Elapsed += CoinMake;
            cTimer.Enabled = true;

            bTimer = new Timer(8000);
            bTimer.Elapsed += BlockMake;
            bTimer.Enabled = true;


            playboardPrint();

            // { 이동해도 꺼지지 않음
            bool end = false;
            while (!end)
            {

                ConsoleKeyInfo checkKey;
                checkKey = Console.ReadKey(true);
                switch (checkKey.Key)
                {
                    case ConsoleKey.W:
                        if (personY - 1 == 0) { break; }
                        if (playboard[personY-1,personX] == "■") { break; }
                        personY = personY - 1;
                        break;
                    case ConsoleKey.A:
                        if (personX - 1 == 0) { break; }
                        if (playboard[personY, personX - 1] == "■") { break; }
                        personX = personX - 1;
                        break;
                    case ConsoleKey.S:
                        if (personY + 1 == playboard_Y - 1) { break; }
                        if (playboard[personY+1, personX] == "■") { break; }
                        personY = personY + 1;
                        break;
                    case ConsoleKey.D:
                        if (personX + 1 == playboard_X - 1) { break; }
                        if (playboard[personY, personX + 1] == "■") { break; }
                        personX = personX + 1;
                        break;
                    default:
                        break;
                }
                BoardMove();
                playboardIn(personY, personX);
                if(personY == CoinY && personX == CoinX)
                CoinGet();
                
                playboardPrint();
            }
            
            // } 이동해도 꺼지지 않음


        }

        // { 보드 출력
        public static void playboardPrint()
        {
            Console.Clear();
            for (int y = 0; y < playboard_Y; y++)
            {
                for (int x = 0; x < playboard_X; x++)
                {
                    
                    Console.Write(playboard[y, x]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("현재 점수 : "+score);

        }
        // } 보드 출력

        // { 보드 내용물 배치
        public static void playboardIn(int personY, int personX)
        {

            for (int y = 0; y < playboard_Y; y++)
            {
                for (int x = 0; x < playboard_X; x++)
                {
                    if (board[y, x] == 8)
                    {
                        playboard[y, x] = "8 ";
                    }
                    else if (board[y, x] == 1)
                    {
                        playboard[y, x] = "■";
                    }
                    else if (board[y, x] == 2)
                    {
                        playboard[y, x] = "$ ";
                    }
                    else
                    {
                        playboard[y, x] = ". ";
                    }
                }
            }   // loop : 보드 내용물 정렬


        }
        // } 보드 내용물 배치

        // { 코인 획득시 점수 상승
        public static void CoinGet()
        {
            score++;
            CoinMake();
        }
        // } 코인 획득시 점수 상승

        // { 지뢰 획득시 게임 오버
        public static void GameOver()
        {

        }
        // } 코인 획득시 점수 상승


        // { 보드 초기화
        public static void BoardMove()
        {

            for (int y = 0; y < playboard_Y; y++)
            {
                for (int x = 0; x < playboard_X; x++)
                {
                    if (y == personY && x == personX)
                    {
                        board[y, x] = 8;
                        continue;
                    }
                    if (y == playboard_Y - 1 || y == 0)
                    {
                        board[y, x] = 1;
                        continue;
                    }
                    if (x == playboard_X - 1 || x == 0)
                    {
                        board[y, x] = 1;
                        continue;
                    }
                    if (y == CoinY && x == CoinX)
                    {

                        board[y, x] = 2;
                        continue;
                    }
                    if (board[y,x] == 1)
                    {
                        continue;
                    }
                    board[y, x] = 0;
                }
            }
        }
        // } 보드 초기화
        // { 보드 초기화
        public static void newBoard()
        {

            for (int y = 0; y < playboard_Y; y++)
            {
                for (int x = 0; x < playboard_X; x++)
                {
                    if (y == personY && x == personX)
                    {
                        board[y, x] = 8;
                        continue;
                    }
                    if (y == playboard_Y - 1 || y == 0)
                    {
                        board[y, x] = 1;
                        continue;
                    }
                    if (x == playboard_X - 1 || x == 0)
                    {
                        board[y, x] = 1;
                        continue;
                    }
                    if (y == CoinY && x == CoinX)
                    {

                        board[y, x] = 2;
                        continue;
                    }
                    board[y, x] = 0;
                }
            }
        }
        // } 보드 초기화
        // { 보드내에 코인 랜덤 생성
        public static void CoinMake()
        {
            // 코인 랜덤 포지션
            random = new Random();
            CoinX = random.Next(1, playboard_X-1);
            CoinY = random.Next(1, playboard_Y-1);

            // 그 자리에 다른 것이 있는지 체크
            while (board[CoinY,CoinX] != 0)
            {
                CoinX = random.Next(1, playboard_X - 1);
                CoinY = random.Next(1, playboard_Y - 1);
            }
            // 없으면 포지션 확정
            board[CoinY, CoinX] = 2;
            BoardMove();
            playboardIn(personY, personX);
            playboardPrint();
        }
        public static void CoinMake(object sender, ElapsedEventArgs e)
        {
            // 코인 랜덤 포지션
            random = new Random();
            CoinX = random.Next(1, playboard_X-1);
            CoinY = random.Next(1, playboard_Y-1);

            // 그 자리에 다른 것이 있는지 체크
            while (board[CoinY,CoinX] != 0)
            {
                CoinX = random.Next(1, playboard_X - 1);
                CoinY = random.Next(1, playboard_Y - 1);
            }
            // 없으면 포지션 확정
            board[CoinY, CoinX] = 2;
            BoardMove();
            playboardIn(personY, personX);
            playboardPrint();
        }
        // } 보드내에 코인 랜덤 생성

        // { 보드내에 벽 랜덤 생성
        public static void Block_()
        {
            // 벽 랜덤 포지션
            random = new Random();
            int blockX = random.Next(1, playboard_X - 1);
            int blockY = random.Next(1, playboard_Y - 1);

            // 그 자리에 다른 것이 있는지 체크
            while (board[blockY, blockX] != 0)
            {
                blockX = random.Next(1, playboard_X - 1);
                blockY = random.Next(1, playboard_Y - 1);
            }
            // 없으면 포지션 확정
            board[blockY, blockX] = 1;
        }
        public static void BlockMake(Object source, ElapsedEventArgs e)
        {
            Task.Delay(300).Wait();
            newBoard();
            for (int i = 0; i < BLOCKCOUNT; i++)
            {
                Block_();
            }
            playboardIn(personY, personX);
            playboardPrint();
        }
        // } 보드내에 벽 랜덤 생성


        // { 보드내에 지뢰 랜덤 생성 후 출력
        // 지뢰 개수 상수
        // 지뢰 포지션 배열
        // 일정 시간마다 위치 변화
        // 그 자리에 다른 것이 있는지 체크
        // 없으면 포지션 확정
        // } 보드내에 지뢰 랜덤 생성 후 출력
    }
}