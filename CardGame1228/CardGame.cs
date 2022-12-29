using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame1228
{
    public class CardGame
    {
        // 셋팅된 카드
        private int[] trumpCardSet;
        // 카드 기호
        private string[] trumpCardMark = new string[4] { "♥", "♠", "◈", "♣" };
        // 카드 숫자
        private int cardNum1 = 0;
        // 출력되는 문자열
        private string printCardNum1 = "";
        // 카드 기호
        private string printCardMark1 = "";
        // 카드 숫자2
        private int cardNum2 = 0;
        // 출력되는 문자열2
        private string printCardNum2 = "";
        // 카드 기호2
        private string printCardMark2 = "";
        // 컴퓨터가 뽑은 카드 1
        private int comCard1 = 0;
        // 컴퓨터가 뽑은 카드 2
        private int comCard2 = 0;
        // 플레이어가 뽑은 카드
        private int userCard1 = 0;
        // 플레이어가 뽑은 카드번호
        private int userNum1 = 0;
        // 플레이어 보유 포인트
        private int userPoint = 0;
        // 플레이어 배팅 포인트
        private int betPoint = 0;
        // 현재 사용한 카드 체크
        private int cardCount = 0;
        // 게임 끝 체크
        private bool isGameOver = false;

        // 전체 루프
        public void CardGameStart()
        {
            SetupTrumpCard();
            userPoint = 10000;
            ShuffleCards();
            while (!isGameOver)
            {
                Console.Clear();
                Console.WriteLine($"현재 보유 포인트 : {userPoint}");
                ComTwoCard();
                UserBet();
                UserCard();
                CardCheck();
            }
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

        // 컴퓨터가 2장 뽑기
        private void ComTwoCard()
        {
            cardNum1 = 0;
            cardNum2 = 0;
            printCardNum1 = "";
            printCardNum2 = "";
            if (cardCount+1 < 52)
            {
                /* Do Nothing */
            }
            else
            {
                ShuffleCards();
            }
            comCard1 = trumpCardSet[cardCount];
            comCard2 = trumpCardSet[cardCount + 1];

            cardCount = cardCount + 2;

            // 컴 카드 두장 출력
            cardNum1 = comCard1%13;
            cardNum2 = comCard2%13;
            printCardMark1 = trumpCardMark[(comCard1 - 1) / 13];
            printCardMark2 = trumpCardMark[(comCard2 - 1) / 13];
            if (cardNum1 == 0)
            {
                cardNum1 = 13;
                printCardNum1 = "K ";
            }
            else if (cardNum1 == 12)
            {
                printCardNum1 = "Q ";
            }
            else if (cardNum1 == 11)
            {
                printCardNum1 = "J ";
            }
            else if (cardNum1 == 10)
            {
                printCardNum1 = $"{cardNum1}";
            }
            else if (cardNum1 == 1)
            {
                printCardNum1 = "A ";
            }
            else
            {
                printCardNum1 = $"{cardNum1} ";
            }

            if (cardNum2 == 0)
            {
                cardNum2 = 13;
                printCardNum2 = "K ";
            }
            else if (cardNum2 == 12)
            {
                printCardNum2 = "Q ";
            }
            else if (cardNum2 == 11)
            {               
                printCardNum2 = "J ";
            }      
            else if (cardNum2 == 1)
            {               
                printCardNum2 = "A ";
            }               
            else if (cardNum2 == 10)
            {               
                printCardNum2 = $"{cardNum2}";
            }               
            else            
            {               
                printCardNum2 = $"{cardNum2} ";
            }
            Console.WriteLine("컴퓨터가 카드를 2장 뽑았습니다.");

            Console.WriteLine($" --------- \t  ---------");
            Console.WriteLine($"| {printCardMark1}{printCardNum1}     |\t | {printCardMark2}{printCardNum2}     |");
            Console.WriteLine($"|         |\t |         |");
            Console.WriteLine($"|    {printCardMark1}    |\t |    {printCardMark2}    |");
            Console.WriteLine($"|         |\t |         |");
            Console.WriteLine($"|     {printCardNum1}{printCardMark1} |\t |     {printCardNum2}{printCardMark2} |");
            Console.WriteLine($" --------- \t  ---------");
        }

        // 플레이어가 배팅하기
        private void UserBet()
        {
            Console.Write("\n얼마의 포인트를 걸겠습니까? -> ");
            int.TryParse(Console.ReadLine(), out betPoint);
            while(userPoint < betPoint || betPoint < 0)
            {
                Console.Write("보유 포인트 범위 내로 걸어주세요. -> ");
                int.TryParse(Console.ReadLine(), out betPoint);
            }
            Console.WriteLine();
        }

        // 플레이어가 뽑기
        private void UserCard()
        {
            userNum1 = 0;
            printCardNum1 = "";
            if (cardCount <= 52)
            {
                /* Do Nothing */
            }
            else
            {
                ShuffleCards();
            }
            userCard1 = trumpCardSet[cardCount];
            cardCount = cardCount + 1;

            userNum1 = userCard1 % 13;
            printCardMark1 = trumpCardMark[(userCard1 - 1) / 13];
            if (userNum1 == 0)
            {
                userNum1 = 13;
                printCardNum1 = "K ";
            }
            else if (userNum1 == 12)
            {
                printCardNum1 = "Q ";
            }
            else if (userNum1 == 11)
            {
                printCardNum1 = "J ";
            }
            else if (userNum1 == 10)
            {
                printCardNum1 = $"{userNum1}";
            }
            else if (userNum1 == 1)
            {
                printCardNum1 = "A ";
            }
            else
            {
                printCardNum1 = $"{userNum1} ";
            }

            // 내 카드 한장 출력
            Console.WriteLine("당신이 카드를 1장 뽑았습니다.");

            Console.WriteLine($"\t ---------");
            Console.WriteLine($"\t| {printCardMark1}{printCardNum1}     |");
            Console.WriteLine($"\t|         |");
            Console.WriteLine($"\t|    {printCardMark1}    |");
            Console.WriteLine($"\t|         |");
            Console.WriteLine($"\t|     {printCardNum1}{printCardMark1} |");
            Console.WriteLine($"\t ---------");

        }
        // 플레이어 카드가 컴퓨터 카드 사이에 있는지 체크 후 포인트 증감
        private void CardCheck()
        {
            if(cardNum1 > cardNum2)
            {
                if (userNum1 > cardNum2&& userNum1 < cardNum1)
                {
                    Console.WriteLine($"당신이 이겼습니다. {betPoint*2} 포인트를 얻었습니다.");
                    userPoint = userPoint + betPoint;
                    Console.WriteLine($"현재 포인트 : {userPoint}");
                }
                else
                {
                    Console.WriteLine($"당신이 졌습니다. {betPoint} 포인트를 잃었습니다.");
                    userPoint = userPoint - betPoint;
                    Console.WriteLine($"현재 포인트 : {userPoint}");
                }
            }
            else
            {

                if (userNum1 > cardNum1 && userNum1 < cardNum2)
                {
                    Console.WriteLine($"당신이 이겼습니다. {betPoint * 2} 포인트를 얻었습니다.");
                    userPoint = userPoint + betPoint;
                    Console.WriteLine($"현재 포인트 : {userPoint}");
                }
                else
                {
                    Console.WriteLine($"당신이 졌습니다. {betPoint} 포인트를 잃었습니다.");
                    userPoint = userPoint - betPoint;
                    Console.WriteLine($"현재 포인트 : {userPoint}");
                }
            }
            GameEnd();
        }

        // 게임 종료 체크
        private void GameEnd()
        {
            if (userPoint >= 100000)
            {
                Console.WriteLine("10만 포인트를 모았습니다. 당신의 승리입니다!");
                isGameOver = true;
            }
            else if (userPoint <= 0)
            {
                Console.WriteLine("포인트를 모두 잃었습니다. 당신의 패배입니다.");
                isGameOver = true;
            }
            else
            {
                Console.WriteLine("계속 하시려면 아무 키나 입력해주세요.");
                ConsoleKeyInfo checkKey = Console.ReadKey(true);
            }
        }
    }
}
