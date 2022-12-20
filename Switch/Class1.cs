using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            //float Num1, Num2 = 0;
            //Console.Write("실수1을 입력해주세요. -> ");
            //float.TryParse(Console.ReadLine(), out Num1);

            //Console.Write("실수2을 입력해주세요. -> ");
            //float.TryParse(Console.ReadLine(), out Num2);

            //if(Num1 == Num2)
            //{
            //    Console.WriteLine($"{Num1}와(과) {Num2}은(는) 같습니다.");
            //}
            //else
            //{
            //    Console.WriteLine($"{Num1}와(과) {Num2}은(는) 다릅니다.");
            //}

            // 블로그에 작성할 것
            // 부동소수점 에러
            // 엡실론

            /**
             * for 문
             * 일정한 횟수만큼 반복할 때 사용.
             * 초기식을 실행 후 조건식이 참인 동안 문장 반복
             * 한번 반복이 끝날 때마다 증감식이 실행.
             */

            //int sumNum = 0;
            //for (int i = 0; i <= 10; i++)
            //{
            //    sumNum += i;
            //}

            //Console.WriteLine($"1부터 10까지 정수의 합 : {sumNum}");

            // 1에서 100까지 중에서 3의 배수를 제외한 수의 합 구하기
            //int notThree = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    if(i%3 != 0) 
            //    { 
            //        notThree += i; 
            //    }
            //} // loop : 100번 도는 루프
            //Console.WriteLine($"1~100 중 3의 배수를 제외한 나머지 수의 합 : {notThree}");

            /**
             * break 문
             * 반복 루프를 벗어나기 위해 사용
             * 실행 시 반복 루프 즉시 중단 후 루프 다음의 문장이 실행
             */

            //for (int i = 0; i <= 10; i++)
            //{
            //    if (i == 4) { break; }
            //    Console.WriteLine($"현재 인덱스 : {i}");

            //}

            /*
             * continue 문
             * 현재 수행 중인 반복 과정의 나머지를 스킵 후 다음 반복 과정을 강제적으로 실행
             */

            // 1에서 100까지 중에서 3의 배수를 제외한 수의 합 구하기
            //int notThree = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    if(i%3 == 0) 
            //    { 
            //        continue;
            //    }
            //      notThree += i;
            //} // loop : 100번 도는 루프
            //Console.WriteLine($"1~100 중 3의 배수를 제외한 나머지 수의 합 : {notThree}");


            



        } // Main()
    }
}
