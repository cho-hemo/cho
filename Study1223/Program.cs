using System;

namespace Study1223
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
             *  사용자로부터 2개의 문자열을 읽어 같은지 다른지 화면에 출력하는 프로그램 작성
             *  - Equals 메서드 사용 불가
             */

            Console.Write("첫 번째 문자열: -> ");
            string word1 = Console.ReadLine();
            Console.Write("두 번째 문자열: -> ");
            string word2 = Console.ReadLine();

            if (word1.Length == word2.Length)
            {
                for (int i = 0; i < word1.Length; i++)
                {
                    if (word1.Substring(i,1)!=word2.Substring(i,1))
                    {
                        Console.WriteLine("두 문자열은 다릅니다.\n");
                        break;
                    }
                    else if(i == word1.Length-1)
                    {
                        Console.WriteLine("두 문자열은 같습니다.\n");
                        
                    }
                }
            }
            else
            {
                Console.WriteLine("두 문자열은 다릅니다.\n");
            }

            /**
             * 5개의 음료(콜라, 물, 스프라이트, 주스, 커피)를 판매하는 자판기 머신을 구현
             * 사용자가 1~5 사이의 숫자를 입력
             * 선택한 음료를 출력
             * 그 외의 숫자를 선택하면 오류 메시지
             */


            Console.WriteLine("1. 콜라 2. 물 3. 스프라이트 4. 주스 5.커피");
            Console.Write("원하는 음료의 숫자를 입력하세요. ->");
            int drink = 0;
            int.TryParse(Console.ReadLine(), out drink);
            while (drink < 1||drink>5)
            {
                Console.Write("1과 5사이의 숫자를 입력하세요. ->");
                int.TryParse(Console.ReadLine(), out drink);
            }

            switch (drink)
            {
                case 1:
                    Console.WriteLine("콜라가 나왔습니다.");
                    break;
                case 2:
                    Console.WriteLine("물이 나왔습니다.");
                    break;
                case 3:
                    Console.WriteLine("스프라이트가 나왔습니다.");
                    break;
                case 4:
                    Console.WriteLine("주스가 나왔습니다.");
                    break;
                case 5:
                    Console.WriteLine("커피가 나왔습니다.");
                    break;
                default:
                    break;
            }
            Console.WriteLine();


            /**
             * 배열 days[]를 아래와 같이 초기화 하고 배열 요소의 값을 다음과 같이 출력하는 프로그램 작성
             * - 배열 days[]는 31,29,31,30,31,30,31,31,30,31,30,31
             * 배열의 초기화는 중괄호를 사용.
             */

            int[] days = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            for (int i = 0; i < days.Length; i++)
            {
                Console.WriteLine($"{i+1}월은 {days[i]}일까지 입니다.");
            }
        }
    }
}