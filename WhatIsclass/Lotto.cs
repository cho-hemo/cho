using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsclass
{
    internal class Lotto
    {
        static int[] rand = new int[6];
        static Random random= new Random();
        static int Num = 0;
        public static void LottoNum() 
        {
            /** class를 사용해서 로또번호 생성기를 작성할 것
            *    - 1~45 사이의 랜덤한 숫자 (중복 X)
            *    - 6개의 랜덤한 숫자를 뽑아서 출력
            */
            // (다른 방법) 배열 사용시 1~45를 넣고 배열을 랜덤하게 셔플하는 것으로 중복없이 배열을 만들 수 있다.
            Console.WriteLine("============================");
            Console.WriteLine("=======로또번호생성기=======");
            Console.WriteLine("============================");
            Console.WriteLine();
            Console.WriteLine("       오늘의 숫자는?       ");
            Console.WriteLine();
            randNum();
            Console.Write("   ");
            for (int i = 0; i < rand.Length; i++)
            {
                Console.Write($" {rand[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("============================");

        }
        static void randNum()
        {
            for (int i = 0; i < rand.Length; i++)
            {
                Num = random.Next(1,45+1);
                while(Array.Exists(rand,x => x == Num))
                {
                    Num = random.Next(1, 45 + 1);
                }
                rand[i] = Num;
            }
            Num = 0;
            for (int i = 0; i < rand.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (rand[j] > rand[j+1])
                    {
                        Num = rand[j];
                        rand[j] = rand[j+1];
                        rand[j+1] = Num;
                    }
                }
            }
        }
    }
}
