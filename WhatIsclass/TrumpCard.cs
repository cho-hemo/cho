using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsclass
{
    public class TrumpCard
    {
        private int[] trumpCardSet;     // 카드 세트 뭉치
        private string[] trumpCardMark; // 트럼프 카드의 마크
        public void SetupTrumpCard()
        {
            trumpCardSet = new int[52];
            for (int i = 0; i < trumpCardSet.Length; i++)
            {
                trumpCardSet[i] = i + 1;
            }       // loop : 카드를 셋업하는 루프
            // 트럼프 카드의 마크를 셋업
            trumpCardMark = new string[4] { "♥", "♠", "◈", "♣" };
        }       // SetupTrumpCard()

        public void ShuffleCards()
        {
            for (int i = 0; i < 200; i++)
            {
                trumpCardSet = ShuffleOnce(trumpCardSet);
            }
        }       // ShuffleCards()

        public void ShuffleCards(int howManyLoop)
        {
            for (int i = 0; i < howManyLoop; i++)
            {
                trumpCardSet = ShuffleOnce(trumpCardSet);
            }
        }       // ShuffleCards()

        public void PrintCardSet()
        {
            foreach (int card in trumpCardSet)
            {
                Console.Write($"{card} ");
            }
        }
        //! 한장의 카드를 뽑아서 보여주는 함수
        public void RollCard()
        {
            ShuffleCards();
            int card = trumpCardSet[0];
            string cardMark = trumpCardMark[(card-1)/13];
            int cardNum = card % 13;
            string printCard = "";
            if (cardNum == 0)
            {
                cardNum = 13;
            }
            if (cardNum <10)
            {
                printCard = $"{cardNum} ";
            }
            else if(cardNum == 11)
            {
                printCard = $"J";
            }
            else if(cardNum == 12)
            {
                printCard = $"Q";
            }
            else if(cardNum == 13)
            {
                printCard = $"K";
            }
            else
            {

                printCard = $"{cardNum}";
            }
        }

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

        public void PrintChk()
        {
            Console.WriteLine("Main 메서드에서 호출 가능한지?");
        }
    }
}
