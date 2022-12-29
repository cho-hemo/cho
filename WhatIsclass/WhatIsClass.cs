using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsclass
{
    internal class WhatIsClass
    {
        public WhatIsClass()
        {
            /**
             * C#의 모든 코드에 반드시 들어가는 클래스(Class)
             * 
             * 클래스(Class)
             * 지금까지 작성한 모든 예제에서 기본이 되는 C#의 핵심 코드. 
             * public class [클래스 이름]
             * {
             *      - 내용
             * }
             * 위같은 코드 블록을 사용하여 정의
             * 클래스를 정의하는 전반적인 내용과 클래스 내외부에 올 수 있는 구성 요소는 다음 장에서.
             * 클래스의 구성 요소는 많지만, 그중 속성과 메서드를 가장 많이 사용.
             * 속성은 데이터를, 메서드는 로직을 다룬다.
             * - 클래스
             *  - 속성 : 데이터
             *  - 메서드 : 로직
             *  
             * 클래스는 그 의미에 따라 이미 닷넷 프레임워크에서 만들어 놓은 내장 형식(built-in type)과
             * 사용자가 직접 클래스 구조를 만드는 사용자 정의 형식(User defined type)으로 구분.
             * 내장 형식 : Console, String, Math 등 클래스
             * 사용자 데이터 형식 : class 키워드로 새로운 형식을 정의할 수 있는 것
             * 
             * 클래스 만들기
             * 클래스의 정의
             *  - 개체를 생성하는 틀(템플릿)
             *  - 무엇인가를 만들어내는 설계도
             *  - C# 프로그래밍의 기본 단위
             *  - 새로운 개체(실체)를 생성하는 설계도(청사진) 역할
             * 예)   자동차라는 개체(Object)를 만들려면 자동차 설계도가 필요
             *      -> 마찬가지로 프로그래밍에서도 설계도가 필요
             *      -> 그 역할을 하는 것이 클래스
             *      -> 개체를 생성하는 틀(템플릿), 뭔가를 만들어내는 설계도
             *      
             * 클래스 선언하기
             *  - 클래스 이름은 반드시 대문자로 시작
             * public class [클래스 이름]
             * {
             *      // 클래스 내용을 구현
             *      - 속성 -> 변수
             *      - 메서드 -> 함수
             * }
             * 
             * 
             * 클래스를 여러 개 사용할 때는 public 키워드를 사용.
             * 그 키워드가 붙은 클래스는 클래스 외부에서 해당 클래스를 바로 호출해서 사용할 수 있도록 공개함.
             * 반대 의미는 private 키워드.
             *  =접근 권한/보호 수준
             *  
             * static과 정적 메서드
             * C#에서는 static을 정적으로 표현한다.(=공유(Shared))
             * static이 붙는 클래스의 모든 멤버는 해당 클래스 내에서 누구나 공유해서 접근 가능.
             * 정적 메서드(=공유 메서드(Shared Method) :  메서드에 static이 붙는 메서드.
             * 
             * 정적 메서드와 인스턴스 메서드
             * 닷넷의 많은 API처럼 우리가 새롭게 만드는 클래스는 메서드를 포함한 각 멤버에 static 키워드
             * 유무에 따라 정적 또는 인스턴스 멤버가 될 수 있다.
             * 
             * 클래스 시그니처
             * 클래스가 가진 시그니처
             * 
             * public class Car {}
             * 
             * public 액세스 한정자를 사용하면 기본값인 internal을 갖는데
             * internal은 해당 프로그램 내에서 언제든지 접근 가능하다.
             * 하지만 학습 단계에서는 클래스에 public만 사용해도 괜찮다.
             *  
             * 클래스 이름 짓기
             * class 키워드 다음의 클래스 이름 조건 : 대문자로 시작하는 명사
             * 클래스 이름을 지을 때는 축약형이나 특정 접두사, 언더스코어(_) 같은 특수문자 사용X
             *  - 누구나 알기 쉽게
             *  - 간단하고 명확
             *  
             * 클래스의 주요 구성 요소
             * 시작과 끝, 클래스 블록 내에 포함 가능한 용어(개념)(=클래스 멤버)
             *  - 필드(Field) : 부품 역할, 클래스 내에 선언된 변수나 데이터를 담는 그릇, 개체 상태를 저장
             *  - 속성(Property) : 개체의 색상, 크기, 형태 등을 정의
             *  - 메서드(Method) : 개체 동작이나 기능을 정의
             *  - 생성자(Constructor) : 개체 필드 초기화. 개체 생성 시 미리 수행해야 할 기능을 정의
             *  - 소멸자(Destructor) : 개체를 모두 사용한 수 메모리에서 소멸될 때 실행할 기능을 정의
             *  
             * 액세스 한정자
             * 클래스 생성 시 붙는 public, private, internal, adstract, sealed 같은 키워드
             * 클래스에 접근할 수 있는 범위를 결정하는 데에 도움을 준다.
             * 특별히 지정하지 않는 한 기본적으로 public 액세스 한정자를 사용하면 된다.
             */
            Random random= new Random(); // 메모리 할당!
            int randNum = random.Next(1, 100 + 1); // 인스턴스 메서드

        }   // WhatIsClass()
    }   // class WhatIsClass

    public class ClassNote
    {
        public static void Run()
        {
            Console.WriteLine("ClassNote 클래스의 Run 메서드");
        }
        public void StaticMethod()
        {
            Console.WriteLine("ClassNote 클래스의 StaticMethod");
        }
        public void InstanceMethod()
        {
            Console.WriteLine("ClassNote 클래스의 InstanceMethod");
        }
    }   // class ClassNote()

}
