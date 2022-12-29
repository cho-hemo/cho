using System;
using System.Threading;

namespace MonsterBattle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Battle battle = new Battle();
        }
    }
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
            Random random = new Random();
            int make = 0;
            int kill = 0;
            bool run = false;
            Player player = new Player();
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
            else if (kill > 7)
                Console.WriteLine($"가방이 가득 찼다.");
            else
                Console.WriteLine($"용사는 도망쳤다.");
            Console.WriteLine($"무찌른 몬스터의 수 : {kill}");
            Console.Write($"얻은 아이템 : ");
            foreach (string item in player.inven)
            {
                Console.Write("[" + item + "] ");
            }



        }
    }
}