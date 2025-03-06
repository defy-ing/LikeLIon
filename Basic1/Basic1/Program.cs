//using -> use 현재진행형
//사용하겠다
using Microsoft.SqlServer.Server;
using System;

//a, b 두사람
//program을 짜오라 함

//a가 만든 클래스
namespace A
{


    class Program
    {

    }
}

namespace B
{
    class Program
    {

        static void Main()

        {
            //Main 이 꼭 있어야 실행시킬 수 있음!!!!!!
            //Console  이 현재 context에 없습니다 의 뜻-> main에 Console 이 없음

            //Console.WriteLine("Hello World");

            //int, float, double, bool, char ,string
            //딱 떨어지는 숫자, 소숫점, 좀 더 긴 소숫점, 참/거짓, 낱말, 단어 혹은 문장

            //if문 -> 만약
            //if(만약 조건이 성립하면) 실행
            //else (위 조건이 성립되지 않으면)실행
            /*
                        int hp = 50;

                        if (hp <= 0) Console.WriteLine("Game Over");
                        else
                        {
                            //계속 진행

                        }*/

            //if문을 제일 많이 씀!!!!!!!!!!!!!!
            //이론상으로 if문 하나로 게임을 만들 수 있음-> 그만큼 많이 쓰임

            //예제문제 1)
            //플레이어 점수가 100점 이하면 "레벨업", 아니면 "노력필요" 출력

            //접근 방법
            //플레이어 점수가 필요함
            //int score=? 모름
            //if 문으로 조건 작성
            //*개꿀팁-> cw치고 엔터 치면 Console.WriteLine 됨 ㅁㅊ
            //플레이어 점수를 어떻게 입력해야 하는지에 대한건 안나와있으니까
            //int player = int.Parse(Console.ReadLine) 써도 되고
            //그냥 입력해도 됨



            /*int player = 150;
            if (player <= 100) Console.WriteLine("레벨업!!");
            else
            {
                Console.WriteLine("노력 필요");
            }*/



            //나이가 13세 미만이면 "어린이" 출력, 13세 이상 19세 이하면 "청소년", 그 외 "성인" 출력

            //F10을 누르면 디버깅 모드 실행
            //F11을 누르면 한단계씩 실행이 됨!!!

            /*            int age = 15;
                        if (age < 13)
                        {
                            Console.WriteLine("어린이");

                        }
                        else if (age <= 19 && age >= 13) 
                        {
                            Console.WriteLine("청소년");
                        }
                        else Console.WriteLine("성인"); //이제 나머지 나이대는 모두 성인이니까*/

            //if문이랑 비슷한 거
            //switch문
            //거의 똑같음

            //string day = "";

            //switch(day)
            //{
            //    case "월":
            //    case "화":
            //    case "수":
            //    case "목":
            //    case "금":
            //        Console.WriteLine("평일입니다");
            //        break;
            //    case "토":
            //    case "일":
            //        Console.WriteLine("주말입니다");
            //        break;
            //        default: Console.WriteLine("???"); break;




            //switch문을 사용해서
            //점수 등급(A, B, C, D)에 따라 메세지를 출력하세요
            //A = 최고, B=좋음, C=보통, D=탈락

            /*            string grade = Console.ReadLine();
                                switch(grade)
                                {
                                    case "A":Console.WriteLine("최고");
                                        break;
                                    case "B":
                                        Console.WriteLine("좋음");
                                        break;
                                    case "C":
                                        Console.WriteLine("보통");
                                        break;
                                    case "D":
                                        Console.WriteLine("탈락");
                                        break;

                                }*/

            //4계절
            //12월 ~2월까지겨울
            //3~5월까지 봄
            //6~8월까지 여름
            //9~11월까지 가을
            //다른 숫자가 입력되면-> 잘못 입력되었습니다.

            /*          int month = int.Parse(Console.ReadLine());*/
            /*                  switch(month)
                              {
                                  case 12:
                                  case 1:
                                  case 2: Console.WriteLine("겨울"); break;
                                  case 3:
                                  case 4:
                                  case 5: Console.WriteLine("봄"); break;
                                  case 6:
                                  case 7:
                                  case 8: Console.WriteLine("여름"); break;
                                  case 9:
                                  case 10:
                                  case 11: Console.WriteLine("겨울"); break;
                                  default: Console.WriteLine("잘못 입력되었습니다"); break;
                                  //defult는 else같은 역할


                              }
          */

            //반복문
            //for문 -> ~을 위한 -> 목적을 가지고, 어떤 대상에 대해
            //어떤 특정 목적이나 대상을 정해놓고 그것을 위해 무언가를 수행하는 과정
            //정해진 횟수나 특정 조건을 만족하는 범위를 대상으로 반복하는 구조
            //for(초기화; 조건; 증감식;)
            //반복될 내용

            //int i=0; <-초기화
            //i<5; <-조건문
            //i++; <- 증감식

            /*   for(int i=0; i<5; i++) //i 말고 다른 변수 이름 넣어도 됨
               {
                   //0이고 5보다 작음
                   //0,1,2,3,4
                   Console.WriteLine($"몬스터 소환{i + 1}번째");*/
            /*}*/


            //예제) 1에서 10까지의 숫자를 출력하기->for문 사용



            /*            for (int i = 0; i < 11; i++)
                        {
                            Console.WriteLine(i + 1);
                        }


                        for (int i = 1; i <= 10; i++)
                        {
                            Console.WriteLine(i);
                        }


                        //1에서 10까지 합을 구하세요

                        int sum = 0;
                        for (int i=0; i<10; i++)
                        {
                            *//*sum = sum + i + 1;*//* //누적이 되어야 하기 때문에 한번 더 써야함
                            sum += i + 1;
                        }
                        Console.WriteLine(sum);

                        //추천하지는 않지만...
                        //int a = 1;
                        //int b = 2;
                        //int c = 3;
                        //... 이짓을 해서 다 더해야함*/


            //숫자를 입력받아 입력받은 숫자의 구구단 단수를 출력하세요
            //예: 숫자 2을 입력하면 2x1=2 ... 2x9=18까지 출력하는 알고리즘 만들기

            /*            int mult = int.Parse(Console.ReadLine()); //int.Parse 꼭 기억하기
                        for (int i=0; i<=9; i++) //9까지 이니까 i<=9
                        {
                             Console.WriteLine($"{mult}x{i}={mult*i}");
                        }*/

            // 별(*)을 찍을 것임
            //*
            //**
            //***
            //**** <-이렇게
            //힌트 : 가로로도 반복이 들어가고, 세로로도 반복이 들어감
            //어려울 수 있어요 하지만 괜찮아요
            //계속 쓰다보면 언젠간 눈에 보여요
            //익숙해져라
            //지금 당장 완벽히 이해하지 못해도 괜찮음

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)//먼저 이게 끝나고
                {
                    Console.Write("*"); //별이 출력 *
                }
                Console.WriteLine(); // 줄바꿈 그 다음 값이 충족되면 다시 올라감 -> 이쪽이 더 메모리 효율이 좋음
            }

            string s = "*";
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(s);
                s += "*";
            }


            





        }
                
        
            



        }


    }

