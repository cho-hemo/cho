using System;

namespace Reperence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
             * 22.12.23
             * 레퍼런스 게임 직접 해보면서 지금까지 배운 것들로 무엇을 어디까지 구현 가능한지
             * 마인드맵으로 그려보기 아래의 4장 정도
             *  - 타이틀 씬
             *  - 선택지를 포함한 이벤트 -> 유저가 뭔가 선택 가능
             *  - 보상 OR 페널티를 얻을 수 있는 이벤트 -> 유저가 골드, 아이템, 스탯을 얻거나 잃기
             *  - 전투 씬 -> 몹이 등장해 싸워서 결과를 내는 형태
             *  
             */

            string line = "=============================\n";
            string title = "        여정의 속삭임\n\n\n\n\n\n\n  아무 키나 눌러 시작하세요.\n\n";
            
            Console.WriteLine(line+"\n");
            Console.WriteLine(title);
            Console.WriteLine(line);
            if (Console.ReadLine() != string.Empty)
            {
                Console.Clear();
            }

            string charName, start;
            int charSel, str, obs, hand, endu, intel, luck, gold, power, level, turn, per, eventPer, item;
            // 랜덤 직업, 근력, 관찰, 손재주, 지구력, 지력, 운,  골드,  전투력,   레벨,  턴,  퍼센트, 이벤트퍼센트, 아이템번호
            bool ingGame = false;
            Random random= new Random();


            // 게임을 계속할 때 초기화용
            while (!ingGame)
            {
                ingGame = true;
                charSel = random.Next(1, 4);
                charName = "0";
                str = 0;
                obs = 0;
                hand = 0;
                endu = 0;
                intel = 0;
                luck = 0;
                item = 0;
                switch (charSel)
                {
                    case 1:
                    default:
                        charName = "약초꾼";
                        start = "작은 마을에는 더이상 약초가 없다.\n당신은 여행을 떠나기로 했다.\n\n\n";
                        str = 2;
                        obs = 5;
                        hand = 5;
                        endu = 3;
                        intel = 2;
                        luck = 3;
                        item= 1;
                        break;
                    case 2:
                        charName = "용병";
                        start = "작은 마을에는 더이상 의뢰가 없다.\n당신은 여행을 떠나기로 했다.\n\n\n";
                        str = 5;
                        obs = 2;
                        hand = 3;
                        endu = 5;
                        intel = 2;
                        luck = 3;
                        item= 2;
                        break;
                    case 3:
                        charName = "사제";
                        start = "작은 마을에는 더이상 인도할 사람이 없다.\n당신은 여행을 떠나기로 했다.\n\n\n";
                        str = 2;
                        obs = 3;
                        hand = 3;
                        endu = 2;
                        intel = 5;
                        luck = 5;
                        item = 3;
                        break;
                }

                gold = 0;
                power = 0;
                level = 0;
                turn = 0;
                per = 30;
                eventPer = 0;

                // 레벨 7이 되면 엔딩
                while (level>=7)
                {
                    Console.WriteLine(line);
                    Console.WriteLine($"직업 {charName}");
                    Console.WriteLine($"근력{str} 관찰{obs} 재주{hand}");
                    Console.WriteLine($"근성{endu} 지력{intel} 운{luck}");
                    Console.WriteLine(line);
                }

            }

            Console.WriteLine("게임이 종료되었습니다.");



        }
    }
}