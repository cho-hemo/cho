using System;

namespace WhatIsProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // 한줄 주석
            /*
             * 여러줄 주석
             * 주석 : 코드로 인식하지 않으며 메모와 동일(=comment).
             */
            /**
             * 컴퓨터는 하드웨어 + 소프트웨어
             * 하드웨어 : 물리적 장치
             * 소프트웨어 : 하드웨어에 설치된 운영체제, 앱 등
             * 프로그램 : 원하는 작업을 컴퓨터에 전달하는 소프트웨어
             * 프로그래밍, 코딩 : 명령어(Instruction)들로 소프트웨어를 만드는 행위
             * 
             * 기계어(Machine language) : 컴퓨터가 알아듣는 언어. 초기의 컴퓨터는 프로그래밍도 기계어로 했다.
             * 프로그래밍 언어 : 기계어는 인간친화적이지 않기에 예약어와 문법으로 소프트웨어를 만들도록 구성된 언어.
             * 프로그래머, 개발자 : 프로그래밍 언어로 소프트웨어를 개발하는 사람.
             * 코드, 소스: 프로그래밍 언어의 문법에 맞게 작성된 명령 집합.
             * 컴파일 : 소스코드를 기계어로 번역하는 작업. 그런 작업을 하는 소프트웨어 - 컴파일러.
             * 
             * 프로그래밍 과정
             * 1. 텍스트 에디터로 소스 작성              ex) .cs 파일 등
             * 2. 소스 파일 컴파일 -> 실행 프로그램 생성   ex) .exe 파일 등
             * 3. 프로그램 실행
             * 빌드 : 1.과 2.를 합한 것.
             * 
             * 버그: 프로그래밍 중 발생한 오류
             * 디버그, 디버깅, 트러블슈팅 : 오류 탐색 및 수정 과정
             * 
             * C#의 경우
             * C# 언어로 코딩 ->IL(Intemediate Language)코드로 변환 -> 기계어
             * 
             * C#의 특징
             * 1. .Net을 위한 많은 언어 중 하나.
             * 2. 마이크로소프트의 닷넷 플랫폼 기반
             * 3. 절차적 언어 객체지향적 언어 특징
             * 4. 함수형 프로그래밍 스타일을 제공하는 다중 패러다임
             * 5. C, C++, Java, Javascript와 기초 문법의 유사함
             * 6. 자동 메모리 관리(Garbage collection 기능)
             * 7. 컴파일 기반 언어
             * 8. Strongly typed(엄격한 형식)의 언어 (ex)int와 char을 캐스트없이 호환 불가)
             * 9. Generic과 LINQ 등 편리한 기능 제공
             * 
             * .Net이란?
             * 소프트웨어 프레임워크.
             * 닷넷 프레임워크와 닷넷 코어를 합친 것.
             * 
             * 함수 : 프로그램에서 사용하기 위한 기능의 단위. 보통 하나의 함수 = 하나의 기능
             * 라이브러리 : 기능 구현 시 도움이 되는 기능, 함수의 모음.
             * API : 기능 구현 시 도움이 되도록 문서와 함께 제공되는 라이브러리, 함수 모음.
             * 플랫폼 : 프로그램을 실행하기 위한 배경 환경 또는 운영 체제.
             * 프레임워크 : 응용 프로그램의 개발 속도를 높이는 데 도움을 주는 API 및 서비스 모음.
             * 
             * C# 기본 코드 구조
             * class와 Main() 메서드 반드시 존재.
             * 하나 이상의 문(Statement)이 존재.
             * 상단 - 네임스페이스 선언부, Main() 메서드
             * 중괄호 시작과 끝을 사용해 프로그램 범위(Scope) 구분.
             * 
             * 네임스페이스 : 자주 사용하는 네임 스페이스 미리 선언.
             * Main() 메서드 : 프로그램의 시작 지점. 반드시 존재.
             * 중괄호({}) : 프로그램 범위를 구분.
             * 세미콜론(;) : 명령어(문, 문장)의 끝 표기.
             * 
             * Main() 메서드
             * 메서드(Method) : 클래스에서 제공하는 멤버 함수.
             * Main() 앞에 Static 키워드가 있어 개체 생성 없이 실행 가능.
             * Main() 메서드가 2개 이상 : 오류 - 프로그램 진입점이 2개 이상 정의되어있음 -> 컴파일 불가
             * 
             * 대, 소문자 구분 : C#은 대,소문자 구분하지 않으면 에러 발생.
             * 
             * 문법, 스타일, 패턴
             * 문법(Syntex) : 프로그래밍 언어의 규칙. 언어별 차이.
             * 스타일(Style) : 프로그래밍 가이드라인.
             * 패턴(Patten) : 자주 사용하는 규칙과 스타일 모음.
             * 
             * 정규화된 이름(Fully qualified names)은 아래와 같이 네임스페이스 이름과 형식 이름 전체를 지침.
             * 
             * 출력문 : 명령 프롬프트에 출력하는 구문
             * 주석문 : 실행에 영향이 없는 코드 설명문
             * 
             * 들여쓰기 : 프로그램 소스코드의 가독성을 위해서 사용하는 일반적인 들여쓰기 규칙.
             * 보통 4칸 공백 또는 Tab을 사용하지만 혼용해서는 안된다.
             * 
             * 공백처리 : C#에서 명령어 사이,기호와 괄호 사이의 공백, Tab, 줄바꿈은 무시.
             * 
             * 이스케이프 시퀸스 : Write Line() 메서드에서 사용되는 확장 문자.
             * 역슬래시 기호와 특정 문자 조합으로 특별한 기능.
             * 어떤 이스케이프 시퀸스? 검색하자.
             * 
             * 문자열 보간법(String interpolation) or 문자열 템플릿(String template)
             * - 문자열을 묶어서 처리하기 위한 기능.
             * - 기존에는 String.Format() 메서드 사용했었다.
             * - C# 6.0 버전부터 $"{}" 형태로 간결하게 제공.
             * 
             * 
             */
            const int TN = 3;
            const string ODD = "홀수";
            Console.WriteLine($"{TN}은(는) {ODD}입니다");

            // 구버전
            string strform = String.Format("{0}은(는) {1}입니다.",TN,ODD);
            Console.WriteLine(strform);

            // 속도가 느린 연산 방법
            string str = TN + "은(는) " + ODD + "입니다.";
            Console.WriteLine( str );

            // 예제
            string name = "이름 : 김초원";
            string cn = "과정명 : (게임콘텐츠제작) 모바일 게임 개발자 양성과정C";
            string pn = "학습교과 : 게임 프로그래밍 기초 기술";
            Console.WriteLine($"{name}\n{cn}\n{pn}");
            /**
             * 변수
             * - 데이터 값을 임시 보관해두는 곳.
             * 
             * 사용순서
             * 선언(메모리 공간 확보) -> 정의(대입, 할당)
             * 
             * 변수 선언 : 메모리에 데이터 저장 공간 확보.
             * 변수 정의 : 확보한 공간에 값 저장.
             * 변수 초기화 : 변수 선언 직후, 초기값 정의. 변수의 초기값을 명확하게 정의해 논리 오류 방지.
             * 
             */

            // Memory safety
            int number;     //선언
            number= 0;      //정의


            int trash;
            int number2 = 1; //초기화

            Console.WriteLine(number);
            Console.WriteLine(number2);
            Console.WriteLine("int는 얼마만큼의 메모리를 할당하나요?->{0}byte", sizeof(int));

            /**
             * bit : 0또는 1을 표현할 수 있는 최소 단위
             * byte : 숫자를 세는 단위. 8bit = 1byte
             * 
             * 변수 사용 시 주의사항(규칙)
             * 변수의 이름 짓기 : 변수의 첫 글자는 반드시 문자. 숫자는 첫 글자로 쓸 수 없다.
             * 길이는 255자 이하로, 공백을 포함할 수 없다.
             * 영문자와 숫자, 언더스코어 조합으로 사용하며 기타 특수 기호 사용 불가능.
             * C#에서 사용하는 키워드는 사용 불가.
             * 변수는 대,소문자를 구분, 일반적으로 소문자로 시작.
             * 변수는 타인이 보더라도 이해할 수 있는 이름이어야한다.
             * 
             * 데이터 형식
             * 변수에 저장할 수 있는 데이터 종류를 자료형이라고 한다.
             * 기본 형식: int,string,bool,object 등 C#에서 기본으로 제공하는 데이터 형식.
             * 
             * int 정수형
             * float 실수형 (부동소수점, 3.14)
             * char : 한문자형
             * bool : 논리값
             * string :문자열
             * obJect : C#의 모든 자료형의 부모형 데이터 타입.(모든 데이터 저장가능)
             * 
             * 상수와 리터럴
             * 
             * 상수
             * - 변수 선언시 앞에 const 키워드를 삽입 시 상수(Constant)가 된다.
             * - 한번 선언되면 다시 값을 바꿀 수 없다.
             * - 선언과 동시에 초기화 해야한다.
             * - const 키워드를 붙인 변수를 상수 또는 지역(Local) 상수라고 한다.
             * - 상수는 주로 대문자로 표현한다.
             * 
             * 리터럴
             * - 변수에 저장하기 위해 직접 대입하는 값 자체
             * - 정수형 리터럴 : 숫자 그대로 표현
             * - 실수형 리터럴 : 대문자 F 또는 소문자 f를 접미사로 붙여 표현
             * - 문자형 리터럴 : 작은 따옴표로 묶어서 표현
             * - 문자열 리터럴 : 큰 따옴표로 묶어서 표현
             * 
             * 숫자 구분자 사용
             * C# 7.0 버전부터는 언더스코어 문자를 사용하는 숫자 구분자(Digit separator)를 제공.
             * 숫자 형식을 표현할 때 언더스코어 문자는 무시한다.
             * 긴 숫자 표시 시에 가독성 상승.
             */

            int r = 5;
            const double PI = 3.14;
            double d = 2 * PI * r * r;
            Console.WriteLine($"반지름이 5인 원의 넓이 : {d}");

            /**
             * null 키워드 : '아무것도 없는 값'
             * null 가능 형식(Nullable) : 숫자 형식의 변수에서 inf? float?와 같이 물음표(?) 기호를 붙이기
             * null 가능 형식에는 null을 대입 가능.
             * 문자 형식에서는 원래 null 대입 가능.
             * 
             * 자동 타입 추론(Automatic type deduction)
             * 변수나 대입 값의 데이터 타입이 명시적이거나 명확할 때, 데이터 타입을 명시하지 않고 생략 가능.
             * 컴파일러가 대입하는 값, 변수의 데이터 타입으로 다른 한 쪽의 데이터 타입을 추론하는 기능.
             * 
             * default 값
             * C# 6.0 버전부터 자동 타입 추론으로 기본 형식에 default 값 대입 가능.
             * 기본 형식마다 정해진 default 값 존재.
             * 
             */

            int numberint = default;

            var autostring = "스트링치즈";

            /**
             * 열거형(Enumeration) 형식
             * 상수들을 이름 하나로 묶어 관리.
             * enum 키워드를 사용.
             * 이늄 또는 이넘으로 읽는다.
             * 클래스 범위 내에 정의, 메서드 범위 안에는 정의 할 수 없다.
             *  
             */
            Align align = Align.TOP;
            align = Align.RIGHT;

            Console.WriteLine("Enumeration 데이터 확인 -> {0}", align);

            /**
             * 입출력
             * 프로그램을 실행할 때마다 다른 값을 입력받으려면 콘솔에서 입력한 값을 변수에 저장할 수 있어야 한다.
             * 키보드로 입력받고 모니터로 출력하는 일반적인 내용 - 표준 입출력(Standard input/output)
             * 
             * System.Console.ReadLine() : 콘솔에서 한 줄을 입력받는다. 
             * System.Console.Read() : 콘솔에서 한 문자를 정수로 입력받는다.
             * System.Console.ReadKey() : 콘솔에서 다음 문자나 사용자가 누른 기능 키를 가져온다.
             */

            //Console.Write("이름을 입력하시오 : ");
            //string yourName = string.Empty;
            //yourName= Console.ReadLine();
            //
            //Console.WriteLine($"안녕하세요. {yourName}님.");
            /**
             * 형식 변환
             * Console.ReadLine() 메서드를 사용하여 콘솔에서 입력받은 데이터는 문자열이다.
             * 문자열 대신 정수나 실수 데이터를 입력받고 싶다면
             * 입력된 문자열을 원하는 데이터 형식으로 변환할 수 있어야 한다.
             * 
             * 키워드 : 캐스팅 연산자, 암시적(묵시적) 형변환, 명시적 형변환
             * 
             * 3가지의 형변환 하는 법
             */
            /*Console.Write("숫자를 입력하시오: ");
            string stringNumber = Console.ReadLine();       
            int intNumber = Convert.ToInt32(stringNumber);  //1
            int intNumber2 = int.Parse(stringNumber);       //2
            int intNumber3 = default;                       //3
            int.TryParse(stringNumber, out intNumber3);     //3 가장 추천하는 방법
            Console.WriteLine("입력한 숫자 + 10은 {0}입니다.", intNumber3 + 10);
            */

            Console.Write("반지름을 입력하시오: ");
            string userRadius = Console.ReadLine();
            const double PI2 = 3.14;
            double Radius = default;
            double.TryParse(userRadius, out Radius);
            double sphereOut = Radius * Radius * PI2 * 4;
            double sphereIn = Radius * Radius * Radius * PI2 * 1.33;
            Console.WriteLine($"반지름이 {userRadius}인 구의 겉넓이 : {sphereOut}, 부피 : {sphereIn}");

        } //Main
        enum Align { TOP, BOTTOM , LEFT, RIGHT }
    } //class Program
} // namespace WhatIsProgramming