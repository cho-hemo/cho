using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsInterface
{
    public class InterfaceInfo
    {
        /**
         * 인터페이스(Interface)
         * 큰 규모의 프로그램 작성시 뼈대 구성에 필요.
         * 전체 프로그램의 설계도에 대한 명세서를 작성 가능.
         * 프로그램의 표준 규약을 정하고 따를 수 있도록 강제.
         * 클래스에서 구현해야하는 관련 기능의 정의가 포함된 개념.
         * 클래스 또는 구조체에 포함될 수 있는 관련있는 메서드들을 묶어 관리.
         * 인터페이스를 상속받아 그 내용을 구현하는 클래스는 인터페이스에 선언된 멤버(속성, 메서드 등)가
         * 반드시 구현되어있다는 보증을 한다.
         * 
         *  - interface 키워드를 사용
         *  - 실행가능한 코드와 데이터를 포함
         *  - 추상 클래스처럼 다른 클래스에 멤버 이름을 미리 정의할 때 사용.
         *  - 추상 클래스와 다른 점 : 멤버 내용을 구현하지 않고 멤버 이름만 정의
         *  - 인터페이스에는 메서드, 속성, 인덱서 및 이벤트를 정의할 수 있다.
         *  - 현실에서 전 세계 표준과 같은 기능.
         *  - 단일 상속만 지원하는 클래스와 달리 다중 상속 가능.
         *  - 인터페이스 멤버는 액세스 한정자를 붙이지 않음
         *    (항상 public 사용. virtual 및 static 키워드 사용 불가)
         *  - C#에서 인터페이스의 이름은 대문자 I로 시작
         *  - 인스턴스화 되지 않음. 클래스 사용해서 인스턴스화.
         *  - 계약(Contract) 의미가 강하며 속성, 메서드, 이벤트, 인덱서 등 구조를 미리 정의.
         *  
         * 추상적 : 구성물의 내용이 정해져 있지 않음
         * 클래스 < 추상클래스 < 인터페이스
         */

        /**
         * 인터페이스를 사용한 다중 상속 구현
         * 클래스 하나를 콤마로 구분해서 인터페이스 하나 이상을 상속하는 것을 의미.
         * C#에서 클래스-클래스는 단일 상속만 지원.
         * 인터페이스-클래스는 인터페이스 하나 이상 상속 가능.
         */

        /**
         * 인터페이스와 추상 클래스 비교하기
         * 
         * 추상 클래스
         *  - 메서드 시그니처만 있지 않고 사용 가능한 구현된 메서드로 들어온다.
         *  - 단일 상속 : 기본 클래스에서 상속될 수 있다.
         *  - 각 멤버는 액세스 한정자를 갖는다.
         *  - 필드, 속성, 생성자, 소멸자, 메서드, 이벤트, 인덱서 등을 갖는다.
         *  
         * 인터페이스
         *  - 규약, 명세서
         *  - 구현된 코드가 없다.
         *  - 다중 상속 : 여러가지 인터페이스에서 상속 가능
         *  - 모든 멤버는 자동으로 public
         *  - 속성, 메서드, 이벤트와 대리자를 멤버로 갖는다.
         */

    }       // class InterfaceInfo

    interface ICar
    {
        public void Go();     // 직진 명령 함수 반드시 포함이라는 뜻. 내용을 정의하지 않음
    }       // interface ICar

    class Car : ICar
    {
        public virtual void Go()
        {
            Console.WriteLine("자동차 직진!");
            Console.WriteLine("인터페이스의 모든 멤버를 반드시 포함(구현)");
        }
    }       // class Car

    class Sonata : Car
    {
        public override void Go()
        {
            base.Go();
            Console.WriteLine("소나타 전진!!!");
        }
    }       // class Sonata


    interface IAnimal
    {
        void Eat();
    }
    interface IDog
    {
        void Yelp();
    }

    class Dog : IAnimal, IDog
    {
        public void Eat()
        {
            Console.WriteLine("왐냠냠");
        }

        public void Yelp()
        {
            Console.WriteLine("컼컹컹!!!");
        }
    }
}
