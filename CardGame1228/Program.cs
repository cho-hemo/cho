using System;

namespace CardGame1228
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
             * 과제 카드 뽑기
             *  - 컴퓨터가 2장을 뽑아서 보여줌.
             *  - 플레이어가 배팅을 함.(패스하려면 0 포인트를 배팅)
             *  - 플레이어가 뽑은 카드가 컴퓨터가 뽑은 2장의 카드 사이에 있는 카드라면 플레이어가 2배
             *  - 없다면 배팅 금액을 잃음(같은 카드를 뽑아도)
             *  - 플레이어는 10,000 포인트 들고 게임을 시작
             *  - 카드의 대, 소 비교는 오직 숫자로만
             *  - 게임 종료는 100,000 포인트를 벌거나 모두 잃을 때
             */
            CardGame cardGame = new CardGame();
            cardGame.CardGameStart();
        }
    }
}