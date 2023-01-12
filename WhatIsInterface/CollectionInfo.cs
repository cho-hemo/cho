using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsInterface
{
    public class CollectionInfo
    {
        /**
         * 컬렉션
         * 배열처럼 특정 항목의 집합을 리스트 또는 컬렉션이라고 한다.
         * 배열, 리스트, 사전을 사용하여 관련 개체의 그룹을 만들고 관리
         * 
         * 배열과 컬렉션
         * C#에서 배열과 컬렉션, 리스트는 학습 레벨에서 동일하게 취급
         * 
         * 컬렉션 클래스
         * 데이터 항목의 집합을 메모리상에서 다루는 클래스
         * 간단(문자열)~복잡(특정 클래스 형식의 집합)
         * 
         * 세 가지의 자주 쓰는 컬렉션
         * 
         *  - 배열 : 일반적으로 숫자처럼 간단한 데이터 형식을 저장
         *  - 리스트 : 간단한 데이터 형식을 포함한 개체들을 저장
         *  - 사전(Dictionary) : 키와 값의 쌍으로 관리되는 개체들을 저장
         *  
         * 일반적으로 기본형 그룹을 배열로 보고, 새로운 타입(클래스)의 그룹을 컬렉션으로 비교하기도.
         *  
         *  - 배열 : 정수형, 문자열 등 집합을 나타낸다.
         *  - 컬렉션 : 개체의 집합을 나타낸다. 리스트, 집합(Set), 맵, 사전도 컬렉션과 같은 개념으로 사용.
         *  
         * 데이터를 그룹으로 묶어 관리할 때는 일반적으로 배열로 관리.
         * 배열은 크기가 고정. 새로운 데이터 추가 불가능.
         * 그런 단점을 제거한 것이 바로 컬렉션.
         * 
         *  - 컬렉션은 반복하여 사용할 수 있는 형식 안정성으로 크기를 동적으로 변경 가능.
         *  - 데이터를 조회, 정렬, 중복 제거, 이름과 값을 쌍으로 관리 등 장점
         *  
         * 닷넷에서는 컬렉션과 관련한 여러 클래스를 제공
         *  - Stack
         *  - Queue
         *  - ArrayList
         *  등이 있다.
         *  
         * 연결 리스트(Linked List) = 리스트
         * 선형 방식
         * Next 포인트만 있으면 싱글 링크드 리스트
         * Prev까지 있으면 더블 링크드 리스트
         * 
         * 사전(Dictionary)
         * 키와 값으로 구성되어 있다.
         * 트리 구조(이진트리)
         * 레드블랙트리(자가균형이진탐색트리) : 시작(Root)-달린 것들(Leaf)
         */
        public void Sample()
        {
            // 사전<키, 값>
            Dictionary<string, int> inventory = new Dictionary<string, int>();

            inventory.Add("빨간 포션", 10);
            inventory.Add("강철 검", 1);
            Console.WriteLine("인벤에 빨간 포션 개수 : "+inventory["빨간 포션"]);

            List<int> intList = new List<int>();
            intList.Add(1);
            intList.Add(89);
            intList.Add(6);
            intList.Add(70);
            intList.Sort();
            intList.Reverse();
            foreach (int item in intList)
            {
                Console.WriteLine(item);
            }
        }

        
        struct Node
        {
            int _index;
            int number;
            int adressNext;     // Next만 있으면 싱글 링크드 리스트!
            int adressPrev;     // 둘 다 있으면 더블 링크드 리스트!

        }

    }   // class CollectionInfo
}
