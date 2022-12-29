using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsclass
{
    public class CardGame
    {
        // 셋팅된 카드
        private int[] trumpCardSet;
        // 카드 기호
        private string[] trumpCardMark = new string[4] { "♥", "♠", "◈", "♣" };
        // 카드 숫자
        private int cardNum = 0;
        // 출력되는 문자열
        private string printCardNum = "";
        // 컴퓨터가 뽑은 카드 1
        private int comCard1 = 0;
        // 컴퓨터가 뽑은 카드 2
        private int comCard2 = 0;
        // 플레이어 보유 포인트
        private int userPoint = 0;
        // 플레이어 배팅 포인트
        private int betPoint = 0;

        // 전체 루프
        public void CardGameStart()
        {

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

            // 컴 카드 두장 출력
        }


        // 플레이어가 배팅하기
        // 플레이어가 뽑기
        // 내 카드 한장 출력
        // 카드가 전부 없어졌는지 체크

        // 플레이어 카드가 컴퓨터 카드 사이에 있는지 체크 후 포인트 증감
        // 포인트 증감 및 게임 종료 체크
    }
}
