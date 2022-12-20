using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    internal class study
    {

        static void Main(string[] args)
        {
            // ** 오늘의 과제 : 아래의 3문제 모든 라인에서 각 라인이 어떤 역할을 하는지 주석으로 설명해서 제출할 것 **
            // ** 파일명 : 과제_김초원_221220.zip



            // 자음과 모음 개수 세기
            // 사용자로부터 영문자를 받아서 자음과 모음의 개수를 세는 프로그램

            Console.WriteLine("알파벳을 입력해주세요. -> "); // 사용자 편의를 위한 설명
            char userChar = Convert.ToChar(Console.ReadLine()); // 사용자 입력 및 string -> char 변환
            int vowelCount = 0; // 모음 개수 변수 초기화
            int conCount = 0; // 모음 개수 변수 초기화

            while (userChar != '#') // 입력값이 '#'이 아니면 반복
            {
                if ((userChar >= 'a' && userChar <= 'z') || (userChar >= 'A' && userChar <= 'Z')) // 알파벳 입력 체크
                {
                    switch (userChar) // 알파벳 자모음 체크
                    {
                        case 'a':// 알파벳 a,e,i,o,u,A,E,I,O,U일 때
                        case 'e':
                        case 'i':
                        case 'o':
                        case 'u':
                        case 'A':
                        case 'E':
                        case 'I':
                        case 'O':
                        case 'U':
                            vowelCount++; // 모음 개수 추가
                            break;
                        default:
                            conCount++; // 아니라면 자음 개수 추가
                            break;
                    }
                    Console.WriteLine("알파벳을 입력해주세요. 끝내려면 #을 입력해주세요. -> ");
                    userChar = Convert.ToChar(Console.ReadLine()); // #이 아니기에 재입력
                }
                else
                {
                    Console.WriteLine("알파벳을 제대로 입력해주세요. -> ");
                    userChar = Convert.ToChar(Console.ReadLine()); // 예외를 입력했기에 재입력
                }

            } // #이 나올 때 까지 루프
            Console.WriteLine($"자음 : {conCount}"); // 모음 개수 출력
            Console.WriteLine($"모음 : {vowelCount}"); //자음 개수 출력
            Console.WriteLine();


            /* 숫자 맞추기 게임
             1~100 사이의 정수를 저장, 사용자의 답이 높은지 낮은지 맞는지 판별. 맞출 때까지 루프.
             사용자가 결정한 번호를 컴퓨터가 맞출 때까지 루프. 사용자는 컴퓨터가 추측한 숫자가 높거나 낮은지 대답.
             사용자가 결정한 값의 범위는 1~100 어떤 숫자를 생각하던 간에 7번 이하의 추측으로 컴퓨터가 맞출 수 있게.
            */

            int rightNum = 50; // 기본 질문 숫자 초기화
            int minimum = 1; // 현재 가능한 가장 작은 숫자 초기화
            int maximum = 100; // 현재 가능한 가장 큰 숫자 초기화
            Console.WriteLine("당신이 생각한 숫자는 {0}보다 큽니까, 작습니까? (크다,작다,정답으로 대답해주세요.)", rightNum); // 기본 질문 출력
            string answer = Console.ReadLine(); // 입력값 변수에 저장

            while (answer != "정답") // 입력값이 "정답"이 아닐 시 반복
            {
                if (answer != "크다" && answer != "작다") // 예외 상황 체크
                {
                    Console.WriteLine("크다,작다,정답으로 대답해주세요.");
                    answer = Console.ReadLine(); // 예외라면 다시 입력받기
                    continue; // 아래의 내용을 무시하고 다음 루프
                }
                if (answer == "크다") // 입력값이 "크다" 일 때
                {
                    minimum = rightNum; // 현재 가장 작은 값에 질문 값을 대입
                    rightNum = minimum + (maximum - minimum) / 2; // 질문 값에는 현재 가장 작은 값과 가장 큰 값의 중간 값을 저장
                }
                else // 입력값이 "크다"가 아닐 때
                {
                    maximum = rightNum; // 현재 가장 큰 값에 질문 값을 대입
                    rightNum = minimum + (maximum - minimum) / 2; // 질문 값에 현재 가장 작은 값과 가장 큰 값의 중간 값을 저장
                }
                Console.WriteLine("당신이 생각한 숫자는 {0}보다 큽니까, 작습니까? (크다,작다,정답으로 대답해주세요.)", rightNum); // 바뀐 질문 값으로 다시 질문
                answer = Console.ReadLine(); // 입력값 받아오기
            } // 정답을 맞출 때 까지 루프
            Console.WriteLine($"당신이 생각한 숫자는 {rightNum}입니다."); // 정답을 맞추면 출력

            /* 산수 문제 자동 출제
             사칙연산 문제들을 자동으로 생성(나눗셈 예외처리)
             피연산자는 0~99 사이의 숫자(난수) 한 번이라도 맞으면 종료, 틀리면 리트라이
            */

            float answer1 = 0; // 지정된 정답 값 초기화
            float userAnswer = 1; // 사용자 정답 값 초기화
            while (answer1 != userAnswer) // 지정된 정답과 사용자 정답 값이 다를 때 반복
            {
                Random random = new Random(); // 난수 생성 함수 선언
                int Num1 = random.Next(0, 100); // 0부터 99까지의 난수를 피연산자로 선언
                int Num2 = random.Next(0, 100); // 0부터 99까지의 난수를 피연산자로 선언
                int Operator = random.Next(1, 5); // 1부터 4까지의 난수를 연산자로 선언
                switch (Operator) // 연산자 난수 값 체크
                {
                    case 1: // 연산자 난수 값이 1일 때
                        answer1 = Num1 + Num2; // 지정된 정답에 피연산자1 + 피연산자2 대입
                        Console.Write($" {Num1} + {Num2} = ? -> "); // 문제 출력
                        break; // switch문 탈출
                    case 2: // 연산자 난수 값이 2일 때
                        answer1 = Num1 - Num2; // 지정된 정답에 피연산자1 - 피연산자2 대입
                        Console.Write($" {Num1} - {Num2} = ? -> ");// 문제 출력
                        break;// switch문 탈출
                    case 3: // 연산자 난수 값이 3일 때
                        answer1 = Num1 * Num2; // 지정된 정답에 피연산자1 * 피연산자2 대입
                        Console.Write($" {Num1} × {Num2} = ? -> ");// 문제 출력
                        break;// switch문 탈출
                    case 4: // 연산자 난수 값이 4일 때
                        if (Num1 != 0 && Num2 != 0) // 나눗셈의 피연산자가 0이 아닐 때
                        {
                            answer1 = (float)Num1 / Num2; // 지정된 정답에 (형변환)피연산자1 / 피연산자2 대입
                            Console.Write($" {Num1} ÷ {Num2} = ? -> ");// 문제 출력
                        }
                        else // 나눗셈의 피연산자가 0일 때
                        {
                            continue;// 하단의 코드를 무시하고 다시 루프
                        }
                        break;// switch문 탈출
                }
                float.TryParse(Console.ReadLine(), out userAnswer); // 답을 입력받아 userAnswer에 저장
                if (answer1 == userAnswer) // 지정된 정답과 사용자 정답이 같으면
                {
                    Console.WriteLine($"정답입니다. 프로그램을 종료합니다."); // 정답 처리(다시 올라가도 정답이기에 루프 실행되지 않는다.)
                }
                else // 지정된 정답과 사용자 정답이 다르면
                {
                    Console.WriteLine($"오답입니다. 문제를 다시 풀어주세요."); // 오답 처리(다시 루프 실행)
                }
            } // 정답을 맞힐 때까지 루프
        }
        }
}
