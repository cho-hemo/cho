using System;

namespace WhatisArray
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            /**
             * 22.12.21 오후 마지막 시간
             * 
             * 컬렉션(Collection) 또는 컨테이너(Container)
             * 이름 하나로 데이터 여러 개를 담을 수 있는 자료 구조
             * 배열(Array), 리스트(List), 사전(Dictinary) 등이 포함
             * 
             * 배열(Array)
             * 같은 종류의 데이터들이 순차적으로 메모리에 저장되는 구조.
             * 각각의 데이터들은 인덱스를 사용하여 독립적으로 접근.
             * 편리하게 데이터를 모아서 관리.
             * 
             * 배열의 특징
             * 1. 배열 하나에는 데이터 형식 한 종류만 보관 가능
             * 2. 배열은 메모리의 연속된 공간을 미리 할당하고, 이를 대괄호([])와 0부터 시작하는 정수형 인덱스로 접근.
             * 3. 배열을 선언할 때는 new 키워드로 배열을 생성한 후 사용할 수 있다.
             * 4. 배열에서 값 하나는 요소(Element) 또는 항목(Item)으로 표현.
             * 5. 필요한 데이터 개수를 정확히 정한다면 메모리를 적게 사용하여 프로그램 크기가 줄고 성능 향상.
             * 
             * 배열 종류
             * 1차원 배열 : 배열의 첨자를 하나만 사용
             * 다차원 배열 : 첨자 2개 이상을 사용하는 배열(2차원, 3차원, ...n차원 배열)
             * 가변(Jagged) 배열 : '배열의 배열'. 이름 하나로 다양한 차원의 배열을 표현할 때 사용.
             * 
             */

            // 배열의 선언과 초기화
            int[] numbers = new int[5] { 1, 2, 3, 4, 5 };

            //int number1 = 1;
            //int number2 = 2;
            //int number3 = 3;
            //int number4 = 4;
            //int number5 = 5;
            Console.WriteLine();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write($"{numbers[i]}");
            //}

            //foreach(int element in numbers)
            //{
            //    Console.Write(element);
            //}

        }
    }
}
