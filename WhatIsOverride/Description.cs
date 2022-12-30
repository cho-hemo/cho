using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsOverride
{
    public class Description
    {
        public void OverrideDesc()
        {
            /**
             * 메서드 오버라이드
             * 부모 클래스에 만든 메서드를 자식 클래스에서 다시 새롭게 만들어 사용하는 것
             * = 재정의
             * - 메서드를 새롭게 정의하는 것
             * - 오버라이드(Override), 오버라이딩(Overriding)
             * - 부모 클래스에서 virtual 키워드로 선언해 놓은 메서드는 자식 클래스에서
             *   override 키워드로 재정의 가능
             * 
             * 메서드 오버로드와 오버라이드
             * 오버로드 : 여러 번 정의
             * 오버라이드 : 다시 정의
             * 
             * 속성
             * 클래스 속성
             * private 성격이 있는 필드를 public 속성으로 외부에 공개할 때 사용
             * 
             */
        }       // OverrideDesc()
    }       // class Description

    public class Parent
    {
        protected int number = 100;

        public virtual void Say()
        {
            Console.WriteLine("[부모] 암쎄예~");
        }
        public virtual void Run()
        {
            Console.WriteLine("[부모] 달리다");
        }
        public virtual void Walk()
        {
            Console.WriteLine("[부모] 걷다");
        }
        public virtual void Walk(int count)
        {
            Console.WriteLine($"[부모] {count}번 걷다.");
        }
        public virtual void Walk(string where_)
        {
            Console.WriteLine($"[부모] {where_}에서 걷다.");
        }
    }       // class Parent
    public class Child : Parent
    {

        public override void Say()
        {
            Console.WriteLine("[자식] 암쎄야~");
        }
        public override void Run()
        {
            Console.WriteLine("[자식] 달리다");
            base.Run();
            Console.WriteLine($"number : {number}");
        }
        public override void Walk()
        {
            Console.WriteLine("[자식] 걷다");
        }

        public override void Walk(int count)
        {
            Console.WriteLine($"[자식] {count}번 걷다.");
        }
        public override void Walk(string where_)
        {
            Console.WriteLine($"[자식] {where_}에서 걷다.");
        }
    }       // class Child

    public class Button
    {
        int _index = 0;
        public virtual void OnClickButton()
        {
            Console.WriteLine($"{_index}번 버튼을 눌렀음");
        }       // OnClickButton();
    }
    public class storeButton : Button
    {
        
    }
    public class QuestButton : Button
    {

    }

}
