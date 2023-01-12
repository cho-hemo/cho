using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WhatIsInterface
{
    public class Poker
    {
        public bool isGameEnd = false;
        public bool isWin = false;
        /**
         * 포커 게임
         * 컴퓨터가 5장의 카드 드로우(플레이어가 볼 수 있음)
         * 플레이어도 5장의 카드 드로우
         * 플레이어 베팅 (0~최대)
         * 컴퓨터는 2장의 카드를 추가로 받는다. -> 총 7장의 카드 보유
         * 플레이어는 2장의 카드 교체 가능(카드 1장 교체 가능 횟수가 최대 2회)
         * 모든 액션이 끝난 후 결과 체크
         * 플레이어가 이기면 2배/지면 베팅 금액 로스트
         * 100000 포인트 이상을 얻거나 0 포인트 이하가 되면 게임 종료
         * 시작 포인트는 10000포인트
         * 노페어, 원페어, 투페어, 트리플, 포카드, 플러쉬, 스트레이트
         * (하드) 시간 남으면 마운틴, 백스트레이트, 로티플, 스티플, 풀하우스
         */

        // 게임 본판
        public void PokerGame()
        {
            int newDraw = 0;
            int roundWin = 0; // 1은 승리 2는 패배 3은 비김
            CardSet cardSet = new CardSet();
            PokerCheck pokerCheck = new PokerCheck();
            ConsoleKeyInfo consoleKey;
            // 플레이어 포인트 세팅
            cardSet.PlayerPoint();
            cardSet.SetupTrumpCard();
            // 종료시까지 계속
            while (!isGameEnd)
            {
                Console.Clear();
                cardSet.comHand = new List<int>();
                cardSet.comhandNum = new List<int>();
                cardSet.comhandMark = new List<int>();
                cardSet.playerHand = new List<int>();
                cardSet.playerhandNum = new List<int>();
                cardSet.playerhandMark = new List<int>();
                // 카드 섞기
                cardSet.ShuffleCards();
                Console.WriteLine("===============================================");
                Console.WriteLine("\t\t그린필드 포커");
                Console.WriteLine("===============================================");
                Console.WriteLine("\t컴퓨터가 5장을 가져왔습니다.");
                // 컴퓨터 5장 드로우
                for (int i = 0; i < 5; i++)
                {
                    cardSet.ComDraw();
                }

                // 컴퓨터 손패 출력
                cardSet.comHandPrint();
                // 플레이어 5장 드로우
                Console.WriteLine("\t5장을 뽑으려면 아무 키나 눌러주세요.");
                consoleKey = Console.ReadKey();
                for (int i = 0; i < 5; i++)
                {
                    cardSet.PlayerDraw();
                }
                // 플레이어 손패 출력
                cardSet.PlayerHandPrint();
                // 플레이어 베팅
                cardSet.UserBet();

                Console.Clear();
                // 컴퓨터 2장 드로우
                Console.WriteLine("\t컴퓨터가 2장을 추가로 가져왔습니다.");
                cardSet.ComDraw();
                cardSet.ComDraw();
                // 컴퓨터 손패 줄력
                cardSet.comHandPrint();
                // 플레이어 손패 출력
                Console.WriteLine("\t플레이어의 패");
                cardSet.PlayerHandPrint();
                // 플레이어 카드 순서 출력
                Console.WriteLine("    1          2          3          4          5");
                // 플레이어 교체할까 질문
                Console.WriteLine("\t교체하려면 Y를 눌러주세요.");
                consoleKey = Console.ReadKey();
                // 플레이어 교체(최대 2회)
                while (consoleKey.Key == ConsoleKey.Y)
                {
                    cardSet.PlayerNewDraw();
                    newDraw++;
                    if (newDraw == 2)
                    {
                        break;
                    }
                    Console.WriteLine("    1          2          3          4          5");
                    Console.Write("\t더 교체하려면 Y를 눌러주세요.");
                    consoleKey = Console.ReadKey();
                }
                newDraw = 0;
                Console.WriteLine("\t결과를 보시려면 아무 키나 눌러주세요.");
                consoleKey = Console.ReadKey();

                // 결과 확인
                Console.Clear();

                Console.WriteLine("===============================================");
                Console.WriteLine("\t\t그린필드 포커");
                Console.WriteLine("===============================================");
                Console.WriteLine("\t컴퓨터의 패");
                // 컴퓨터 족보 체크
                PokerCheck poker = new PokerCheck();
                int[] comScore;
                // 0 5장 무늬가 같은지 체크 
                poker.AllMarkCheck(cardSet.comhandNum, cardSet.comhandMark);
                // 1 숫자가 1,10,11,12,13인지 체크
                poker.RoyalCheck(cardSet.comhandNum, cardSet.comhandMark);
                // 2 1, 2, 3, 4, 5 인지 체크 
                poker.BackCheck(cardSet.comhandNum, cardSet.comhandMark);
                // 3 숫자가 이어지는지 체크
                poker.JulCheck(cardSet.comhandNum, cardSet.comhandMark);
                // 4 숫자가 같은 것이 4장
                poker.FourCheck(cardSet.comhandNum, cardSet.comhandMark);
                // 5 숫자가 같은 것이 3장 
                poker.TripleCheck(cardSet.comhandNum, cardSet.comhandMark);
                // 6 숫자가 같은 것이 2장+2장
                poker.TwoPairCheck(cardSet.comhandNum, cardSet.comhandMark);
                // 7 숫자가 같은 것이 2장
                poker.OnePairCheck(cardSet.comhandNum, cardSet.comhandMark);
                // 비트 연산
                comScore = poker.bitSetup(poker.bit, cardSet.comhandNum, cardSet.comhandMark);


                Console.WriteLine("\t플레이어의 패");
                // 플레이어 족보 체크
                poker = new PokerCheck();
                int[] playerScore;
                // 0 5장 무늬가 같은지 체크 
                poker.AllMarkCheck(cardSet.playerhandNum, cardSet.playerhandMark);
                // 1 숫자가 1,10,11,12,13인지 체크
                poker.RoyalCheck(cardSet.playerhandNum, cardSet.playerhandMark);
                // 2 1, 2, 3, 4, 5 인지 체크 
                poker.BackCheck(cardSet.playerhandNum, cardSet.playerhandMark);
                // 3 숫자가 이어지는지 체크
                poker.JulCheck(cardSet.playerhandNum, cardSet.playerhandMark);
                // 4 숫자가 같은 것이 4장
                poker.FourCheck(cardSet.playerhandNum, cardSet.playerhandMark);
                // 5 숫자가 같은 것이 3장 
                poker.TripleCheck(cardSet.playerhandNum, cardSet.playerhandMark);
                // 6 숫자가 같은 것이 2장+2장
                poker.TwoPairCheck(cardSet.playerhandNum, cardSet.playerhandMark);
                // 7 숫자가 같은 것이 2장
                poker.OnePairCheck(cardSet.playerhandNum, cardSet.playerhandMark);
                // 비트 연산
                playerScore = poker.bitSetup(poker.bit, cardSet.playerhandNum, cardSet.playerhandMark);

                // 양측 결과 비교
                for (int i = 0; i < comScore.Length; i++)
                {
                    if (roundWin == 3 || roundWin == 0)
                    {
                        if (i == 1 || i == 2)
                        {

                            if (comScore[i] > playerScore[i])
                            {
                                if (playerScore[i] == 1)
                                    roundWin = 1;
                                else
                                    roundWin = 2;
                            }
                            else if (playerScore[i] > comScore[i])
                            {
                                if (comScore[i] == 1)
                                    roundWin = 2;
                                else
                                    roundWin = 1;
                            }
                            else
                            {
                                roundWin = 3;
                            }
                        }
                        else
                        {


                            if (comScore[i] < playerScore[i])
                            {
                                    roundWin = 2;
                            }
                            else if (playerScore[i] < comScore[i])
                            {
                                    roundWin = 1;
                            }
                            else
                            {
                                roundWin = 3;
                            }
                        }
                    }
                    else
                        break;
                }

                // 승패 보상 및 재도전 아무키나

                isGameEnd = cardSet.RoundCheck(roundWin);
                Console.WriteLine("\t아무 키나 눌러주세요.");
                consoleKey = Console.ReadKey();
            }

        }


    } // class Poker

    // 카드 세팅
    class CardSet
    {
        // 셋팅된 카드
        private int[] trumpCardSet;
        // 카드 기호
        public static string[] trumpCardMark = new string[4] { "♠", "◆", "♥", "♣" };
        // 카드 숫자
        private int cardNum = 0;
        // 플레이어 보유 포인트
        private int userPoint = 0;
        // 플레이어 배팅 포인트
        private int betPoint = 0;
        // 현재 사용한 카드 체크
        private int cardCount = 0;
        // 컴퓨터 족보 순위
        public int comScore = 0;
        // 플레이어 족보 순위
        public int playerScore = 0;

        // 컴퓨터 손패 리스트 생성
        public List<int> comHand = new List<int>();
        public List<int> comhandNum = new List<int>();
        public List<int> comhandMark = new List<int>();
        // 플레이어 손패 리스트 생성
        public List<int> playerHand = new List<int>();
        public List<int> playerhandNum = new List<int>();
        public List<int> playerhandMark = new List<int>();

        public void PlayerPoint()
        {
            userPoint = 10000;
        }
        // 카드 전체 셋팅
        public void SetupTrumpCard()
        {
            trumpCardSet = new int[52];
            for (int i = 0; i < trumpCardSet.Length; i++)
            {
                trumpCardSet[i] = i + 1;
            }       // loop : 카드를 셋업하는 루프

        }       // SetupTrumpCard()

        // 카드 전체 섞기
        public void ShuffleCards()
        {
            for (int i = 0; i < 200; i++)
            {
                trumpCardSet = ShuffleOnce(trumpCardSet);
            }
            cardCount = 0;
        }       // ShuffleCards()


        // 카드 하나 섞기
        private int[] ShuffleOnce(int[] Nums)
        {
            Random random = new Random();
            int sourceIndex = random.Next(0, Nums.Length);
            int destIndex = random.Next(0, Nums.Length);

            int temp = Nums[sourceIndex];
            Nums[sourceIndex] = Nums[destIndex];
            Nums[destIndex] = temp;

            return Nums;
        }       // ShuffleOnce()

        // 컴퓨터 드로우
        public void ComDraw()
        {
            // 리스트에 드로우한 카드 넣기
            comHand.Add(trumpCardSet[cardCount]);
            cardNum = trumpCardSet[cardCount] % 13;
            if (cardNum == 0)
            {
                cardNum = 13;
            }
            comhandNum.Add(cardNum);
            comhandMark.Add((trumpCardSet[cardCount] - 1) / 13);
            cardCount++;

        }
        // 플레이어 드로우
        public void PlayerDraw()
        {
            // 리스트에 드로우한 카드 넣기
            playerHand.Add(trumpCardSet[cardCount]);
            cardNum = trumpCardSet[cardCount] % 13;
            if (cardNum == 0)
            {
                cardNum = 13;
            }
            playerhandNum.Add(cardNum);
            playerhandMark.Add((trumpCardSet[cardCount] - 1) / 13);
            cardCount++;
        }

        // 플레이어 베팅
        public void UserBet()
        {
            Console.Write("\n얼마의 포인트를 걸겠습니까? -> ");
            int.TryParse(Console.ReadLine(), out betPoint);
            while (userPoint < betPoint || betPoint < 0)
            {
                Console.Write("보유 포인트 범위 내로 걸어주세요. -> ");
                int.TryParse(Console.ReadLine(), out betPoint);
            }
            Console.WriteLine();
        }

        // 플레이어 카드 교체
        public void PlayerNewDraw()
        {
            Console.WriteLine();
            // 어떤 카드를 교체하시겠습니까?
            Console.Write("어떤 카드를 교체하시겠습니까? -> ");
            // 플레이어의 입력 받기
            int changeNum = 0;
            ConsoleKeyInfo consoleKey = Console.ReadKey();
            switch (consoleKey.Key)
            {
                case ConsoleKey.D1:
                    changeNum = 1;
                    break;
                case ConsoleKey.D2:
                    changeNum = 2;
                    break;
                case ConsoleKey.D3:
                    changeNum = 3;
                    break;
                case ConsoleKey.D4:
                    changeNum = 4;
                    break;
                case ConsoleKey.D5:
                    changeNum = 5;
                    break;
                default:
                    changeNum = 0;
                    break;
            }
            while (changeNum == 0)
            {
                Console.WriteLine("다시 입력해주세요. -> ");
                consoleKey = Console.ReadKey();
                switch (consoleKey.Key)
                {
                    case ConsoleKey.D1:
                        changeNum = 1;
                        break;
                    case ConsoleKey.D2:
                        changeNum = 2;
                        break;
                    case ConsoleKey.D3:
                        changeNum = 3;
                        break;
                    case ConsoleKey.D4:
                        changeNum = 4;
                        break;
                    case ConsoleKey.D5:
                        changeNum = 5;
                        break;
                    default:
                        changeNum = 0;
                        break;
                }
            }
            playerHand.RemoveAt(changeNum - 1);
            playerhandNum.RemoveAt(changeNum - 1);
            playerhandMark.RemoveAt(changeNum - 1);
            PlayerDraw();
            Console.WriteLine();
            PlayerHandPrint();

        }


        // 컴퓨터 손패 출력

        public void comHandPrint()
        {
            string line0 = "";
            string line1 = "";
            string line2 = "";
            string line3 = "";
            string line4 = "";
            string line5 = "";
            string num = "";
            string mark = "";

            for (int i = 0; i < comHand.Count; i++)
            {
                num = comhandNum[i].ToString();
                mark = trumpCardMark[comhandMark[i]];
                line0 = line0 + " ------    ";
                switch (num)
                {
                    case "11":
                        num = "J";
                        break;
                    case "12":
                        num = "Q";
                        break;
                    case "13":
                        num = "K";
                        break;
                    default:
                        break;
                }
                if (num == "10")
                {
                    line1 = line1 + "|" + mark + num + "  |   ";
                    line5 = line5 + "|  " + num + mark + "|   ";
                }
                else
                {
                    line1 = line1 + "|" + mark + num + "   |   ";
                    line5 = line5 + "|   " + num + mark + "|   ";
                }
                line2 = line2 + "|      |   ";
                line3 = line3 + "|  " + mark + "  |   ";
                line4 = line4 + "|      |   ";
            }
            Console.WriteLine(line0);
            Console.WriteLine(line1);
            Console.WriteLine(line2);
            Console.WriteLine(line3);
            Console.WriteLine(line4);
            Console.WriteLine(line5);
            Console.WriteLine(line0);
        }

        // 플레이어 손패 출력
        public void PlayerHandPrint()
        {
            string line0 = "";
            string line1 = "";
            string line2 = "";
            string line3 = "";
            string line4 = "";
            string line5 = "";
            string num = "";
            string mark = "";

            for (int i = 0; i < playerHand.Count; i++)
            {
                num = playerhandNum[i].ToString();
                mark = trumpCardMark[playerhandMark[i]];
                line0 = line0 + " ------    ";
                switch (num)
                {
                    case "11":
                        num = "J";
                        break;
                    case "12":
                        num = "Q";
                        break;
                    case "13":
                        num = "K";
                        break;
                    default:
                        break;
                }
                if (num == "10")
                {
                    line1 = line1 + "|" + mark + num + "  |   ";
                    line5 = line5 + "|  " + num + mark + "|   ";
                }
                else
                {
                    line1 = line1 + "|" + mark + num + "   |   ";
                    line5 = line5 + "|   " + num + mark + "|   ";
                }
                line2 = line2 + "|      |   ";
                line3 = line3 + "|  " + mark + "  |   ";
                line4 = line4 + "|      |   ";
            }
            Console.WriteLine(line0);
            Console.WriteLine(line1);
            Console.WriteLine(line2);
            Console.WriteLine(line3);
            Console.WriteLine(line4);
            Console.WriteLine(line5);
            Console.WriteLine(line0);
        }

        // 베팅 성패 체크
        public bool RoundCheck(int roundWin)
        {
            if (roundWin == 2)
            {
                Console.WriteLine("컴퓨터의 승리입니다.");
                userPoint = userPoint - betPoint;
            }
            else if (roundWin == 1)
            {
                Console.WriteLine("플레이어의 승리입니다.");
                userPoint = userPoint + betPoint;
            }
            else
            {
                Console.WriteLine("승리자가 없습니다.");
            }
            betPoint = 0;
            Console.WriteLine($"플레이어의 포인트 : {userPoint}");
            if (userPoint >= 100000)
            {
                Console.WriteLine("플레이어의 승리입니다!");
                return true;
            }
            else if (userPoint <= 0)
            {
                Console.WriteLine("플레이어의 패배입니다.");
                return true;
            }
            else
            {
                return false;
            }
        }


    }       // class CardSet

    public class PokerCheck
    {
        // 족보 체크
        private int markCheck = 0;
        private int numCheck = 0;
        public uint bit = 0b_0000_0000;
        private int indexNum = 0;
        private int sortIndex = 0;
        public int[] score = new int[5];
        private List<int> handSortNum = new List<int>();
        private List<int> handSortNum2 = new List<int>();
        private List<int> handSortNum3 = new List<int>();
        private List<int> handSortNum4 = new List<int>();
        private List<int> handSortNum5 = new List<int>();
        private List<int> sortNumList = new List<int>();
        private List<int> sortMarkList = new List<int>();
        private List<int> checkList = new List<int>();
        private List<int> sortNum = new List<int>();


        // 0 5장 무늬가 같은지 체크 
        public void AllMarkCheck(List<int> handNum, List<int> handMark)
        {
            // 0 5장 무늬가 같은지 체크 
            for (int i = 0; i < handMark.Count; i++)
            {
                checkList = handMark.FindAll(element => element == handMark[i]);
                if (checkList.Count >= 5)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        handSortNum.Add(handMark.FindIndex(indexNum, element => element == handMark[i]));
                        indexNum = handSortNum[j] + 1;
                    }
                    bit = bit | 0b_0000_0001;
                    break;
                }
            }
        }
        // 1 숫자가 1,10,11,12,13인지 체크 
        public void RoyalCheck(List<int> handNum, List<int> handMark)
        {
            int[] straight = new int[5];
            numCheck = 0;
            // 2 1, 2, 3, 4, 5 인지 체크 
            if (handSortNum.Count >= 5)
            {
                for (int i = 0; i < handSortNum.Count; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        switch (handNum[handSortNum[i]])
                        {
                            case 1:
                                straight[0] = handNum[handSortNum[i]];
                                break;
                            case 13:
                                straight[1] = handNum[handSortNum[i]];
                                break;
                            case 12:
                                straight[2] = handNum[handSortNum[i]];
                                break;
                            case 11:
                                straight[3] = handNum[handSortNum[i]];
                                break;
                            case 10:
                                straight[4] = handNum[handSortNum[i]];
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < handNum.Count; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        switch (handNum[i])
                        {
                            case 1:
                                straight[0] = handNum[i];
                                break;
                            case 13:
                                straight[1] = handNum[i];
                                break;
                            case 12:
                                straight[2] = handNum[i];
                                break;
                            case 11:
                                straight[3] = handNum[i];
                                break;
                            case 10:
                                straight[4] = handNum[i];
                                break;
                            default:
                                break;
                        }
                    }

                }
            }
            for (int i = 0; i < straight.Length; i++)
            {
                if (straight[i] != 0)
                {
                    numCheck++;
                }
            }
            if (numCheck >= 5)
            {
                bit = bit | 0b_0000_0010;
            }
        }
        // 2 1, 2, 3, 4, 5 인지 체크 
        public void BackCheck(List<int> handNum, List<int> handMark)
        {
            int[] straight = new int[5];
            numCheck = 0;
            // 2 1, 2, 3, 4, 5 인지 체크 
            if (handSortNum.Count >= 5)
            {
                for (int i = 0; i < handSortNum.Count; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (handNum[handSortNum[i]] == j)
                        {
                            straight[j] = handNum[handSortNum[i]];
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < handNum.Count; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (handNum[i] == j)
                        {
                            straight[j] = handNum[i];
                        }
                    }
                }
            }
            for (int i = 0; i < straight.Length; i++)
            {
                if (straight[i] != 0)
                {
                    numCheck++;
                }
            }
            if (numCheck == 5)
            {
                bit = bit | 0b_0000_0100;
            }

        }
        // 3 숫자가 이어지는지 체크 
        public void JulCheck(List<int> handNum, List<int> handMark)
        {
            checkList = new List<int>();
            numCheck = 0;
            // 3 숫자가 이어지는지 체크 
            if (handSortNum.Count >= 5)
            {
                for (int i = 0; i < handSortNum.Count; i++)
                {
                    checkList.Add(handNum[handSortNum[i]]);
                }
                checkList.Sort();
                for (int i = 0; i < checkList.Count - 1; i++)
                {
                    for (int j = 1; j < checkList.Count; j++)
                    {
                        if (i + 4 < checkList.Count)
                        {

                            if (checkList[i + j] == checkList[i] + j)
                            {
                                numCheck++;
                            }
                            else
                            {
                                numCheck = 0;
                                break;
                            }
                        }
                        else
                        {
                            numCheck = 0;
                            break;
                        }
                    }
                }
                if (numCheck >= 4)
                {
                    bit = bit | 0b_0000_1000;
                }
            }
            else
            {
                for (int i = 0; i < handNum.Count; i++)
                {
                    checkList.Add(handNum[i]);
                }
                checkList.Sort();
                for (int i = 0; i < checkList.Count - 1; i++)
                {
                    for (int j = 1; j < checkList.Count; j++)
                    {
                        if (i + 4 < checkList.Count)
                        {

                            if (checkList[i + j] == checkList[i] + j)
                            {
                                numCheck++;
                            }
                            else
                            {
                                numCheck = 0;
                                break;
                            }
                        }
                        else
                        {
                            numCheck = 0;
                            break;
                        }
                    }
                }
                if (numCheck >= 5)
                {
                    bit = bit | 0b_0000_1000;
                }
            }
        }
        // 4 숫자가 같은 것이 4장 
        public void FourCheck(List<int> handNum, List<int> handMark)
        {
            checkList = new List<int>();
            indexNum = 0;
            // 4 숫자가 같은 것이 4장 

            for (int i = 0; i < handNum.Count; i++)
            {
                checkList = handNum.FindAll(element => element == handNum[i]);
                if (checkList.Count == 4)
                {
                    for (int j = 0; j < 4; j++)
                    {

                        handSortNum2.Add(handNum.FindIndex(indexNum, element => element == handNum[i]));
                        indexNum = handSortNum2[j] + 1;
                    }
                    bit = bit | 0b_0001_0000;
                    break;
                }

            }
        }
        // 5 숫자가 같은 것이 3장 
        public void TripleCheck(List<int> handNum, List<int> handMark)
        {
            sortIndex = 0;
            indexNum = 0;
            checkList = new List<int>();
            // 5 숫자가 같은 것이 3장 

            for (int i = 0; i < handNum.Count; i++)
            {
                checkList = handNum.FindAll(element => element == handNum[i]);
                if (checkList.Count == 3)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        handSortNum3.Add(handNum.FindIndex(indexNum, element => element == handNum[i]));
                        if (handSortNum3[j] + 1 < handNum.Count)
                        {
                            indexNum = handSortNum3[j] + 1;
                        }
                        else
                            break;
                    }
                    bit = bit | 0b_0010_0000;
                    break;
                }

            }
        }
        // 6 숫자가 같은 것이 2장+2장 
        public void TwoPairCheck(List<int> handNum, List<int> handMark)
        {
            checkList = new List<int>();
            numCheck = 0;
            indexNum = 0;
            // 6 숫자가 같은 것이 2장+2장 

            for (int i = 0; i < handNum.Count; i++)
            {
                checkList = handNum.FindAll(element => element == handNum[i]);
                if (checkList.Count == 2)
                {
                    handSortNum4.Add(handNum.FindIndex(i, element => element == handNum[i]));
                    numCheck++;
                }

                if (numCheck == 4)
                {
                    bit = bit | 0b_0100_0000;
                    break;
                }

            }
        }
        // 7 숫자가 같은 것이 2장
        public void OnePairCheck(List<int> handNum, List<int> handMark)
        {
            checkList = new List<int>();
            numCheck = 0;
            indexNum = 0;
            // 7 숫자가 같은 것이 2장

            for (int i = 0; i < handNum.Count; i++)
            {
                checkList = handNum.FindAll(element => element == handNum[i]);
                if (checkList.Count == 2)
                {
                    handSortNum5.Add(handNum.FindIndex(i, element => element == handNum[i]));
                    numCheck++;
                }
                if (numCheck == 2)
                {
                    bit = bit | 0b_1000_0000;
                    break;
                }
            }
            checkList = new List<int>();

        }

        // 비트 셋업 및 정렬
        public int[] bitSetup(uint bit, List<int> handNum, List<int> handMark)
        {
            uint bitcheck = bit & 0b_0000_1111;

            if (bitcheck != 0b_0000_0000)
            {
                bit = bitcheck;
            }

            switch (bit)
            {
                // 0 : 족보, 1 : 첫조합 끝숫자, 2: 두조합 끝숫자, 3: 첫조합 마크, 4: 두조합 마크
                case 0b_0000_0011:
                    RotiflSort(handNum, handMark, handSortNum);
                    Console.WriteLine();
                    Console.WriteLine("로얄 스트레이트 플러시!");
                    Console.WriteLine();
                    score[0] = 0;
                    score[1] = sortNumList[4];
                    score[2] = 0;
                    score[3] = sortMarkList[0];
                    score[4] = 0;
                    break;
                case 0b_0000_0101:
                case 0b_0000_1101:
                    BacktiflSort(handNum, handMark, handSortNum);
                    Console.WriteLine();
                    Console.WriteLine("백 스트레이트 플러시!");
                    Console.WriteLine();
                    score[0] = 1;
                    score[1] = sortNumList[4];
                    score[2] = 0;
                    score[3] = sortMarkList[0];
                    score[4] = 0;
                    break;
                case 0b_0000_1001:
                    StiflSort(handNum, handMark, handSortNum);
                    Console.WriteLine();
                    Console.WriteLine("스트레이트 플러시!");
                    Console.WriteLine();
                    score[0] = 2;
                    score[1] = sortNumList[4];
                    score[2] = 0;
                    score[3] = sortMarkList[0];
                    score[4] = 0;
                    break;
                case 0b_0001_0000:
                    FourCardSort(handNum, handMark, handSortNum);
                    Console.WriteLine();
                    Console.WriteLine("포 카드!");
                    Console.WriteLine();
                    score[0] = 3;
                    score[1] = sortNumList[3];
                    score[2] = 0;
                    score[3] = 0;
                    score[4] = 0;
                    break;
                case 0b_1010_0000:
                    FullHouseSort(handNum, handMark, handSortNum3, handSortNum5);
                    Console.WriteLine();
                    Console.WriteLine("풀 하우스!");
                    Console.WriteLine();
                    score[0] = 4;
                    score[1] = sortNumList[2];
                    score[2] = sortNumList[4];
                    score[3] = sortMarkList[0];
                    score[4] = sortMarkList[3];
                    break;
                case 0b_0000_0001:
                    StiflSort(handNum, handMark, handSortNum);
                    Console.WriteLine();
                    Console.WriteLine("플러시!");
                    Console.WriteLine();
                    score[0] = 5;
                    score[1] = sortNumList[4];
                    score[2] = 0;
                    score[3] = sortMarkList[0];
                    score[4] = 0;
                    break;
                case 0b_0000_0010:
                    MountainSort(handNum, handMark);
                    Console.WriteLine();
                    Console.WriteLine("마운틴!");
                    Console.WriteLine();
                    score[0] = 6;
                    score[1] = sortNumList[4];
                    score[2] = 0;
                    score[3] = 0;
                    score[4] = 0;
                    break;
                case 0b_0000_0100:
                    BackJulSort(handNum, handMark);
                    Console.WriteLine();
                    Console.WriteLine("백 스트레이트!");
                    Console.WriteLine();
                    score[0] = 7;
                    score[1] = sortNumList[4];
                    score[2] = 0;
                    score[3] = 0;
                    score[4] = 0;
                    break;
                case 0b_0000_1000:
                    JulSort(handNum, handMark);
                    Console.WriteLine();
                    Console.WriteLine("스트레이트!");
                    Console.WriteLine();
                    score[0] = 8;
                    score[1] = sortNumList[4];
                    score[2] = 0;
                    score[3] = 0;
                    score[4] = 0;
                    break;
                case 0b_0010_0000:
                case 0b_0110_0000:
                case 0b_1110_0000:
                    FourCardSort(handNum, handMark, handSortNum3);
                    Console.WriteLine();
                    Console.WriteLine("트리플!");
                    Console.WriteLine();
                    score[0] = 9;
                    score[1] = sortNumList[2];
                    score[2] = 0;
                    score[3] = 0;
                    score[4] = 0;
                    break;
                case 0b_0100_0000:
                case 0b_1100_0000:
                    TwoPairSort(handNum, handMark, handSortNum4);
                    Console.WriteLine();
                    Console.WriteLine("투 페어!");
                    Console.WriteLine();
                    score[0] = 10;
                    score[1] = sortNumList[1];
                    score[2] = sortNumList[3];
                    score[3] = 0;
                    score[4] = 0;
                    break;
                case 0b_1000_0000:
                    FourCardSort(handNum, handMark, handSortNum5);
                    Console.WriteLine();
                    Console.WriteLine("원 페어!");
                    Console.WriteLine();
                    score[0] = 11;
                    score[1] = sortNumList[1];
                    score[2] = 0;
                    score[3] = 0;
                    score[4] = 0;
                    break;
                case 0b_0000_0000:
                    TopSort(handNum, handMark);
                    Console.WriteLine();
                    Console.WriteLine("탑");
                    Console.WriteLine();
                    score[0] = 12;
                    score[1] = 0;
                    score[2] = 0;
                    score[3] = 0;
                    score[4] = 0;
                    break;
                default:
                    break;
            }

            return score;
            /** 
            * { (앞 4자리 상관없음)
            * 0000 0011 = 로티플
            *  + 모양 체크
            * 0000 0101 = 백티플
            *  + 모양 체크
            * 0000 1001 = 스티플
            *  + 숫자 시작자리 체크
            *  + 모양 체크
            * }
            * {(뒷 4자리 없음)
            * 0001 0000 = 포카드
            *  + 숫자 체크
            * 1010 0000 = 풀하우스
            *  + 3장 숫자 체크
            *  + 2장 숫자 체크
            *  + 3장 모양 체크
            *  + 2장 모양 체크
            *  }
            * {(앞자리 상관없음)
            * 0000 0001 = 플러시
            *  + 모양 체크
            * 0000 0010 = 마운틴
            *  + 모양 체크
            * 0000 0100 = 백줄
            *  + 숫자 체크
            *  + 모양 체크
            * 0000 1000 = 줄
            *  + 숫자 체크
            *  + 모양 체크
            * }
            * {(뒷 4자리 없음)
            * 0010 0000 = 트리플
            * 0100 0000 = 투페어
            * 1000 0000 = 원페어
            * }
            * 0000 0000 = 탑
            */
        }

        // 로얄 스트레이트 정렬
        public void RoyalSort(List<int> handNum, List<int> handMark, List<int> sort)
        {
            int tempNum = 0;
            for (int i = 0; i < sort.Count; i++)
            {
                sortNumList.Add(handNum[i]);
                sortMarkList.Add(handMark[i]);
            }
            for (int i = 0; i < sort.Count; i++)
            {
                switch (handNum[sort[i]])
                {
                    case 1:
                        tempNum = sortNumList[0];
                        sortNumList[0] = handNum[sort[i]];
                        sortNumList.Add(tempNum);
                        break;
                    case 13:
                        tempNum = sortNumList[1];
                        sortNumList[1] = handNum[sort[i]];
                        sortNumList.Add(tempNum);
                        break;
                    case 12:
                        tempNum = sortNumList[2];
                        sortNumList[2] = handNum[sort[i]];
                        sortNumList.Add(tempNum);
                        break;
                    case 11:
                        tempNum = sortNumList[3];
                        sortNumList[3] = handNum[sort[i]];
                        sortNumList.Add(tempNum);
                        break;
                    case 10:
                        tempNum = sortNumList[4];
                        sortNumList[5] = handNum[sort[i]];
                        sortNumList.Add(tempNum);
                        break;
                    default:
                        break;
                }
            }

        }
        // 백스트레이트 정렬
        public void BackSort(List<int> handNum, List<int> handMark, List<int> sort)
        {
            int tempNum = 0;
            for (int i = 0; i < sort.Count; i++)
            {
                sortNumList.Add(handNum[i]);
                sortMarkList.Add(handMark[i]);
            }
            for (int i = 0; i < sort.Count; i++)
            {
                switch (handNum[sort[i]])
                {
                    case 1:
                        tempNum = sortNumList[0];
                        sortNumList[0] = handNum[sort[i]];
                        sortNumList.Add(tempNum);
                        break;
                    case 2:
                        tempNum = sortNumList[1];
                        sortNumList[1] = handNum[sort[i]];
                        sortNumList.Add(tempNum);
                        break;
                    case 3:
                        tempNum = sortNumList[2];
                        sortNumList[2] = handNum[sort[i]];
                        sortNumList.Add(tempNum);
                        break;
                    case 4:
                        tempNum = sortNumList[3];
                        sortNumList[3] = handNum[sort[i]];
                        sortNumList.Add(tempNum);
                        break;
                    case 5:
                        tempNum = sortNumList[4];
                        sortNumList[5] = handNum[sort[i]];
                        sortNumList.Add(tempNum);
                        break;
                    default:
                        break;
                }
            }
        }
        // 로티플
        public void RotiflSort(List<int> handNum, List<int> handMark, List<int> sort)
        {
            RoyalSort(handNum, handMark, sort);
            for (int i = 0; i < handNum.Count; i++)
            {
                if (!sort.Contains(i))
                {
                    sortNumList.Add(handNum[i]);
                    sortMarkList.Add(handMark[i]);
                }
            }
            RoundPrint(sortNumList, sortMarkList);
        }
        // 백티플
        public void BacktiflSort(List<int> handNum, List<int> handMark, List<int> sort)
        {
            BackSort(handNum, handMark, sort);
            for (int i = 0; i < handNum.Count; i++)
            {
                if (!sort.Contains(i))
                {
                    sortNumList.Add(handNum[i]);
                    sortMarkList.Add(handMark[i]);
                }
            }

            RoundPrint(sortNumList, sortMarkList);
        }
        // 스티플
        public void StiflSort(List<int> handNum, List<int> handMark, List<int> sort)
        {
            int tempNum = 0;
            //int tempMark = 0;
            for (int j = 0; j < sort.Count - 1; j++)
            {
                if (handNum[j] > handNum[sort[j + 1]])
                {
                    tempNum = handNum[sort[j]];
                    handNum[sort[j]] = handNum[sort[j + 1]];
                    handNum[sort[j + 1]] = tempNum;
                    //tempMark = handMark[sort[j]];
                    //handMark[sort[j]] = handMark[sort[j+1]];
                    //handNum[sort[j + 1]] = tempMark;
                }
            }
            for (int i = 0; i < sort.Count; i++)
            {
                sortNumList.Insert(i, handNum[sort[i]]);
                sortMarkList.Insert(i, handMark[sort[i]]);
            }
            for (int i = 0; i < handNum.Count; i++)
            {
                if (!sort.Contains(i))
                {
                    sortNumList.Add(handNum[i]);
                    sortMarkList.Add(handMark[i]);
                }
            }

            RoundPrint(sortNumList, sortMarkList);
        }
        // 포카드
        public void FourCardSort(List<int> handNum, List<int> handMark, List<int> sort)
        {
            //int tempNum = 0;
            int tempMark = 0;

            for (int i = 0; i < sort.Count; i++)
            {
                sortNumList.Add(handNum[sort[i]]);
                sortMarkList.Add(handMark[sort[i]]);
            }

            for (int i = 0; i < handNum.Count; i++)
            {
                if (!sort.Contains(i))
                {
                    sortNumList.Add(handNum[i]);
                    sortMarkList.Add(handMark[i]);
                }
            }
            RoundPrint(sortNumList, sortMarkList);

        }
        // 풀하우스
        public void FullHouseSort(List<int> handNum, List<int> handMark, List<int> sort, List<int> sort2)
        {
            int tempMark = 0;
            for (int j = 0; j < sort.Count - 1; j++)
            {
                if (handMark[sort[j]] > handMark[sort[j + 1]])
                {
                    //tempNum = handNum[sort[j]];
                    //handNum[sort[j]] = handNum[sort[j + 1]];
                    //handNum[sort[j + 1]] = tempNum;
                    tempMark = handMark[sort[j]];
                    handMark[sort[j]] = handMark[sort[j + 1]];
                    handNum[sort[j + 1]] = tempMark;
                }
            }

            for (int i = 0; i < sort2.Count; i++)
            {
                sortNumList.Insert(i, handNum[sort2[i]]);
                sortMarkList.Insert(i, handMark[sort2[i]]);
            }
            for (int j = 0; j < sort2.Count - 1; j++)
            {
                if (handMark[sort2[j]] > handMark[sort2[j + 1]])
                {
                    //tempNum = handNum[sort[j]];
                    //handNum[sort[j]] = handNum[sort[j + 1]];
                    //handNum[sort[j + 1]] = tempNum;
                    tempMark = handMark[sort2[j]];
                    handMark[sort2[j]] = handMark[sort2[j + 1]];
                    handNum[sort2[j + 1]] = tempMark;
                }
            }

            for (int i = 0; i < sort2.Count; i++)
            {
                sortNumList.Insert(i, handNum[sort2[i]]);
                sortMarkList.Insert(i, handMark[sort2[i]]);
            }

            for (int i = 0; i < handNum.Count; i++)
            {
                if (!sort.Contains(i))
                {
                    sortNumList.Add(handNum[i]);
                    sortMarkList.Add(handMark[i]);
                }
            }
            RoundPrint(sortNumList, sortMarkList);
        }
        // 마운틴
        public void MountainSort(List<int> handNum, List<int> handMark)
        {

            int tempNum = 0;
            int tempMark = 0;
            for (int i = 0; i < handNum.Count; i++)
            {
                sortNumList.Add(handNum[i]);
                sortMarkList.Add(handMark[i]);
            }
            for (int i = 0; i < handNum.Count; i++)
            {
                switch (handNum[i])
                {
                    case 1:
                        tempNum = sortNumList[0];
                        sortNumList[0] = handNum[i];
                        sortNumList.Add(tempNum);
                        tempMark = sortMarkList[0];
                        sortMarkList[0] = handMark[i];
                        sortMarkList.Add(tempMark);
                        break;
                    case 13:
                        tempNum = sortNumList[1];
                        sortNumList[1] = handNum[i];
                        sortNumList.Add(tempNum);
                        tempMark = sortMarkList[1];
                        sortMarkList[1] = handMark[i];
                        sortMarkList.Add(tempMark);
                        break;
                    case 12:
                        tempNum = sortNumList[2];
                        sortNumList[2] = handNum[i];
                        sortNumList.Add(tempNum);
                        tempMark = sortMarkList[2];
                        sortMarkList[2] = handMark[i];
                        sortMarkList.Add(tempMark);
                        break;
                    case 11:
                        tempNum = sortNumList[3];
                        sortNumList[3] = handNum[i];
                        sortNumList.Add(tempNum);
                        tempMark = sortMarkList[3];
                        sortMarkList[3] = handMark[i];
                        sortMarkList.Add(tempMark);
                        break;
                    case 10:
                        tempNum = sortNumList[4];
                        sortNumList[4] = handNum[i];
                        sortNumList.Add(tempNum);
                        tempMark = sortMarkList[4];
                        sortMarkList[4] = handMark[i];
                        sortMarkList.Add(tempMark);
                        break;
                    default:
                        sortNumList.Add(handNum[i]);
                        sortMarkList.Add(handMark[i]);
                        break;
                }
            }
            RoundPrint(sortNumList, sortMarkList);
        }
        // 백줄
        public void BackJulSort(List<int> handNum, List<int> handMark)
        {
            int tempNum = 0;
            int tempMark = 0;
            for (int i = 0; i < handNum.Count; i++)
            {
                sortNumList.Add(handNum[i]);
                sortMarkList.Add(handMark[i]);
            }
            for (int i = 0; i < handNum.Count; i++)
            {
                switch (handNum[i])
                {
                    case 1:
                        tempNum = sortNumList[0];
                        sortNumList[0] = handNum[i];
                        sortNumList.Add(tempNum);
                        tempMark = sortMarkList[0];
                        sortMarkList[0] = handMark[i];
                        sortMarkList.Add(tempMark);
                        break;
                    case 2:
                        tempNum = sortNumList[1];
                        sortNumList[1] = handNum[i];
                        sortNumList.Add(tempNum);
                        tempMark = sortMarkList[1];
                        sortMarkList[1] = handMark[i];
                        sortMarkList.Add(tempMark);
                        break;
                    case 3:
                        tempNum = sortNumList[2];
                        sortNumList[2] = handNum[i];
                        sortNumList.Add(tempNum);
                        tempMark = sortMarkList[2];
                        sortMarkList[2] = handMark[i];
                        sortMarkList.Add(tempMark);
                        break;
                    case 4:
                        tempNum = sortNumList[3];
                        sortNumList[3] = handNum[i];
                        sortNumList.Add(tempNum);
                        tempMark = sortMarkList[3];
                        sortMarkList[3] = handMark[i];
                        sortMarkList.Add(tempMark);
                        break;
                    case 5:
                        tempNum = sortNumList[4];
                        sortNumList[4] = handNum[i];
                        sortNumList.Add(tempNum);
                        tempMark = sortMarkList[4];
                        sortMarkList[4] = handMark[i];
                        sortMarkList.Add(tempMark);
                        break;
                    default:
                        break;
                }
            }
            RoundPrint(sortNumList, sortMarkList);
        }
        // 줄
        public void JulSort(List<int> handNum, List<int> handMark)
        {

            int tempNum = 0;
            int tempMark = 0;
            for (int i = 0; i < handNum.Count - 1; i++)
            {
                for (int j = 0; j < handNum.Count; j++)
                {
                    if (handNum[i] > handNum[j])
                    {
                        tempNum = handNum[i];
                        handNum[i] = handNum[j];
                        handNum[j] = tempNum;
                        tempMark = handMark[i];
                        handMark[i] = handMark[j];
                        handMark[j] = tempMark;
                        break;
                    }
                }

            }
            for (int i = 0; i < handNum.Count; i++)
            {
                sortNumList.Add(handNum[i]);
                sortMarkList.Add(handMark[i]);
            }
            RoundPrint(sortNumList, sortMarkList);
        }
        // 투페어
        public void TwoPairSort(List<int> handNum, List<int> handMark, List<int> sort)
        {
            int tempNum = 0;
            int tempMark = 0;
            for (int i = 0; i < sort.Count; i++)
            {
                for (int j = 0; j < sort.Count; j++)
                {
                    if (handNum[sort[i]] > handNum[sort[j]])
                    {
                        tempNum = handNum[sort[i]];
                        handNum[sort[i]] = handNum[sort[j]];
                        handNum[sort[j]] = tempNum;
                        tempMark = handMark[sort[i]];
                        handMark[sort[i]] = handMark[sort[j]];
                        handMark[sort[j]] = tempMark;
                        break;
                    }
                }

            }
            for (int i = 0; i < sort.Count; i++)
            {
                sortNumList.Add(handNum[sort[i]]);
                sortMarkList.Add(handMark[sort[i]]);
            }

            for (int i = 0; i < handNum.Count; i++)
            {
                if (!sort.Contains(i))
                {
                    sortNumList.Add(handNum[i]);
                    sortMarkList.Add(handMark[i]);
                }
            }
            RoundPrint(sortNumList, sortMarkList);
        }
        // 탑
        public void TopSort(List<int> handNum, List<int> handMark)
        {
            for (int i = 0; i < handNum.Count; i++)
            {
                sortNumList.Add(handNum[i]);
                sortMarkList.Add(handMark[i]);
            }
            RoundPrint(sortNumList, sortMarkList);
        }
        // 출력
        public void RoundPrint(List<int> sortNumList, List<int> sortMarkList)
        {

            string line0 = "";
            string line1 = "";
            string line2 = "";
            string line3 = "";
            string line4 = "";
            string line5 = "";
            string num = "";
            string mark = "";


            for (int i = 0; i < sortNumList.Count; i++)
            {
                num = sortNumList[i].ToString();
                mark = CardSet.trumpCardMark[sortMarkList[i]];
                line0 = line0 + " ------    ";
                switch (num)
                {
                    case "11":
                        num = "J";
                        break;
                    case "12":
                        num = "Q";
                        break;
                    case "13":
                        num = "K";
                        break;
                    default:
                        break;
                }
                if (num == "10")
                {
                    line1 = line1 + "|" + mark + num + "  |   ";
                    line5 = line5 + "|  " + num + mark + "|   ";
                }
                else
                {
                    line1 = line1 + "|" + mark + num + "   |   ";
                    line5 = line5 + "|   " + num + mark + "|   ";
                }
                line2 = line2 + "|      |   ";
                line3 = line3 + "|  " + mark + "  |   ";
                line4 = line4 + "|      |   ";
            }
            Console.WriteLine(line0);
            Console.WriteLine(line1);
            Console.WriteLine(line2);
            Console.WriteLine(line3);
            Console.WriteLine(line4);
            Console.WriteLine(line5);
            Console.WriteLine(line0);
        }

    }       // class PokerCheck

}
