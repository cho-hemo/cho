using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsDelegate
{
    public class Class1
    {
        // void 리턴타입과, 매개변수를 받지 않는 함수를 저장하는 데이터 타입을 선언
        delegate void SayDelegate();

        public void DelegateDesc()
        {
            /**
             * 대리자(Delegate)
             * 매개변수 목록 및 반환 형식이 있는 메서드 참조(포인터)를 나타내는 형식
             * Delegate 뜻 : 위임하다, 대신하다
             * 
             * delegate 키워드를 사용
             * 함수 자체를 데이터 하나로 보고 의미 그대로 다른 메서드를 대신 실행하는 기능
             * 한 번에 하나 이상을 대신해서 호출 가능
             * 
             *  - 자동차 개체 예시 : 대리운전기사(대리자)가 집까지 좌회전(), 우회전() 등 동작을 대신함
             *  - 메서드 매개변수로 대리자를 전달 가능
             *  - 대리자 사용으로 함수의 매개변수로 함수 자체를 전달 가능
             *  - 동일한 메서드 시그니처를 갖는 메서드 참조를 담는 그릇
             *  - 람다(Lambda)와 개념이 같다
             *  - 대리자 사용으로 함수 집합을 추후 실행하거나 실행 취소가 가능
             *  - 내부적으로 MulticastDelegate 클래스에서 기능을 상속
             *  - 이벤트(Event)를 만들어내는 중간 단계의 키워드로 존재
             */
            SayDelegate sayDelegate = Hi;

            sayDelegate.Invoke();

        }       // DelegateDesc()
        public void Hi()
        {
            Console.WriteLine("안!!!!뇽!!!!!!!!!");
        }
    }
}
