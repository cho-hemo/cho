using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsParameter
{
    public class ParameterDesc
    {
        public void Parameter()
        {
            /**
             * 메서드의 매개변수 전달 방식
             * 
             *  - 값 전달 방식
             *      값을 그대로 복사해서 전달. 지금까지 사용하던 것.
             *      
             *  - 참조형 전달 방식(ref 키워드 사용)
             *      실제 데이터는 매개변수가 선언된 쪽에서만 저장
             *      호출된 메서드에서는 참조만 하는 형태로 변수 이름만 전달
             *      (원본도 수정할 수 있다!)
             *      
             *  - 반환형 전달 방식(out 키워드 사용)
             *      호출하는 쪽에서는 선언만, 초기화 하지 않고 전달.
             *      메서드에서 해당 데이터를 초기화해서 넘겨주는 방식
             *      (역시 원본도 수정할 수 있다!)
             *      (예) TryParse
             *      
             *  - 가변형 전달 방식(params 키워드 사용)
             *      같은 타입으로 하나 이상 받을 수 있게 배열형으로 받는다.
             *      가변 길이 매개변수는 매개변수 선언시 마지막에 위치
             */
        }       // Parameter()

        public void ValueTypeParam(int firstNumber, int secondNumber)
        {
            int temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;
            Console.WriteLine($"첫번째 : {firstNumber} 두번째 : {secondNumber}");
        }
        public void RefTypeParam(ref int firstNumber, ref int secondNumber)
        {
            int temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;
            Console.WriteLine($"첫번째 : {firstNumber} 두번째 : {secondNumber}");
        }
        public void OutTypeParam(out int firstNumber, out int secondNumber)
        {
            firstNumber = 100;
            secondNumber = 200;
            Console.WriteLine($"첫번째 : {firstNumber} 두번째 : {secondNumber}");
        }
        public void FlexibleTypeParam(params int[] numbers)
        {
            foreach(int i in numbers)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
        }
    }
}
