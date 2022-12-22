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
            //int[] numbers = new int[5] { 1, 2, 3, 4, 5 };

            //int number1 = 1;
            //int number2 = 2;
            //int number3 = 3;
            //int number4 = 4;
            //int number5 = 5;
            //Console.WriteLine();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write($"{numbers[i]}");
            //}

            //foreach(int element in numbers)
            //{
            //    Console.Write(element);
            //}

            // * 22.12.22

            //int whatNum = 1_0822;
            //Console.WriteLine(whatNum % 64);

            /**
             * 다차원 배열
             * 2차원 배열, 3차원 배열을 포함
             * 차원이 2개 이상인 배열
             * C#에서 배열을 선언할 때는 콤마(,)를 기준으로 차원을 구분
             */

            //int[] oneArray = new int[2] { 1, 2 };
            //int[,] twoArray = new int[2, 2] { { 1, 2 }, { 3, 4 } };
            //int[,,] threeArray = new int[2, 2, 2] 
            //{ 
            //    { { 1, 2 }, { 3, 4 } }, 
            //    { { 5, 6 }, { 7, 8 } } 
            //};

            // 3행 3열짜리 배열에서 행과 열이 같으면 1, 다르면 0을 출력

            /**   | 1 | 2 | 3
             *  --------------
             *  1 | 1 | 0 | 0
             *  --------------
             *  2 | 0 | 1 | 0
             *  --------------
             *  3 | 0 | 0 | 1
             */

            //twoArray = new int[3, 3];

            //for (int y = 0; y < 3; y++)
            //{
            //    for (int x = 0; x < 3; x++)
            //    {
            //        if (x == y)
            //            twoArray[y, x] = 1;
            //        else
            //            twoArray[y, x] = 0;
            //    }
            //} // loop : 값을 대입하는 루프


            //for (int y = 0; y <=twoArray.GetUpperBound(0); y++)
            //{
            //    for (int x = 0; x <= twoArray.GetUpperBound(1); x++)
            //    {
            //        Console.Write($"{twoArray[y,x]} ");
            //    }
            //    Console.WriteLine();
            //} // loop : 값을 대입하는 루프

            /**
             * 가변 배열
             * 배열 길이가 가변적인 배열
             */

            //int[][] zagArray = new int[2][];
            //zagArray[0] = new int[] { 1, 2 };
            //zagArray[1] = new int[] { 3, 4, 5 };

            //for (int y = 0; y < 2; y++)
            //{
            //    for (int x = 0; x < zagArray[y].Length; x++)
            //    {
            //        Console.Write($"{zagArray[y][x]} ");
            //    }
            //    Console.WriteLine();
            //}


            //int[] intArray;         // int 형 데이터 타입의 intArray라는 배열을 선언
            //intArray = new int[3];  // int 형 데이터 타입의 변수를 3개 메모리에 할당

            //intArray[0] = 1;        // intArray 0번째 인덱스에 1이라는 정수 값을 대입
            //intArray[1] = 2;        // intArray 0번째 인덱스에 1이라는 정수 값을 대입
            //intArray[2] = 3;        // intArray 0번째 인덱스에 1이라는 정수 값을 대입

            //// 배열 직접 출력
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"{i}번째 인덱스의 값 : {intArray[i]}");
            //} // loop : 3번 도는 루프
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            //// intArray 배열에서 int 형 데이터 타입의 값을 하나씩 뽑아서 index에 저장
            //foreach(int index in intArray)
            //{
            //    Console.WriteLine($"intArray 배열에서 뽑아온 값 -> {index}");
            //} // loop : intArray 배열의 길이만큼 도는 루프

            /* 배열을 사용하여 국어 점수의 총점과 평균 구하기
            * 학생 3명의 점수를 저장하는 배열 선언해서 각 학생별로 점수를 할당
            * 모든 점수의 총점과 평균을 구해서 출력
            * -> 유저인풋 3회
            * -> 점수 범위 1~100
            * -> 이상한 입력 예외처리
            */

            //int[] score = new int[3];
            //int sum = 0;


            //Console.Write("학생 1의 점수를 입력해주세요. -> ");
            //int.TryParse(Console.ReadLine(), out score[0]);
            //while (score[0] == 0 || score[0] < 1 || score[0] > 100)
            //{
            //    Console.Write("학생 1의 점수를 1~100 사이의 숫자로 입력해주세요. -> ");
            //    int.TryParse(Console.ReadLine(), out score[0]);
            //}
            //Console.Write("학생 2의 점수를 입력해주세요. -> ");
            //int.TryParse(Console.ReadLine(), out score[1]);
            //while (score[1] == 0 || score[1] < 1 || score[1] > 100)
            //{
            //    Console.Write("학생 2의 점수를 1~100 사이의 숫자로 입력해주세요. -> ");
            //    int.TryParse(Console.ReadLine(), out score[1]);
            //}
            //Console.Write("학생 3의 점수를 입력해주세요. -> ");
            //int.TryParse(Console.ReadLine(), out score[2]);
            //while (score[2] == 0 || score[2] < 1 || score[2] > 100)
            //{
            //    Console.Write("학생 3의 점수를 1~100 사이의 숫자로 입력해주세요. -> ");
            //    int.TryParse(Console.ReadLine(), out score[2]);
            //}

            //for(int i = 0; i < score.Length; i++)
            //{
            //    sum += score[i];
            //}

            //Console.WriteLine($"{score.Length}명의 점수 총 합 : {sum}");
            //Console.WriteLine($"{score.Length}명의 점수 평균 : {(float)sum/score.Length}");


            /**
             * LAB 1 배열에서 최대값 찾기
             * 크기가 100인 배열을 1부터 100사이의 난수로 채우고 배열 요소 중 최대값을 찾는 프로그램 작성
             * - 보기좋게 출력(가독성이 높아야 함)
             */

            Random random = new Random();
            //int[] allNum = new int[100];
            //int bigNum = 0;
            //string arrayNum = "";

            //for (int i = 0; i < allNum.Length; i++)
            //{
            //    allNum[i] = random.Next(1, 101);
            //}
            //Console.WriteLine("100개 난수 배열");
            //Console.WriteLine();
            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        if (bigNum < allNum[i * 10 + j])
            //        {
            //            bigNum = allNum[i * 10 + j];
            //        }
            //        if (allNum[i * 10 + j] < 10)
            //            arrayNum = "  " + allNum[i * 10 + j];
            //        else if (allNum[i * 10 + j] >= 10 && allNum[i * 10 + j] < 100)
            //            arrayNum = " " + allNum[i * 10 + j];
            //        else
            //            arrayNum = allNum[i * 10 + j].ToString();
            //        Console.Write($"{arrayNum} ");
            //    }
            //    Console.WriteLine();
            //    Console.WriteLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine($"배열 중 가장 큰 수 : {bigNum}");

            /**
             * LAB 2 사과를 제일 좋아하는 사람 찾기
             * 사람 5명에게 아침에 먹는 사과 개수를 입력하도록 요청
             * 데이터 입력이 마무리 되면 누가 가장 많은 사과를 아침으로 먹었는지 출력
             * - 이상한 입력 예외처리
             * - 제일 적게 먹은 사람도 찾도록 수정해보기(변형1)
             * - 먹은 사과의 개수 순으로 정렬(변형2)
             *      - 알고리즘을 잘 모르겠다면 버블 정렬 도전 (변형2)
             *      - 알고리즘을 잘 알겠다면 Merge sort 도전 (하드모드) 도전!
             *              - 정렬 도전 시 유저 입력X
             *              - 데이터는 난수로 100~1000개 정도
             *              - 중복 제거
             *              - 시간초 상관없음
             * - 능력껏 순서대로 도전
             */
            int appleNum = random.Next(100, 1001);
            int[] appleArray = new int[appleNum];
            int appleBig = 0;
            int appleSmall = 0;

            for (int i = 0; i < appleArray.Length; i++)
            {
                appleArray[i] = random.Next(1, 1001);
                while (Array.Exists(appleArray, x => x == appleArray[i]))
                {
                    appleArray[i] = random.Next(1, 1001);
                }
            }


            int[] sortArray = new int[appleNum];


            int left = 0;
            int mid = 0;
            int right = appleArray.Length - 1;
            int pos = 0;
            int leftEnd = 1;
            int element_ = 2;


            Console.WriteLine($"가장 많이 먹은 사과의 수 : {appleBig}");
            Console.WriteLine($"가장 적게 먹은 사과의 수 : {appleSmall}");


            /**
             * LAB 1, 2 코딩했던 내용, 주석 달아서 해석해서 제출
             * 용량 유의
             * 어느 단계까지 도전 했는지 포함
             * 과제_김초원_221222.zip
             */

        } // Main()
    }
}
