using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic2
{
    class Program
    {
        static void Main(string[] args)
        {

            //List
            //Dictionary(키, 벨류)
            //foreach
            //for 문이랑 비슷한데 약간 다름
            //foreach는 인덱스 접근이 안됨
            //반복횟수 지정도 안됨/ for문은 가능함

            /*            Dictionary<string, int> test = new Dictionary<string, int>();
                        test.Add("키", 0);
                        test.Add("키1", 0);
                        test.Add("키2", 0);
                        test.Add("키3", 0);

                        foreach(var data in test)
                        {
                            Console.WriteLine(data.Key);
                        }

                        string[] player = { "전사", "궁수", "마법사" };
                        foreach (string pl in player)
                        {
                            Console.WriteLine(pl);
                        }



                        for (int i=0; i<5;i++)
                        {
                            //인덱스가 i
                            if (i == 1) continue;
                            Console.WriteLine(player[i]);
                        }
            */

            //배열, List 돌릴때 foreach를 많이 씀



            //예제1) 구구단을 2단부터 9단까지 출력

            /* for(int i= 1; i>=1 && i<10; i++) //세로줄이라고 생각 i<=9도 됨
             {
                 for (int j = 2; j >= 1 && j < 10; j++) //2단부터니까 int j=2;
                 {
                     int sum = i * j;
                     Console.Write($"{j}x{i}={sum}\t");  //j가 먼저 와야함!!!!!!!!  // \t 누르면 한칸씩 띄어져서 정리가 됨!!!!!!!

                 }
                 Console.WriteLine();  //엔터 넣어주면 깔끔하게 정리 됨
             }*/

            //While() -> ~하는 동안
            // while(조건 ~인동안 반복)


            //유니티로 넘어가게 되면 막 쓰면 안됨
            //계속 돌아가고 있는 거니까 쌓이면 쌓일수록 위험함
            //일정 조건을 충족하면 break;로 빠져나오는 것이 좋음

            //update tickcount 언제많이 쓰냐면
            //키 입력 받을때 -> input.GetKeyDown(Keycode.Space)
            //근데 써도댐. 그래픽 탓하면댐ㄷㄷ


            //예제 2) while문으로 숫자를 1~5까지 출력하고 종료하기


            /*            int num = 0; //변수 먼저 선언
            *//*            while (num<=5) //조건
                        {
                            Console.WriteLine(num++); //종료하는 조건 (변수 옆에 ++증감 걸어두기)

                        }*//*

                        //방법2

                        while(true)
                        {
                            if (num == 5) break;
                            num++;
                            Console.WriteLine(num);
                        }*/


            //예제 3) 1에서 10까지의 합 구하기

            /*            int num = 1;
                        int sum = 0;

                        while(num<=10)

                        {
                            sum += num;
                            num++;
                        }
                        Console.WriteLine("1부터 10까지의 합 : " + sum+"입니다");*/



            //예제 3) 가위바위보 게임 만들기
            //if, switch, while문을 사용해서 (둘 중 아무거나 if나 switch나)
            //나는 1~3번으로 선택해서 가위바위보 선택하고
            //상대는 랜덤으로 가위바위보를 해서
            //내가 이겼는지 비겼는지 졌는지
            //만들고 쉬는 시간까지 해서 7시 30분



            //내가 상대랑 붙어야함

            // 가위, 바위, 보 게임을 만들건데
            // if, switch, while문을 사용해서 (둘중에 아무거나 if나 switch)
            // 나는 1~3번으로 선택해서 가위바위보를 선택하고 상대는 랜덤으로 가위바위보를해서
            // 내가 이겼는지 비겻는지 졌는지
            // 만들고 쉬는시간까지해서 7시 30분
            // 시간부족하다 말씀해주시면 조금 더드려볼게요 일단 30분풀어보시고
            // 지피티쓰면안되요

            // 풀만하신가요? 어렵나요?
            // 가위바위보...생각보다어렵네..?
            /*
                        Random random = new Random();
                        while (true)
                        {
                            Console.WriteLine("=====가위바위보 게임=====");
                            Console.WriteLine("가위는 1번, 바위는 2번, 보는 3번입니다.");
                            Console.WriteLine("숫자를 입력하세요! (0번을 입력하면 게임 종료)");

                            string input = Console.ReadLine();
                            int UserChoice; 
                            //예외 처리하기 (try , catch문으로)
                            try
                            {
                                UserChoice = int.Parse(input);
                            }
                            catch(FormatException)
                            {
                                Console.WriteLine("잘못 입력함. 숫자를 입력하세요.\n");
                                continue;

                            }
                            if (UserChoice == 0)
                            {
                                break;
                            }

                            if(UserChoice<1 || UserChoice>3)
                            {
                                Console.WriteLine("1,2,3 중 한 숫자를 입력하세여ㅡㅡ\n");
                                continue;

                            }


                            int ComChoice = random.Next(1, 4);



                            string UserMove = ""; //먼저 유저의 선택 값을 선언해야 오류가 발생하지 않음.
                            string ComMove = "";  //그래서 빈 문자열로 먼저 선언하는 것임
                                                  // 나중에 유저의 선택을 변수로 써야하니까 쓴 것임!!!
                            *//*// 예시 1. if문 썼을때
                            if (UserChoice == 1)
                            {
                                UserMove = "가위!"; //string 변수로 선언 했기 때문에 바로 선언 가능
                            }
                            else if (UserChoice == 2)
                            {
                                UserMove = "바위!";
                            }
                            else if (UserChoice == 3)
                            {
                                UserMove = "보!";
                            }


                            //이제 컴퓨터 세팅을 해줘야함

                            if (ComChoice == 1)
                            {

                                ComMove = "가위!";
                            }
                            else if (ComChoice == 2)
                            {
                                ComMove = "바위!";
                            }
                            else if (ComChoice == 3)
                            {
                                ComMove = "보!";
                            }*//*


                            //예시 2. switch문일때

                            switch(UserChoice)
                            {
                                case 1: UserMove = "가위"; break;
                                case 2: UserMove = "바위"; break;
                                case 3: UserMove = "보"; break;
                            }

                            switch (ComChoice)
                            {
                                case 1: UserMove = "가위"; break;
                                case 2: UserMove = "바위"; break;
                                case 3: UserMove = "보"; break;
                            }


                            //이제 누가 무엇을 골랐는지 보여주자~
                            //어떻게? 선언해서 ->> $이랑 ""을 쓰면 문자와 {변수}같이 쓸 수 있음!!!!
                            Console.WriteLine($"나 : {UserMove}, 컴퓨터: {ComMove}");

                            //비기는 조건
                            if (UserChoice == ComChoice)
                            {
                                Console.WriteLine("비겼움... 다음엔 좀 더 잘해봐ㅋ");
                            }
                            //이기는 조건
                            else if ((UserChoice == 1 && ComChoice == 3) || //조건 1. 내가 가위이고 상대가 보
                                (UserChoice == 2 && ComChoice == 1) || //조건 2. 내가 바위이고 상대가 가위
                                (UserChoice == 3 && ComChoice == 2)) //조건 3. 내가 보이고 상대가 바위
                            {
                                Console.WriteLine("날 이기다니... \n큭... 분하지만 축하한다");
                                break;//이겼을 때만 빠져나오기!
                            }
                            //질 때는 위에 다 입력을 해놨으니까 굳이 조건 입력 안해도 됨
                            else
                            {
                                Console.WriteLine("졌음ㅋㅋㅋ 쉽죠? 긁?");
                            }
                        }*/


            //while문 마지막 문제
            //컴퓨터가 랜덤하게 1~100까지의 숫자를 주고 10번안에 내가 맞추는 것


            Random random = new Random();
            int UserChoice = 0;
            int ChoiceCount = 0; //내가 얼만큼 골랐는지를 카운트 해야함
            int num = random.Next(1, 101); //random.Next 꼭 기억하기!!!!! //101까지 입력해야 100까지가 됨
            int MaxCount = 10; //10번 안에 맞춰야 하니까
            Console.WriteLine("===랜덤 숫자 맞추기 게임===");
            Console.WriteLine("1부터 100까지의 숫자를\n10번 안에 맞춰보세요");


            while (true)
            {
                if(ChoiceCount>=MaxCount) //만약 고른 횟수가 10번보다(maxcount)많다면
                {
                    Console.WriteLine("실패ㅠㅠ\n");
                    Console.WriteLine($"정답은 {num}이었습니다~!\n");
                    Console.WriteLine("다음 기회에 XD");
                    break;
                }

                string input = Console.ReadLine();
                try
                {
                    UserChoice = int.Parse(input);
                }
                catch
                {
                    Console.WriteLine("올바른 숫자를 입력하세요\n");
                    continue;
                }

                ChoiceCount++;
                Console.WriteLine($"{ChoiceCount}번째 시도!");//몇번째인지 알려주기
                //여기서 부터 결과값에 대한 조건문이 들어가야함
                if(UserChoice==num)
                {
                    Console.WriteLine("정답입니다!");
                    Console.WriteLine($"축하드립니다! {ChoiceCount}만에 맞췄습니다\n");
                    break;
                }
                else if (UserChoice<num)
                {
                    Console.WriteLine($"{UserChoice}보다 큽니다. UP!\n");

                }
                else
                {
                    Console.WriteLine($"{UserChoice}보다 작습니다. Down!\n");
                }
            }









        }










    }
}

