using System;

namespace WhatisOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("헬로초원오퍼레이터월드");

            // 10진수를 2진수 문자열로 변환
            string strBinary = Convert.ToString(10, 2);
            Console.WriteLine(strBinary);

            // 2진수를 10진수로 변환
            int intBinary = Convert.ToInt32("0111", 2);
            Console.WriteLine(intBinary);

            /*
             * int32 : 8bit * 4 = 4byte 공간의 int 변수
             * 
             * 연산자(Operator)
             * 데이터로 연산 작업을 수행할 때 사용
             * 기능에 따라 대입, 산술, 관계, 논리, 증감, 조건, 비트, 시프트 연산자 등으로 나뉜다.
             * 단항(Unary) 연산자 : 항 1개로 연산
             * 이항(Binary) 연산자 : 항 2개로 연산
             * 삼항(Ternary) 연산자 : 항 3개로 연산
             * 
             * 단항 연산자 예시
             * [연산자] [피연산자]
             * + 연산자 : 특정 정수형 변수 값을 그대로 출력
             * - 연산자 : 특정 정수형 변수 값을 음수로 변경하여 출력. 음수 값이 들어있다면 양수로 변환해 반환.
             * 
             * 이항 연산자 예시
             * [피연산자1] [연산자] [피연산자2]
             * = 도 이항 연산자
             * 
             * 삼항 연산자
             * 식 1개의 항(Expression)과 그 결과에 따른 피연산자 각 1개씩 총 2개 항으로 식을 처리.
             * (식) ? 피연산자1 : 피연산자2
             * 
             * 식과 문
             * 값 하나 또는 연산을 진행하는 구문의 계산식을 식(Expression) 또는 표현식이라고 한다.
             * 표현식을 사용하여 명령 하나를 진행하는 구문을 문(Statement) 또는 문장이라고 한다.
             */

            // 단항 연산자
            const int PLUS_FIVE = +5;
            const int MINUS_FIVE = -5;

            // 이항 연산자
            const int PLUS_TEN = 5 + 5;

            // 삼항 연산자
            string compareTen = (PLUS_FIVE > 10) ? "{0}은(는) 10보다 크다" : "{0}은(는) 10보다 크지 않다";
            Console.WriteLine(compareTen,PLUS_FIVE);

            // 변환 연산자
            // () 기호를 사용하여 특정 값을 원하는 데이터 형식으로 변환.
            const int PI_INT = (int)Math.PI;
            const float PI_FLOAT = (float)Math.PI;

            Console.WriteLine("PI_INT : {0}, PI_FLOAT : {1}",PI_INT, PI_FLOAT);

            /**
             * 산술 연산자
             * 더하기(Add), 빼기(Subtract), 곱하기(Multiply), 나누기(Divide), 나머지(Remainder, Modules) 등
             * 수학적 연산 시 사용. 보통 정수 형식과 실수 형식의 산술 연산에 사용.
             * +, -, *, /, %
             * 
             * 문자열 연결 연산자
             * + 연산자는 피연산자의 데이터 타입에 따라 산술 연산 또는 문자열 연결 연산을 수행.
             * + 연산자 : 두 항이 숫자일 때는 산술(+) 연산, 문자열일 때는 문자열 연결.
             * 
             * 연산자 오버로딩 : (검색)
             */

            string addMessage = "String " + "plus" + "string";
            Console.WriteLine(addMessage);

            /**
             * 할당 연산자(Assigment operator)
             * 변수에 데이터를 대입하는 데 사용.
             * 대입 연산자라고도 한다.
             * C#에서 = 기호는 같다는 의미가 아니라 오늘쪽에 있는 값 또는 식의 결과를 왼쪽 변수에 할당하라 지시하는 것.
             * 
             * ex) =, +=, -=, *=, /=, %=
             * 
             * 증감 연산자(Increment/Decrement operator)
             * 변수 값을 1 증가시키거나 1 감소 시키는 연산자.
             * 증감 연산자의 위치가 변수의 앞, 뒤에 따라 연산 처리 우선 순위 결정.
             * 
             * ++(증가 연산자) : 변수 값 + 1
             * --(감소 연산자) : 변수 값 - 1
             * 
             * 변수의 앞에 붙으면 전위 증감 연산자, 뒤에 붙으면 후위 증감 연산자.
             * 
             * 전위(Prefix) 증감 연산자 :  정수형 변수 앞에 연산자가 위치, 변수 값을 미리 증감한 후 나머지 연산을 수행.
             * 후위(Postfix) 증감 연산자 : 정수형 변수 뒤에 연산자가 위치, 연산을 수행한 뒤 변수 값을 증감.
             * 
             */

            int number = 3;
            number += 2;
            Console.WriteLine(number);
            --number;
            Console.WriteLine(number);
            number = 3;
            Console.WriteLine(number++);
            Console.WriteLine(number);

            number = 0;
            number = number++;
            Console.WriteLine(number);
            // 메모리 소멸(가비지컬렉터)에 의해 0이 된다.

            number = 0;
            number = (number++);
            Console.WriteLine(number);
            // 역시 메모리 소멸에 의해 0이 된다.

            // 값 타입 연산! 무거운 연산!(검색해봐야함)

            /**
             * 관계형 연산자(Relational operator) 또는 비교 연산자(Comparative operator)
             * 두 항이 큰지, 작은지, 같은지 등을 비교하는 데에 사용.
             * 결과값은 논리 데이터 형식인 참(True), 거짓(False)으로 출력.
             * ex) <, <=, >, >=, ==, !=
             * 
             * 논리 연산자(Logical operator)
             * 논리곱(AND) 논리합(OR) 논리부정(NOT)의 조건식에 대한 논리 연산을 수행.
             * 연산의 결과값은 참, 거짓의 bool 형식으로 반환되어 Boolean 연산자라고도 한다.
             * ex) &&, ||, !
             * (표 이미지 삽입)
             * 
             * 비트 연산자(Bit operator)
             * 정수형 데이터의 값을 이진수 비트 단위로 연산을 수행할 때 사용.
             * ex) &, |, ^, ~
             * 
             * 시프트 연산자(Shift operator)
             * 정수 데이터가 담겨있는 메모리의 비트를 왼쪽 또는 오른쪽으로 지정한 비트만큼 이동.
             * ex) <<, >>
             * 
             * 조건 연산자(Conditional operator)
             * 조건에 따라서 참일 때와 거짓일 때 결과를 다르게 반환.
             * (조건식) ? (식1 또는 값1) : (식2 또는 값2) 형태의 연산자.
             * if~else문의 축약형.
             * 
             */

            bool isBigger = false;
            isBigger = (5 == 10) && (5 < 10);
            Console.WriteLine(isBigger);
            isBigger = !isBigger;
            Console.WriteLine(isBigger);

            int bitNumber = 10;
            int bitResult = 0;
            bitResult = bitNumber & 0b0010;
            Console.WriteLine("bitNumber가 0010 상태를 가지고 있나요? -> {0}",bitResult);
            // 해당 스테이터스 값이 있는지 체크하는 등으로 사용.
            // 최적화 시 사용!

            bitNumber = 10;
            bitResult = 0;
            bitResult = bitNumber >> 1;
            Console.WriteLine("10을 이진수로 변환해 1들을 오른쪽으로 밀면 10진수로 무슨 숫자가 나오나요? -> {0}", bitResult);

            /* 나열(콤마) 연산자
             * 콤마를 구분자로 하여 한 문장에 변수 여러 개를 선언할 때 사용.
             */

            int intNum1, intNum2;

            /**
             * sizeof 연산자
             * 단항 연산자.
             * 데이터 형식 자체의 크기를 구하는 데에 사용.
             * sizeof([데이터 타입]) 형태로 사용, 운영 체제와 CPU 아키텍처의 종류에 따라 결과값이 다를 수 있다.
             */

            Console.WriteLine("int의 메모리 크기는 {0} 바이트입니다.", sizeof(int));

            /**
             * 연산자 우선순위
             * 연산자 여러 개를 함께 사용할 때, 연산자 우선순위(Precedence)에 따라 계산.
             * 연산자 우선순위를 잘 모를 때는 일단 괄호 연산자 사용 연습.
             */

            // 사용자에게 주어, 동사, 목적어를 각각 물어보고 이것들을 합하여 (주어 + 동사 + 목적어) 형태로 출력하는 프로그램을 작성해보자.
            /*
            Console.WriteLine("주어를 입력해주세요.");
            string userSubject = Console.ReadLine();
            Console.WriteLine("동사를 입력해주세요.");
            string userVerb = Console.ReadLine();
            Console.WriteLine("목적어를 입력해주세요.");
            string userObject = Console.ReadLine();

            Console.WriteLine($"주어 : {userSubject}");
            Console.WriteLine($"동사 : {userVerb}");
            Console.WriteLine($"목적어 : {userObject}");
            Console.WriteLine($"{userSubject} {userVerb} a {userObject}");
            */

            // 사용자의 나이를 물어보고 10년 후에 몇살이 되는지를 출력하는 프로그램을 작성
            /*
            Console.WriteLine("나이를 입력해주세요.");
            int userAge;
            int.TryParse(Console.ReadLine(), out userAge);
            Console.WriteLine($"나이 : {userAge}");
            Console.WriteLine($"-> 10년 후에는 {userAge+10} 살이 된다.");
            */

            // 직각 삼각형의 빗변이 아닌 양 변 길이를 읽어서 빗변의 길이를 계산하는 프로그램을 작성
            /*

            Console.WriteLine("첫번째 변의 길이를 입력해주세요.");
            int userline1;
            int.TryParse(Console.ReadLine(), out userline1);

            Console.WriteLine("두번째 변의 길이를 입력해주세요.");
            int userline2;
            int.TryParse(Console.ReadLine(), out userline2);

            double line3 = (userline1 * userline1 + userline2 * userline2);
            Console.WriteLine("빗변의 길이 : "+Math.Sqrt(line3));
            */

            // 상자의 길이(Length), 너비(Width), 높이(Height)를 입력하라는 메시지를 표시하고,
            // 상자의 부피와 표면적을 계산하여 출력하는 프로그램을 작성한다.

            Console.WriteLine("상자의 길이를 입력해주세요.");
            int Length;
            int.TryParse(Console.ReadLine(), out Length);
            Console.WriteLine("상자의 너비를 입력해주세요.");
            int Width;
            int.TryParse(Console.ReadLine(), out Width);
            Console.WriteLine("상자의 높이를 입력해주세요.");
            int Height;
            int.TryParse(Console.ReadLine(), out Height);

            Console.WriteLine($"길이 : {Length}");
            Console.WriteLine($"너비 : {Width}");
            Console.WriteLine($"높이 : {Height}");

            int volume = Length * Width * Height;
            int surface = ((Length * Width)+(Length* Height)+(Width*Height))*2;

            Console.WriteLine($"상자의 부피 : {volume}");
            Console.WriteLine($"상자의 겉넓이 : {surface}");

            // 우리나라에서 많이 사용되는 면적의 단위인 평방미터로 환산하는 프로그램을 작성

            Console.WriteLine("평 수를 입력해주세요.");
            float pyeong;
            float.TryParse(Console.ReadLine(), out pyeong);
            float pyeongMeter = pyeong * 3.3058f;
            Console.WriteLine($"평 수 : {pyeong}");
            Console.WriteLine($"평방미터 : {pyeongMeter} m^2");

            // 시, 분, 초로 표현된 시간을 초 단위의 시간으로 변환하는 프로그램을 작성
            Console.WriteLine("시를 입력해주세요.");
            int hour;
            int.TryParse(Console.ReadLine(), out hour);
            int hourToSecond = hour * 3600;
            Console.WriteLine("분을 입력해주세요.");
            int minute;
            int.TryParse(Console.ReadLine(), out minute);
            int minuteToSecond = minute * 60;
            Console.WriteLine("초를 입력해주세요.");
            int second;
            int.TryParse(Console.ReadLine(), out second);
            int allSecond = hourToSecond+minuteToSecond+second;
            Console.WriteLine($"시 : {hour}");
            Console.WriteLine($"분 : {minute}");
            Console.WriteLine($"초 : {second}");
            Console.WriteLine($"전체 초 : {allSecond}");

            // 퀴즈, 중간고사, 기말고사의 성적을 사용자로부터 입력받아 성적 총합을 계산하는 프로그램을 작성
            // 퀴즈 1~3+중간고사+기말고사 총합

            int Quiz1, Quiz2, Quiz3, Midterm, Final;
            Console.WriteLine("퀴즈#1의 점수를 입력해주세요.");
            int.TryParse(Console.ReadLine(), out Quiz1);
            Console.WriteLine("퀴즈#2의 점수를 입력해주세요.");
            int.TryParse(Console.ReadLine(), out Quiz2);
            Console.WriteLine("퀴즈#3의 점수를 입력해주세요.");
            int.TryParse(Console.ReadLine(), out Quiz3);
            Console.WriteLine("중간고사의 점수를 입력해주세요.");
            int.TryParse(Console.ReadLine(), out Midterm);
            Console.WriteLine("기말고사의 점수를 입력해주세요.");
            int.TryParse(Console.ReadLine(), out Final);

            string QuizLine = "퀴즈";
            string QuizNum1 = "#1";
            string QuizNum2 = "#2";
            string QuizNum3 = "#3";
            string MidtermNum = "중간고사";
            string FinalNum = "기말고사";
            string score1 = Quiz1.ToString()+"점";
            string score2 = Quiz2.ToString() + "점";
            string score3 = Quiz3.ToString() + "점";
            string score4 = Midterm.ToString() + "점";
            string score5 = Final.ToString() + "점";

            int sum = Quiz1 + Quiz2 + Quiz3 + Midterm + Final;
            string sumScore = "총점 : "+sum.ToString().PadLeft(11) + "점";

            Console.WriteLine(QuizLine.PadLeft(5) + QuizNum1.PadLeft(8)+score1.PadLeft(7));
            Console.WriteLine(QuizLine.PadLeft(5) + QuizNum2.PadLeft(8)+score2.PadLeft(7));
            Console.WriteLine(QuizLine.PadLeft(5) + QuizNum3.PadLeft(8)+score3.PadLeft(7));
            Console.WriteLine(MidtermNum.PadLeft(7) + score4.PadLeft(11));
            Console.WriteLine(FinalNum.PadLeft(7) + score5.PadLeft(11));
            Console.WriteLine(" =========================");
            Console.WriteLine(sumScore.PadLeft(20));
            Console.WriteLine(" =========================");

        }
    }
}