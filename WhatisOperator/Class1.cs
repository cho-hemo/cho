using System;

public class Class1
{

    static void Main(string[] args)
    {
        // 최대 한도의 사탕 사기
        // 현재 1000원이 있고 사탕의 가격이 300원일 때 최대 살 수 있는 사탕의 개수와 나머지 돈은 얼마?
        int money, max, modules;
        const int cost = 300;
        Console.Write("가지고 있는 돈은 얼마입니까? -> ");
        int.TryParse(Console.ReadLine(), out money);

        max = money / cost;
        modules = money % cost;

        Console.WriteLine("현재 가지고 있는 돈 : "+money);
        Console.WriteLine("캔디의 가격 : "+cost);
        Console.WriteLine("최대로 살 수 있는 캔디의 수 : "+max);
        Console.WriteLine("남은 돈 : "+modules);
        Console.WriteLine();

        // 화씨온도를 섭씨온도로 바꾸기

        float Fahrenheit, Celsius;

        Console.Write("화씨온도 입력 -> ");
        float.TryParse(Console.ReadLine(), out Fahrenheit);
        Celsius =  (Fahrenheit-32f)*(5f/9f);
        Console.WriteLine($"화씨 : {Fahrenheit} => 섭씨 : {Celsius}");
        Console.WriteLine();


        // 2개의 주사위를 던져서 주사위의 합을 표시하는 프로그램. 주사위를 던지면 랜덤한 수가 나와야 한다.

        Random random1 = new Random();
        int dice1 = random1.Next(1, 6+1);
        int dice2 = random1.Next(1, 6+1);
        Console.WriteLine($"첫번째 주사위 : [{dice1}]");
        Console.WriteLine($"첫번째 주사위 : [{dice2}]");
        Console.WriteLine($"두 주사위 합 : [{dice1+dice2}]");


    }
}
