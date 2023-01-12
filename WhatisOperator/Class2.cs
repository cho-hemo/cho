using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace WhatisOperator
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            /**
             * ������ : ���� ����. Main() �޼��� ���� �������� �� �������� �ڵ尡 �����Ǹ� ������� ���� �� ����.
             * ��� : ���α׷� ���� ������ ����, ������ �ݺ��ϴ� �۾� ���� ó���� �� ����ϴ� ����. ���ǹ��� �ݺ���.
             * ���ǹ� : ���� ����. ������ ��, ������ ���� ���� �ٸ� ��ɹ��� ������ �� �ִ� ����. (=�б⹮,���Ǵܹ�)
             * �ݺ��� : �ݺ� ����. Ư�� ��ɹ��� ������ ����ŭ �ݺ��ؼ� ������ ���� ���ǽ��� ���� ���� �ݺ�.
             * 
             * if / else ��
             * ���α׷� �帧�� ���������� ����ġ��(Branching) �� �� ���.
             * ������ ���ؼ� �Ǵ��ϴ� �������� if, else if, else ������ Ű���� ���.
             * 
             */

            // �ΰ��� ���� �� �� ū ���� ã�� ���α׷�
            /*int numX,numY;
            Console.Write("X���� �Է��ϼ���. -> ");
            int.TryParse(Console.ReadLine(), out numX);
            Console.Write("Y���� �Է��ϼ���. -> ");
            int.TryParse(Console.ReadLine(), out numY);

            if (numX < numY)
            {
                Console.WriteLine("Y�� X���� Ů�ϴ�.");
            }
            else
            {
                Console.WriteLine("X�� Y���� ũ�ų� �����ϴ�.");
            }
            Console.WriteLine();*/

            // ���� ����� �޾Ƽ� 100ml �̸��� small, 100ml�̻� 200ml �̸��� medium, 200ml �̻���
            // large��� ����ϴ� if-else���� �ۼ�
            /*
            int sizeCup;
            Console.Write("�� ����� �Է��ϼ���. -> ");
            int.TryParse(Console.ReadLine(), out sizeCup);

            if(sizeCup < 100 && sizeCup > 0)
            {
                Console.WriteLine($"���� �뷮�� {sizeCup}ml�̸� small�Դϴ�.");
            }
            else if(sizeCup >= 100 && sizeCup < 200)
            {
                Console.WriteLine($"���� �뷮�� {sizeCup}ml�̸� medium�Դϴ�.");
            }
            else if (sizeCup > 200)
            {
                Console.WriteLine($"���� �뷮�� {sizeCup}ml�̸� large�Դϴ�.");
            }
            else
            {
                Console.WriteLine($"���̶�� �θ� �� �����ϴ�.");
            }*/

            // ��� �ڵ� ���߱�
            // ��� �ڵ�� A���� Z������ ����
            // ����ڴ� ��ǻ�Ϳ��� �ڵ带 �����ϰ� ��ǻ�ʹ� ���� Ȥ�� ��Ʈ�� �ش�.

            const char com = 'G';
            int comCode = Convert.ToInt32(com);
            Console.Write("��� �ڵ带 �Է��ϼ���. -> ");

            char secret = Convert.ToChar(Console.ReadLine());
            int code = Convert.ToInt32(secret);

            

            for (int i = 2; i != 1; i++)
            {
                code = Convert.ToInt32(secret);
                if (code >= 65 && code <= 90)
                {

                }
                else if (code >= 97 && code <= 122)
                {
                    code = code - 32;
                }
                else
                {
                    Console.Write("��� �ڵ带 ����� �Է��ϼ���. -> ");
                    secret = Convert.ToChar(Console.ReadLine());
                }
                if (code == comCode)
                {
                    Console.WriteLine($"{secret}��(��) �����Դϴ�.");
                    break;
                }
                else if(code >= 65 && code <= 90)
                {
                    if (code < comCode)
                    {
                        Console.WriteLine($"{secret}��(��) ��� �ڵ庸�� �տ� �ֽ��ϴ�.");
                    }
                    else
                    {
                        Console.WriteLine($"{secret}��(��) ��� �ڵ庸�� �ڿ� �ֽ��ϴ�.");
                    }
                    Console.Write("��� �ڵ带 �ٽ� �Է��ϼ���. -> ");
                    secret = Convert.ToChar(Console.ReadLine());
                }
            }

            // �� ���� ���� �߿��� ū �� ã��
            // ����ڷκ��� ���� 3���� ���� �߿��� ���� ū ���� ã�� ���α׷� �ۼ�.
            // 3���� ������ �� ���� �Է¹޾� ���� ū ���� ���
            int num1,num2,num3;
            char delimiterChars = ' ';
            Console.Write("3���� ������ �Է��ϼ���. -> ");
            string three = Console.ReadLine();
            string[] threeNumber = three.Split(delimiterChars);

            for (int z = 1; z > 0; z++)
            {

                if (threeNumber.Length == 3)
                {
                    int.TryParse(threeNumber[0], out num1);
                    int.TryParse(threeNumber[1], out num2);
                    int.TryParse(threeNumber[2], out num3);

                    if (num1 > num2 && num1 > num3)
                    {
                        Console.WriteLine($"���� ū ���� {num1}�Դϴ�.");
                        break;
                    }
                    else if (num2 > num1 && num2 > num3)
                    {
                        Console.WriteLine($"���� ū ���� {num2}�Դϴ�.");
                        break;
                    }
                    else if (num3 > num1 && num3 > num2)
                    {
                        Console.WriteLine($"���� ū ���� {num3}�Դϴ�.");
                        break;
                    }
                    else if (num1 == num2 && num1 > num3) 
                    {
                        Console.WriteLine($"���� ū ���� {num1}�Դϴ�.");
                        break;
                    }
                    else if (num1==num3 && num1 > num2)
                    {
                        Console.WriteLine($"���� ū ���� {num1}�Դϴ�.");
                        break;
                    }
                    else if (num2==num3&& num2 > num1)
                    {
                        Console.WriteLine($"���� ū ���� {num2}�Դϴ�.");
                        break;
                    }
                    else if (num1 == num2 && num2 == num3)
                    {
                        Console.WriteLine($"���� ū ���� {num1}�Դϴ�.");
                        break;
                    }
                    else
                    {
                        Console.Write("3���� ������ ����� �Է��ϼ���. -> ");
                        three = Console.ReadLine();
                        threeNumber = three.Split(delimiterChars);
                    }

                }
                else
                {
                    Console.Write("3���� ������ ����� �Է��ϼ���. -> ");
                    three = Console.ReadLine();
                    threeNumber = three.Split(delimiterChars);
                }


            }


        }
    }
}
