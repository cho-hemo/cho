using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static WhatIsclass.Program;

namespace WhatIsclass
{
    public class Description
    {
        private string _strfield = "그럿게됏다";
        public void ValueTypeAndReferenceType()
        {
            /**
             * 값 형식과 참조 형식(Value type & Reference type)
             * 클래스나 구조체 같은 데이터 형식을 구분짓는 기준 중 하나
             * 
             * 값 형식
             * 개체에 값 자체를 담도 있는 구조
             * int, double 등
             * 
             * 참조 형식
             * 개체가 값을 담고 있는 또 다른 개체를 포인터로 바라보는 구조
             * 여러 값이 동일한 개체를 가리킬 수 있다.
             * 
             * 박싱과 언박싱
             * 박싱(Boxing) : 값 형식의 데이터를 참조 형식의 데이터로 변경하는 것
             * 예) 정수 형식의 데이터를 오브젝트 형식의 변수에 담는 형태
             * 
             * int num = 1234;
             * object obVal = num;
             * 
             * 스택 메모리 영역에 저장된 값 형식의 데이터를 힙 메모리 영역에 저장하는 단계를 거치기 때문에 
             * 시간과 공간이 소비되는 비용이 발생한다.
             * 
             * 언박싱(Unboxing)(=캐스트/캐스팅(Cast/Casting)
             *      참조 형식의 데이터를 값 형식의 데이터로 변경하는 것
             * 예) 오브젝트 변수에 저장된 4321을 실제 정수 형식의 데이터로 변환
             * 
             * object obVal = 4321;
             * int num = (int)obVal;
             * 
             * object 형 변수에 들어있는 데이터 중 숫자 형식의 데이터는 바로 int 형 변수에 대입 불가
             * 대입하려면 형식 변환 필요
             * 캐스팅이나 Convert 클래스 같은 변환 API 명시적으로 사용
             * 
             */

            object obVal;
            char charVal = 'a';
            int intVal = 97;
            char charVal2;

            obVal = charVal;
            charVal2 = (char)obVal;
            Console.WriteLine(charVal2);

        }       // ValueTypeAndReferenceType()
        public void WhatIsField()
        {
            /**
             * 필드(Field)
             * 클래스의 부품 역할을 하는 클래스 내부 상태 값을 저장해 놓는 그릇
             * 자동차 클래스 => 자동차 부품(필드)
             * 클래스 내에서 선언된 변수 또는 배열 등을 의미
             * 대부분 private 액세스 한정자(Access modifier)가 붙는다.
             * 선언 후 초기화 하지 않아도 자동으로 초기화.
             * int 형 -> 0 / string 형 -> 공백
             * 
             * 지역 변수와 전역 변수
             * 지역 변수(Local variable) : 메서드 내에서 변수 선언
             *      메서드가 종료되면 자동으로 소멸. 중괄호 내에만 살아있다.
             *      일반적으로 변수 = 지역 변수
             * 전역 변수(Global variable) : 메서드 밖에서 메서드와 동등한 레벨로 변수 선언
             *      (=필드(그러나 위의 필드와 다른))
             *      클래스 내에 선언된 변수.
             *      소문자 또는 언더스코어(_)로 시작.
             * 
             */
        }
        public void WhatIsConstructor() 
        {
            /**
             * 생성자(Constructor)
             * 클래스에서 맨 먼저 호출되는 메서드, 클래스 기본값 등을 설정
             * 자동차 클래스 => 자동차 시동 걸기(생성자)
             * 생성하지 않으면 숨어있다.
             * 개체를 생성하면서 무엇인가를 하고자 할 때 사용되는 메서드.
             * 개체를 초기화(주로 클래스 내 필드)하는 데에 사용
             * 생성자 이름 규칙 : 클래스 이름과 동일
             * 
             * - 매개변수가 없는 기본 생성자
             * - 매개변수를 원하는 만큼 정의(리턴값 없음)
             * - static 생성자(정적 생성자)와 public 생성자(인스턴스 생성자)로 구분
             * - 주로 인스턴스 생성자 사용.
             */
        }
        public void WhatIsDestructor()
        {
            /**
             * 소멸자(Destructor) 또는 종료자(finalizer)
             * 가비지 수집기에서 클래스의 인스턴스를 사용한 수 최종 정리할 때 가장 늦게 호출되는 메서드
             * - 소멸자는 클래스 이름과 동인한 메서드 앞에 ~(틸드)를 붙여 만든다.
             * - 생성자와 달리 매개변수 받을 수 없음
             * - 오버로딩 지원 불가, 직접 호출 불가능
             * 
             */
        }
        public void WhatIsInheritance() 
        {
            /**
             * 개체 관계 프로그래밍(Object relationship)
             * 클래스간 부모와 자식 관계를 설정
             * 
             * 클래스 상속하기
             * 상속 : 부모 클래스에서 정의된 기능을 다시 사용하더나 확장 또는 수정하여 자식 클래스로 만드는 것
             *  부모 클래스의 모든 멤버를 자식 클래스가 재사용하도록 허가
             *  계층적인 관계
             * 단일 상속(Single Inheritance) - C# 기본 지원
             * 다중 상속(Multiple Inheritance) - 인터페이스로 지원
             * 
             * 클래스 상속 구문
             * public class [기본 클래스 이름]
             * {
             *      // 기본 클래스 멤버를 정의
             * }
             * public class [파생 클래스 이름] : [기본 클래스 이름]
             * {
             *      // 기본 클래스의 멤버를 포함한 자식 클래스의 멤버를 정의
             * }
             * 
             * - System.Object 클래스 : 모든 클래스의 부모 클래스
             *      닷넷에서 가장 높은 계층에 속하는 시조(조상) 클래스
             *      새로이 만드는 C#의 모든 클래스는 자동으로 Object 클래스에서 상속받기에
             *      상속 코드 생략 가능
             * - 기본(Base) 클래스 :
             *      =Base 클래스, Super 클래스, 부모 클래스
             * - 파생(Derived) 클래스 : 멤버를 물려받는 클래스
             *      =Derived 클래스, Sub 클래스, 자식 클래스
             * 
             * 부모 클래스의 public, protected로 선언된 멤버 상속가능
             * private로 선언된 멤버는 상속X
             * 
             */
        } // WhatIsInheritance() 

    } // class Description

    //class Parent
    //{
    //    public string strVal = "부모클래스멤버변수";
    //    public void Print()
    //    {
    //        Console.WriteLine("부모클래스의출력");
    //    }
    //}
    //class child : Parent
    //{
    //    public void PrintChild()
    //    {
    //        Console.WriteLine(base.strVal);     // base 안 붙여도 됨
    //        Console.WriteLine("자식클래스의출력");
    //    }
    //}

    class Monster
    {
        public string name;
        public int hp;
        public int damage;
        public int defence;
        public string dropItem;
        public int monsterDamage = 0;
        public int monsterDefence = 0;
        Random random = new Random();

        public void Make()
        {
            Console.WriteLine($"체력 {hp}의 {name}이(가) 등장했다.");
        }
        public void Attack()
        {
            monsterDamage = random.Next(0, damage + 1);
        }
        public void Guard()
        {
            monsterDefence = random.Next(0, defence + 1);
        }

    }
    class Slime : Monster
    {
        public Slime()
        {
            name = "귀여운 슬라임";
            hp = 20;
            damage = 10;
            defence = 1;
            dropItem = "슬라임 점액";
        }
    }
    class Hop : Monster
    {
        public Hop()
        {
            name = "양철 나무꾼";
            hp = 10;
            damage = 3;
            defence = 3;
            dropItem = "낡은 심장 조각";
        }
    }
    class Pop : Monster
    {
        public Pop()
        {
            name = "카드 병정";
            hp = 10;
            damage = 7;
            defence = 3;
            dropItem = "벼려진 창 끝";
        }
    }
    class Pe : Monster
    {
        public Pe()
        {
            name = "파랑새";
            hp = 10;
            damage = 5;
            defence = 5;
            dropItem = "행운의 클로버";
        }
    }

    class Player
    {
        public string name = "용사";
        public int hp = 20;
        public int damage = 10;
        public int defence = 3;
        public string[] inven = new string[10];

        public int playerDamage = 0;
        public int playerDefence = 0;
        Random random = new Random();


        public void Attack()
        {
            playerDamage = random.Next(0, damage + 1);
        }       // Attack()
        public void Guard()
        {
            playerDefence = random.Next(0, defence + 1);
        }
    }       // class Player

    class Battle
    {
        public Battle()
        {
            Random random= new Random();
            int make = 0;
            int kill = 0;
            bool run = false;
            Player player= new Player();
            Slime slime;
            Hop hop;
            Pop pop;
            Pe pe;
            ConsoleKeyInfo checkKey;

            while (player.hp > 0 && kill < 10 && !run)
            {
                Console.Clear();
                make = random.Next(0, 4);
                switch (make)
                {
                    case 0:
                        slime = new Slime();
                        while (slime.hp > 0)
                        {
                            Console.Clear();
                            slime.Make();
                            Thread.Sleep(600);
                            player.Attack();
                            Console.WriteLine($"{player.name}이(가) {slime.name}을(를) {player.playerDamage}(으)로 공격했다!");
                            Thread.Sleep(600);
                            slime.Guard();
                            Console.WriteLine($"{slime.name}의 방어! {slime.monsterDefence}의 대미지를 가드했다.");
                            Thread.Sleep(600);
                            if (player.playerDamage > slime.monsterDefence)
                                slime.hp = slime.hp - (player.playerDamage - slime.monsterDefence);
                            Console.WriteLine($"{slime.name}의 체력 : {slime.hp}");
                            Thread.Sleep(600);

                            if (slime.hp <= 0)
                            {
                                /* Do Nothing */
                            }
                            else
                            {
                                slime.Attack();
                                Console.WriteLine($"{slime.name}이(가) {player.name}을(를) {slime.monsterDamage}(으)로 공격했다!");
                                Thread.Sleep(600);
                                player.Guard();
                                Console.WriteLine($"{player.name}의 방어! {player.playerDefence}의 대미지를 가드했다.");
                                Thread.Sleep(600);
                                if (slime.monsterDamage > player.playerDefence)
                                    player.hp = player.hp - (slime.monsterDamage - player.playerDefence);
                                Console.WriteLine($"{player.name}의 체력 : {player.hp}");
                            }
                            if (player.hp <= 0)
                            {
                                break;
                            }
                            if (slime.hp <= 0)
                            {
                                Console.WriteLine($"{slime.name}을(를) 무찔렀다!");
                                Console.WriteLine($"{slime.dropItem}을(를) 얻었다.");
                                player.inven[kill] = slime.dropItem;
                                kill++;
                            }
                            Thread.Sleep(600);
                            Console.WriteLine($"더 싸우시겠습니까? Y/N");
                            checkKey = Console.ReadKey(true);
                            if (checkKey.Key == ConsoleKey.Y)
                            {
                                /* Do Nothing */
                            }
                            else
                            {
                                run = true;
                                break;
                            }
                        }
                        break;
                    case 1:
                        hop = new Hop();
                        while (hop.hp > 0)
                        {
                            Console.Clear();
                            hop.Make();
                            Thread.Sleep(600);
                            player.Attack();
                            Console.WriteLine($"{player.name}이(가) {hop.name}을(를) {player.playerDamage}(으)로 공격했다!");
                            Thread.Sleep(600);
                            hop.Guard();
                            Console.WriteLine($"{hop.name}의 방어! {hop.monsterDefence}의 대미지를 가드했다.");
                            Thread.Sleep(600);
                            if (player.playerDamage > hop.monsterDefence)
                                hop.hp = hop.hp - (player.playerDamage - hop.monsterDefence);
                            Console.WriteLine($"{hop.name}의 체력 : {hop.hp}");
                            Thread.Sleep(600);

                            if (hop.hp <= 0)
                            {
                                /* Do Nothing */
                            }
                            else
                            {
                                hop.Attack();
                                Console.WriteLine($"{hop.name}이(가) {player.name}을(를) {hop.monsterDamage}(으)로 공격했다!");
                                Thread.Sleep(600);
                                player.Guard();
                                Console.WriteLine($"{player.name}의 방어! {player.playerDefence}의 대미지를 가드했다.");
                                Thread.Sleep(600);
                                if (hop.monsterDamage > player.playerDefence)
                                    player.hp = player.hp - (hop.monsterDamage - player.playerDefence);
                                Console.WriteLine($"{player.name}의 체력 : {player.hp}");
                            }
                            if (player.hp <= 0)
                            {
                                break;
                            }
                            if (hop.hp <= 0)
                            {
                                Console.WriteLine($"{hop.name}을(를) 무찔렀다!");
                                Console.WriteLine($"{hop.dropItem}을(를) 얻었다.");
                                player.inven[kill] = hop.dropItem;
                                kill++;
                            }
                            Thread.Sleep(600);
                            Console.WriteLine($"더 싸우시겠습니까? Y/N");
                            checkKey = Console.ReadKey(true);
                            if (checkKey.Key == ConsoleKey.Y)
                            {
                                /* Do Nothing */
                            }
                            else
                            {
                                run = true;
                                break;
                            }
                        }
                        break;
                    case 2:
                        pop = new Pop();
                        while (pop.hp > 0)
                        {
                            Console.Clear();
                            pop.Make();
                            Thread.Sleep(600);
                            player.Attack();
                            Console.WriteLine($"{player.name}이(가) {pop.name}을(를) {player.playerDamage}(으)로 공격했다!");
                            Thread.Sleep(600);
                            pop.Guard();
                            Console.WriteLine($"{pop.name}의 방어! {pop.monsterDefence}의 대미지를 가드했다.");
                            Thread.Sleep(600);
                            if (player.playerDamage > pop.monsterDefence)
                                pop.hp = pop.hp - (player.playerDamage - pop.monsterDefence);
                            Console.WriteLine($"{pop.name}의 체력 : {pop.hp}");
                            Thread.Sleep(600);

                            if (pop.hp <= 0)
                            {
                                /* Do Nothing */
                            }
                            else
                            {

                                pop.Attack();
                                Console.WriteLine($"{pop.name}이(가) {player.name}을(를) {pop.monsterDamage}(으)로 공격했다!");
                                Thread.Sleep(600);
                                player.Guard();
                                Console.WriteLine($"{player.name}의 방어! {player.playerDefence}의 대미지를 가드했다.");
                                Thread.Sleep(600);
                                if (pop.monsterDamage > player.playerDefence)
                                    player.hp = player.hp - (pop.monsterDamage - player.playerDefence);
                                Console.WriteLine($"{player.name}의 체력 : {player.hp}");
                            }
                            if (player.hp <= 0)
                            {
                                break;
                            }
                            if (pop.hp <= 0)
                            {
                                Console.WriteLine($"{pop.name}을(를) 무찔렀다!");
                                Console.WriteLine($"{pop.dropItem}을(를) 얻었다.");
                                player.inven[kill] = pop.dropItem;
                                kill++;
                            }
                            Thread.Sleep(600);
                            Console.WriteLine($"더 싸우시겠습니까? Y/N");
                            checkKey = Console.ReadKey(true);
                            if (checkKey.Key == ConsoleKey.Y)
                            {
                                /* Do Nothing */
                            }
                            else
                            {
                                run = true;
                                break;
                            }
                        }
                        break;
                    case 3:
                        pe = new Pe();
                        while (pe.hp > 0)
                        {
                            Console.Clear();
                            pe.Make();
                            Thread.Sleep(600);
                            player.Attack();
                            Console.WriteLine($"{player.name}이(가) {pe.name}을(를) {player.playerDamage}(으)로 공격했다!");
                            Thread.Sleep(600);
                            pe.Guard();
                            Console.WriteLine($"{pe.name}의 방어! {pe.monsterDefence}의 대미지를 가드했다.");
                            Thread.Sleep(600);
                            if (player.playerDamage > pe.monsterDefence)
                                pe.hp = pe.hp - (player.playerDamage - pe.monsterDefence);
                            Console.WriteLine($"{pe.name}의 체력 : {pe.hp}");
                            Thread.Sleep(600);
                            if (pe.hp <= 0)
                            {
                                /* Do Nothing */
                            }
                            else
                            {
                                pe.Attack();
                                Console.WriteLine($"{pe.name}이(가) {player.name}을(를) {pe.monsterDamage}(으)로 공격했다!");
                                Thread.Sleep(600);
                                player.Guard();
                                Console.WriteLine($"{player.name}의 방어! {player.playerDefence}의 대미지를 가드했다.");
                                Thread.Sleep(600);
                                if (pe.monsterDamage > player.playerDefence)
                                    player.hp = player.hp - (pe.monsterDamage - player.playerDefence);
                                Console.WriteLine($"{player.name}의 체력 : {player.hp}");
                            }
                            if (player.hp <= 0)
                            {
                                break;
                            }
                            if (pe.hp <= 0)
                            {
                                Console.WriteLine($"{pe.name}을(를) 무찔렀다!");
                                Console.WriteLine($"{pe.dropItem}을(를) 얻었다.");
                                player.inven[kill] = pe.dropItem;
                                kill++;
                            }
                            Thread.Sleep(600);
                            Console.WriteLine($"더 싸우시겠습니까? Y/N");
                            checkKey = Console.ReadKey(true);
                            if (checkKey.Key == ConsoleKey.Y)
                            {
                                /* Do Nothing */
                            }
                            else
                            {
                                run = true;
                                break; 
                            }

                        }
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine();
            if (player.hp <= 0)
            {
                Console.WriteLine($"용사는 패배했다.");
                player.inven = new string[10];
            }
            else if(kill > 7)
                Console.WriteLine($"가방이 가득 찼다.");
            else
                Console.WriteLine($"용사는 도망쳤다.");
            Console.WriteLine($"무찌른 몬스터의 수 : {kill}");
            Console.Write($"얻은 아이템 : ");
            foreach(string item in player.inven)
            {
                Console.Write("["+item+"] ");
            }
            

            
        }
    }
}
