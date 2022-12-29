using System;

namespace WhatIsclass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Battle battle = new Battle();

            //Description description = new Description();
            //description.ValueTypeAndReferenceType();

            /**
             * 1 ~ 10 K,Q,J -> 13개
             * 13 * 4(하트, 다이아몬드, 스페이드, 클로버) -> 52개의 카드
             */
            //TrumpCard trumpCard= new TrumpCard();
            //trumpCard.SetupTrumpCard();
            //trumpCard.RollCard();

            /** class를 사용해서 로또번호 생성기를 작성할 것
            *    - 1~45 사이의 랜덤한 숫자 (중복 X)
            *    - 6개의 랜덤한 숫자를 뽑아서 출력
            */
            //Lotto.LottoNum();

            // 가위바위보 게임

            //Console.WriteLine("가위바위보!");
            //Console.Write("당신이 낸 것은? ->  ");
            //Rock.RSP();

            //ClassNote classNote = new ClassNote();  // 인스턴스화 : 메모리에 올리기
            //classNote.InstanceMethod();
            //classNote.StaticMethod();
            //ClassNote.Run();
            //WhatIsStructure();
            //BusinessCard bCard;
            //bCard.name = "";
            //bCard.age = 0;
            //bCard.adress = "";
            //BusinessCard[] newCard = new BusinessCard[3];
            //newCard[0].name = "맹꽁이";
            //newCard[0].age = 1;
            //newCard[0].adress = "두꺼비집";
        }
        struct Point
        {
            public int x;
            public int y;
            public int myNewNum;
            public string myChoCho;
        }
        public struct Slime
        {
            public int hp;
            public int attack;
            public int defence;
            public string type;
            public string drop;
        }

        // 명함(BusinessCard) 이라는 구조체 선언 및 초기화 해보기
        // 이름, 나이, 주소

        public struct BusinessCard
        {
            public string name;
            public int age;
            public string adress;
        }
        enum Weekday
        {
            SUNDAY, MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY
        }
        enum Align
        {
            TOP, BOTTOM, LEFT, RIGHT
        }
        enum Animal
        {
            CHICKEN, DOG, PIG
        }

        static void WhatIsStructure()
        {
            /**
             * 구조체
             * 구조체는 이름 하나로 데이터를 묶어 관리
             * 변수 - 이름 하나로 공간을 하나
             * 배열 - 이름 하나로 데이터 형식이 같은 공간을 여러 개
             * 변수와 배열을 확장하여 이름 하나로 데이터 형식을 1개 이상 보관하는 그릇 역할
             * 
             * int, string 등 서로 다른 자료를 한 집단으로 정의,
             * 이름 하나로 지정할 수 있는 여러 항목의 모임
             * 구조체 변수 : 이름 하나로 데이터 형식 1개 이상을 하나로 보관해놓는 그릇 역할
             * 구조체 배열 : 이름 하나로 데이터 형식 1개 이상을 여러개 보관해놓는 그릇 역할
             * 
             * C#에서는 구조체를 확장한 클래스(class) 개념을 제공.
             * 닷넷에 이미 만들어 둔 내장 구조체를 몇 개 정도 학습한 후
             * 뒤에서 배울 클래스 위주로 사용하면 좋다.
             * 
             * 구조체 만들기
             * 구조체 만드는 방법
             * 구조체를 의미하는 struct 키워드 사용
             * 중괄호 안에 구조체 멤버들을 생성
             * ex) 
             *  struct [구조체 이름]
             *  {
             *      [데이터 형식] [변수 이름1];
             *      [데이터 형식] [변수 이름2];
             *      [데이터 형식] [변수 이름3];
             *  }
             * 
             * 여기에서 구조체 이름은 새로운 데이터 형식이 되며,
             * 변수를 선언할 때 구조체 이름을 사용할 수 있다.
             * 구조체를 가리켜 사용자 정의 데이터 타입이라고도 한다.
             * 
             */

            //Point point;
            //point.x = 100;
            //point.y = 200;
            //point.myNewNum = 0;
            //point.myChoCho = "Chowon";
            //Console.WriteLine($"x, y 좌표는 ({point.x}, {point.y})");

            /**
             * 구조체를 선언할 때는 struct 키워드를 사용.
             * 여기에서는 struct Point {} 형태로 이름이 Point인 구조체를 만들었다.
             * 만든 구조체를 int, string 형식의 변수 선언과 동일한 방법으로 선언 후 사용.
             * 변수 - 값을 하나만 저장
             * 구조체 - 점(.)으로 구분하여 구조체를 선언할 때 사용한 변수 여러 개를 이름 하나(point)로 묶어 쓰기 가능
             * 
             */

            /**
             * 내장형 구조체
             * 닷넷 프레임워크에서 이미 내장(Built-in)된 구조체 중 날짜 처리를 전담하는 DateTime과
             * TimeSapn 구조체, 문자 관련 처리를 담당하는 char 구조체를 자주 사용.
             *  - DateTime 구조체 : 시간/날짜 관련 모든 정보를 제공
             *  - TimeSpan 구조체 : 시간/날짜 간격에 대한 모든 정보를 제공
             *  - char 구조체 : 문자 관련 모든 정보를 제공.
             *      특정 문자가 숫자인지 기호인지 공백인지 등을 판단하는 기능 제공.
             */

            //Console.WriteLine($"DateTime now 하면 뭐가 나오나? -> {DateTime.Now}");
            //Console.WriteLine($"DateTime now 하면 뭐가 나오나? -> {DateTime.Now.Year}");
            //Console.WriteLine($"DateTime now 하면 뭐가 나오나? -> {DateTime.Now.Month}");
            //Console.WriteLine($"DateTime now 하면 뭐가 나오나? -> {DateTime.Now.Day}");
            //Console.WriteLine($"DateTime now 하면 뭐가 나오나? -> {DateTime.Now.Hour}");
            //Console.WriteLine($"DateTime now 하면 뭐가 나오나? -> {DateTime.Now.Minute}");
            //Console.WriteLine($"DateTime now 하면 뭐가 나오나? -> {DateTime.Now.Second}");

            /**
             * 열거형 형식 사용하기
             * C#에서 열거형(Enumeration) 형식은 기억하기 어려운 상수들을 기억하기 쉬운 이름 하나로
             * 묶어 관리하는 표현 방식. 일반적으로 열거형을 줄여 말한다.
             * 열거형 사용 시 값 리스트 여럿을 이름 하나로 관리할 수 있는 장점이 있다.
             * 열거형은 enum 키워드 사용, 이늄 또는 이넘으로 읽는다.
             */

            //Console.ForegroundColor= ConsoleColor.Green;
            //Console.WriteLine("Green");
            //Console.WriteLine("Green");
            //Console.WriteLine("Green");
            //Console.WriteLine("Green");
            //Console.ResetColor();

            //Console.BackgroundColor = ConsoleColor.DarkMagenta;
            //Console.ForegroundColor= ConsoleColor.Black;
            //Console.WriteLine("나는 나만의 길을 간다!");
            //Console.WriteLine("나는 나만의 길을 간다!");
            //Console.WriteLine("나는 나만의 길을 간다!");
            //Console.WriteLine("나는 나만의 길을 간다!");
            //Console.ResetColor();

            //Weekday myweekday;
            //myweekday = Weekday.SUNDAY;

            // 열거형 예제 실습
            //Animal animal = Animal.CHICKEN;
            //switch(animal)
            //{
            //    case Animal.CHICKEN:
            //        Console.WriteLine("닭은 꼬끼오!");
            //        break;
            //    case Animal.DOG:
            //        Console.WriteLine("개는 멍멍!");
            //        break;
            //    case Animal.PIG:
            //        Console.WriteLine("돼지는 꿀꿀!");
            //        break;
            //    default:
            //        Console.WriteLine("예외가 발생하였습니다.");
            //        break;

            //}       // switch
        }       // WhatIsStructure()
    }
}