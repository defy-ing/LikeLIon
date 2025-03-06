using ShootingGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ShootingGame
{
    //미사일 클래스
    public class BULLET
    {
        public int x;
        public int y;
        public bool fire;
    }
    //플레이어 클래스
    public class Player
    {
        [DllImport("msvcrt.dll")]
        static extern int _getch();  //c언어 함수 가져옴

        public int playerX;   //플레이어 X좌표
        public int playerY;   //플레이어 Y좌표
        public BULLET[] playerBullet = new BULLET[20];
        public BULLET[] playerBullet2 = new BULLET[20];
        public BULLET[] playerBullet3 = new BULLET[20];
        public int Score = 0;
        public Item item = new Item();
        public int itemCount = 0;

        public bool GameOver = false; // 게임이 끝났는지 여부 체크


        public Player() //생성자
        {
            //플레이어 좌표위치 초기화
            playerX = 0;
            playerY = 12;

            for (int i = 0; i < 20; i++) //총알 초기화
            {
                playerBullet[i] = new BULLET();
                playerBullet[i].x = 0;
                playerBullet[i].y = 0;
                playerBullet[i].fire = false;

                playerBullet2[i] = new BULLET();
                playerBullet2[i].x = 0;
                playerBullet2[i].y = 0;
                playerBullet2[i].fire = false;


                playerBullet3[i] = new BULLET();
                playerBullet3[i].x = 0;
                playerBullet3[i].y = 0;
                playerBullet3[i].fire = false;
            }


        }

        public void GameMain()
        {
            //키를 입력하는 부분
            KeyControl();
            //플레이얼를 그려준다.
            PlayerDraw();

            //UI점수
            UIscore();

            if (item.ItemLife)
            {
                item.ItemMove();
                item.ItemDraw();
                CrashItem();
            }


        }
        public void CrashItem()
        {
            if (playerY + 1 == item.itemY)
            {
                if (playerX >= item.itemX - 2 && playerX <= item.itemX + 2)
                {
                    item.ItemLife = false;

                    if (itemCount < 3)
                        itemCount++;

                    Score += 100;

                    for (int i = 0; i < 20; i++)
                    {
                        playerBullet[i] = new BULLET();
                        playerBullet2[i] = new BULLET();
                        playerBullet3[i] = new BULLET();
                    }
                }
            }

            if (Score >= 500) // 500점 달성 시
            {
                GameOver = true; // 게임 종료 상태 변경
            }

        }


        public void KeyControl()
        {
            int pressKey;  //정수형 변수선언 키값 받을거임 

            if (Console.KeyAvailable) //키가 눌렸을때 true
            {
                pressKey = _getch(); //아스키값 왼쪽 오른쪽


                switch (pressKey)
                {
                    case 72:  //위쪽방향 아스키코드                    
                        playerY--;
                        if (playerY < 1)
                            playerY = 1;
                        break;
                    case 75:
                        //왼쪽 화살표키
                        playerX--;
                        if (playerX < 0)
                            playerX = 0;
                        break;
                    case 77:
                        //오른쪽
                        playerX++;
                        if (playerX > 75)
                            playerX = 75;
                        break;
                    case 80: //아래
                        playerY++;
                        if (playerY > 21)
                            playerY = 21;
                        break;
                    case 32: //스페이스바
                        //총알 발사
                        for (int i = 0; i < 20; i++)
                        {
                            //미사일이 false 발사가능
                            if (playerBullet[i].fire == false)
                            {
                                playerBullet[i].fire = true;
                                //플레이어 앞에서 미사일 쏘기 + 5
                                playerBullet[i].x = playerX + 5;
                                playerBullet[i].y = playerY + 1;
                                //한발씩 쏘겠다.
                                break;
                            }
                        }
                        //총알 발사
                        for (int i = 0; i < 20; i++)
                        {
                            //미사일이 false 발사가능
                            if (playerBullet2[i].fire == false)
                            {
                                playerBullet2[i].fire = true;
                                //플레이어 앞에서 미사일 쏘기 + 5
                                playerBullet2[i].x = playerX + 5;
                                playerBullet2[i].y = playerY;
                                //한발씩 쏘겠다.
                                break;


                            }



                        }
                        //총알3발사
                        for (int i = 0; i < 20; i++)
                        {
                            //미사일이 false 발사가능
                            if (playerBullet3[i].fire == false)
                            {
                                playerBullet3[i].fire = true;
                                //플레이어 앞에서 미사일 쏘기 +5
                                playerBullet3[i].x = playerX + 5;
                                playerBullet3[i].y = playerY + 2;
                                //한발씩 쏘겠다.
                                break;

                            }
                        }
                        break;

                }
            }

        }
        //미사일 그리기
        public void BulletDraw()
        {
            string bullet = "➳❥"; //미사일 모습
            //20개
            for (int i = 0; i < 20; i++)
            {
                //미사일이 살아있는 상태
                if (playerBullet[i].fire == true)
                {
                    //좌표설정 -> 중간위치를 위해 보정을 위해 x-1
                    Console.SetCursorPosition(playerBullet[i].x - 1, playerBullet[i].y);
                    //총알 출력
                    Console.Write(bullet);

                    playerBullet[i].x++; //미사일 오른쪽으로 날아가기
                    if (playerBullet[i].x > 78)
                    {
                        playerBullet[i].fire = false; //미사일 false 다시 준비상태

                    }
                }
            }
        }


        //미사일 그리기2
        public void BulletDraw2()
        {
            string bullet = "✩・*。"; //미사일모습

            //20개
            for (int i = 0; i < 20; i++)
            {
                //미사일이 살아있는 상태
                if (playerBullet2[i].fire == true)
                {
                    //좌표설정 -> 중간위치를 위해 보정을 위해 x-1
                    Console.SetCursorPosition(playerBullet2[i].x - 1, playerBullet2[i].y);
                    //총알 출력
                    Console.Write(bullet);
                    playerBullet2[i].x++; //미사일 오른쪽으로 날아가기
                    if (playerBullet2[i].x > 78)

                    {
                        playerBullet2[i].fire = false; //미사일 false 다시 준비 상태
                    }


                }
            }
        }

        //미사일 그리기 3
        public void BulletDraw3()
        {
            string bullet = "♡。∙♥";//미사일 모습

            //20개
            for (int i = 0; i < 20; i++)
            {
                //미사일이 살아있는 상태
                if (playerBullet3[i].fire == true)
                {
                    //좌표 설정-> 중간 위치를 위해 보정을 위해 x-1
                    Console.SetCursorPosition(playerBullet3[i].x - 1, playerBullet3[i].y);
                    //총알 출력
                    Console.Write(bullet);
                    playerBullet3[i].x++;//미사일 오른쪽으로 날아가기
                    if (playerBullet3[i].x > 78)
                    {
                        playerBullet3[i].fire = false; //미사일 false 다시 준비상태
                    }
                }
            }
        }
        public void PlayerDraw()
        {
            String[] player = new string[]
            {
                " ∧___∧",
                "( *'△'*)",
                "(__つ　つ"
            };//배열 문자열로 그리기


            for (int i = 0; i < player.Length; i++)
            {
                //콘솔좌표 설정 플레이어X 플레이어Y
                Console.SetCursorPosition(playerX, playerY + i);
                //문자열 배열 출력
                Console.WriteLine(player[i]);
            }
        }

        //충돌처리
        public void ClashEnemyAndBullet(Enemy enemy)
        {
            //미사일 20
            for (int i = 0; i < 20; i++)
            {
                //살아있는 미사일
                if (playerBullet[i].fire == true)
                {
                    //미사일과 적의 y값이 같을 때
                    if (playerBullet[i].y == enemy.enemyY)
                    {
                        if (playerBullet[i].x >= (enemy.enemyX - 1)
                            && playerBullet[i].x <= (enemy.enemyX + 1)) //충돌
                        {
                            //충돌
                            item.ItemLife = true;
                            item.itemX = enemy.enemyX;
                            item.itemY = enemy.enemyY;

                            Random rand = new Random();
                            enemy.enemyX = 75;
                            enemy.enemyY = rand.Next(2, 22);

                            playerBullet[i].fire = false; // 미사일도 준비상태로 만들어주기
                        }
                    }
                }
            }
            //미사일 2 20
            for (int i = 0; i < 20; i++)
            {
                //살아있는 미사일
                if (playerBullet2[i].fire == true)
                {
                    //미사일과 적의 y값이 같을 때
                    if (playerBullet2[i].y == enemy.enemyY)
                    {
                        if (playerBullet2[i].x >= (enemy.enemyX - 1)
                            && playerBullet2[i].x <= (enemy.enemyX + 1))// 충돌
                        {
                            //충돌
                            Random rand = new Random();
                            enemy.enemyX = 75;
                            enemy.enemyY = rand.Next(2, 22);

                            playerBullet2[i].fire = false; //미사일도 준비상태로 만들어주기
                        }
                    }
                }
            }

            //미사일 3 20
            for (int i = 0; i < 20; i++)
            {
                //살아있는 미사일
                if (playerBullet3[i].fire == true)
                {
                    //미사일과 적의 y값이 같을 때
                    if (playerBullet3[i].y == enemy.enemyY)
                    {
                        if (playerBullet3[i].x >= (enemy.enemyX - 1)
                            && playerBullet3[i].x <= (enemy.enemyX + 1)) //충돌
                        {
                            //충돌
                            Random rand = new Random();
                            enemy.enemyX = 75;
                            enemy.enemyY = rand.Next(2, 22);

                            playerBullet3[i].fire = false; //미사일도 준비상태로 만들어주기
                        }
                    }
                }
            }
        }

        public void UIscore()
        {
            Console.SetCursorPosition(63, 0);
            Console.Write("♥♡♥♡♥♡♥♡");
            Console.SetCursorPosition(63, 1);
            Console.Write("♡            ♥");
            Console.SetCursorPosition(65, 1);
            Console.Write("배부름: " + Score);
            Console.SetCursorPosition(63, 2);
            Console.Write("♥♡♥♡♥♡♥♡");
        }
        //아이템 충돌이 일어나면 양쪽 미사일 발사
        
    }
        }


    

    public class Enemy //적 클래스
    {
        public int enemyX; //X좌표
        public int enemyY; //Y좌표

        public Enemy()
        {
            //적 좌표 초기화
            enemyX = 77;
            enemyY = 12;

        }

        public void EnemyDraw()//적 그리기
        {
            string enemy = "<º))))><"; //문자열로 표현
            Console.SetCursorPosition(enemyX, enemyY); //좌표설정
            Console.Write(enemy);//출력

        }
        public void EnemyMove()
        {
            Random rand = new Random();//랜덤
            enemyX--; //왼쪽으로 움직임

            if (enemyX < 2)//화면 왼쪽 넘어가면 새로 좌표 잡아라
            {
                enemyX = 75; //좌표 77
                enemyY = rand.Next(2, 22); //2~21
            }
        }


    }

    //아이템 클래스
    public class Item
    {
    public int itemX = 0;
    public int itemY = 0;
    public bool ItemLife = false;

    public void ItemDraw()
    {
        Console.SetCursorPosition(itemX, itemY);
        Console.Write("₊✩‧먹이˚✩‧₊");
    }

    public void ItemMove()
    {
        if (ItemLife)
        {
            itemX--;
            if (itemX <= 1)
            {
                Random rand = new Random();
                itemX = 78;
                itemY = rand.Next(2, 22);
            }
        }
    }
}

class Program
{
    static void ShowTitleScreen() // 🔹 [추가됨] 타이틀 화면
    {
        Console.Clear();
        Console.SetCursorPosition(20, 15);
        string title = @"
             ___  ___  ___   ___  ___  ___   ___    _                   _                  
            |  _>| . ||_ _| |  _>| . ||_ _| | . | _| | _ _  ___ ._ _  _| |_  _ _  _ _  ___ 
            | <__|   | | |  | <__|   | | |  |   |/ . || | |/ ._>| ' |  | |  | | || '_>/ ._>
            `___/|_|_| |_|  `___/|_|_| |_|  |_|_|\___||__/ \___.|_|_|  |_|  `___||_|  \___.
                                                                                

     
";
        Console.WriteLine(title);
        while (true)
        {
            Console.SetCursorPosition(35, 30);
            Console.Write("PRESS ANY KEY TO START...");
            System.Threading.Thread.Sleep(500);
            Console.SetCursorPosition(25, 20);
            Console.Write("                         ");
            System.Threading.Thread.Sleep(500);
            if (Console.KeyAvailable)
            {
                Console.ReadKey();
                break;
            }
        }
        Console.Clear();
    }
    static void ShowCharacter()
    {
        // ✅ 콘솔을 지우지 않고 캐릭터만 출력
        string character = @"
       
          　　　           　　　           /ミ\＿／\
          　　　           　　            /ノ. 川   \イ　
          　　　           　          /⌒￣　  ━　 ━　iミ
          　　　                     /　 \ 〓   (_人_) 〓
          　　　                    （ノ~~~~\_) \_)

";

        Console.SetCursorPosition(30, 20); // ✅ 캐릭터 위치 설정
        Console.WriteLine(character);
    }
    static void ShowCharacterSpeaking()
    {
        // ✅ 캐릭터 (입 벌림)
        string characterOpen = @"
       
          　　　           　　　           /ミ\＿／\
          　　　           　　            /ノ. 川   \イ　 ♡
          　　　           　          /⌒￣　  ━　 ━　iミ
          　　　                     /　 \ 〓   (_◆_) 〓
          　　　                    （ノ~~~~\_) \_)

";

        Console.SetCursorPosition(30, 20); // ✅ 같은 위치에 덮어쓰기
        Console.WriteLine(characterOpen);
    }



    static void ShowNarration(string text, bool isLast = false)
    {
        DrawNarrationBox(); // ✅ 나레이션 박스 먼저 그림

        if (isLast)
        {
            ShowCharacterSpeaking(); // ✅ 마지막 나레이션일 때만 입 벌리기
        }

        Console.SetCursorPosition(30, 32); // ✅ 나레이션 텍스트 위치 설정
        Console.WriteLine(text);

        Console.SetCursorPosition(37, 34); // ✅ "Press any key..." 안내문 위치 설정
        Console.Write("Press any key to continue...");

        Console.ReadKey(); // ✅ 사용자 입력 대기

        if (isLast)
        {
            ShowCharacter(); // ✅ 마지막 나레이션 후 다시 입 닫기
        }
    }


    static void DrawNarrationBox()
    {
        int width = 80; // 박스 가로 길이
        int height = 5; // 박스 세로 길이
        int startX = 10; // 시작 X 좌표
        int startY = 30; // 시작 Y 좌표 (캐릭터 아래쪽에 위치)

        Console.SetCursorPosition(startX, startY);
        Console.Write("┌" + new string('─', width) + "┐");

        for (int i = 1; i <= height; i++)
        {
            Console.SetCursorPosition(startX, startY + i);
            Console.Write("│" + new string(' ', width) + "│");
        }

        Console.SetCursorPosition(startX, startY + height);
        Console.Write("└" + new string('─', width) + "┘");
    }
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8; // ✅ UTF-8 설정 (아스키 아트 깨짐 방지)
        Console.CursorVisible = false;
        Console.SetWindowSize(100, 40); // ✅ 콘솔 창 크기 조정
        Console.SetBufferSize(100, 40); // ✅ 콘솔 창 크기 조정

        ShowTitleScreen();

        ShowCharacter();
        ShowNarration("여기 배고픈 아기 고양이 한 마리가 있습니다.");
        ShowNarration("고양이에게 먹이를 열심히 먹여주세요!");
        ShowNarration("사랑의 미사일을 날려 먹이를 획득하세요!");
        ShowNarration("배부른 고양이가 되면 특별한 일이 일어납니다.");
        ShowNarration("           그럼 행운을 빕니다!");
        ShowNarration("                  먉.", true);

        Player player = new Player();
        Enemy enemy = new Enemy();

        int dwTime = Environment.TickCount;

        while (true)
        {
            if (dwTime + 50 < Environment.TickCount)
            {
                dwTime = Environment.TickCount;
                Console.Clear();

                player.GameMain();

                if (player.itemCount == 0)
                {
                    player.BulletDraw();
                }
                else if (player.itemCount == 1)
                {
                    player.BulletDraw();
                    player.BulletDraw2();
                }
                else
                {
                    player.BulletDraw();
                    player.BulletDraw2();
                    player.BulletDraw3();
                }

                enemy.EnemyMove();
                enemy.EnemyDraw();

                player.ClashEnemyAndBullet(enemy);

                if (player.GameOver) // 게임 종료 확인
                {
                    ShowEndingScene(); // 엔딩 화면 출력
                    break; // 게임 루프 종료
                }
            }
        }
    }

    static void ShowEndingScene()
    {
        Console.Clear();
        Console.SetCursorPosition(60, 2);
        string endingCharacter = @"
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀  ⠀⠹⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣯⠑⢄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀ ⠀⠀ ⠀⠘⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣧⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀ ⠀ ⠀⠻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀  ⠀⠀⠸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀  ⠀⠀⠀⠈⠻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡎⠻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠿⣷⣦⣤⡤⠄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀ ⠀ ⠀⠀⠀⠀⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣠⣼⠿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠟⡙⢿⣿⣿⣿⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀ ⠀ ⠀⠀⠀⠀⣸⠋⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠹⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡏⠀⠀⢹⣿⣿⣿⣿⣿⣿⣿⣿⣼⡿⢻⣿⣿⣿⣿⣿⣸⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀ ⠀ ⠀⡀⠄⢊⠃⠀⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇⠀⠹⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣥⢄⣰⣿⣿⢿⡏⣹⣿⣿⣿⣿⣿⣆⠀⣿⣿⣿⢿⠀⡯⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀ ⠀ ⠀⠀⠀⠘⠀⠀⠈⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡷⠶⠛⠻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣏⠰⠏⠓⠬⠼⠟⠋⢸⣿⡏⣸⣿⠟⣹⣿⣿⡇⢸⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀ ⠀⠀ ⠀⠀⢰⠀⠀⢠⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣧⣤⣐⣺⣿⣿⣿⣿⣿⣿⡿⠟⢻⠟⠛⠉⠀⠀⠀⠀⢀⣼⡟⡙⡜⣍⣿⣿⣿⣿⠷⠚⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀ ⠀⠀⠀ ⠀⠀⠀⠀⠑⢤⣼⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⢿⢿⠛⠏⣹⡿⠛⠒⠊⠀⠀⠀⠀⠀⠀⠀⠁⠞⠀⠁⣷⣿⣿⣿⣿⣇⠀⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀ ⠀ ⠀⠀⠀⠀⣀⡠⢾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣉⣓⣦⠊⠀⠀⠈⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⣿⣿⣿⡇⠻⠻⠧⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀  ⠀⠀⠀⠀⠀⠀⢀⠞⢹⠈⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡉⠉⠫⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣾⣟⣒⣿⡇⠀⠀⠂⠀⠀⠀⠀⠀⠀⠀⣠⣶⣿⣿⣿⣿⣷⣤⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀  ⠀⠀⠀⠀⠀⠀⠁⠀⠈⠆⠈⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣦⣄⣠⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⠤⢠⡄⠀⠀⢀⣾⣿⡟⠇⠹⠅⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀  ⠀⠀⠀⢀⣠⣴⣶⣶⣶⣦⣤⣀⠀⠹⡟⠿⢿⣿⣿⢸⣿⣿⡟⢸⣿⣦⡀⠀⠀⠀⠀⠀⠀⢀⣤⢶⣶⣷⣿⢻⠃⠀⢀⣾⣿⡿⠇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠛⠛⠋⠁⠈⠙⣿⣿⣿⣿⣧⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀  ⠀⠀⣠⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣦⣽⣦⠜⢹⡿⣦⣧⠋⠀⢸⣿⣿⣿⣶⣄⡀⢀⠠⠐⠈⠀⢰⣿⣿⣿⠁⠀⣠⣿⡟⠈⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⣿⣿⣿⣿⡄⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀ ⠀⠀ ⠀⣠⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣄⣀⡡⠘⠁⠀⡐⠋⡸⠟⠽⠟⠛⠉⠀⠀⣀⣴⣾⣿⣿⣏⡇⢀⣴⣿⡿⠀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀ ⠀ ⢀⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠟⠋⠉⠀⠀⠀⠈⠉⠀⠀⠀⠀⠀⢀⠄⠆⢹⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠁⠀⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣿⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀ ⠀ ⣠⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠛⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠠⣤⣼⣿⣿⣿⣿⣿⣿⣿⣿⣿⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣰⣿⣿⣿⣿⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀  ⣴⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠙⠛⠿⠿⣿⣿⠿⠻⠃⠀⠀⢠⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣼⣿⣿⣿⡿⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀ ⠀ ⣼⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⣶⣶⣶⣤⣤⣀⡀⠈⢑⣦⡀⠀⠀⠀⠢⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣴⣿⣿⣿⣿⠟⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
           ⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡟⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡀⣨⣿⣿⣿⣿⣿⠟⠛⠚⠛⠁⠀⠀⠀⠀⠀⠑⠀⣀⣴⣆⠀⠀⠀⠀⠀⠀⠀⠀⢀⣴⣿⣿⣿⣿⡟⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
           ⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠟⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠹⣿⣿⣿⣿⡋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣤⣾⣿⣿⣿⣷⣄⡀⠀⠀⠀⠀⣠⣿⣿⣿⣿⡿⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
           ⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠏⠀⠀⠀⠀⠀⠀ ⠀⠀⠀ ⢠⣤⣤⣀⣀⣠⣤⣤⣤⣶⣾⣿⣷⣦⣼⣿⣿⣏⠉⠙⠛⢁⣀⣀⣀⣠⣤⣤⣶⣿⣿⣿⣿⣿⣿⣿⣿⣷⣦⣀⠀⣴⣿⣿⣿⣿⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
           ⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠃⠀⠀⠀⠀⠀⠀ ⠀⠀⠀⠀⣸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
           ⣿⣿⣿⣿⣿⣿⣿⣿⣿⡟⠁⠀⠀⠀⠀⠀⠀⠀ ⠀⠀⢀⣴⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
           ⣿⣿⣿⣿⣿⣿⣿⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀  ⢀⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀

⠀⠀⠀⠀⠀⠀
        ";

        Console.WriteLine(endingCharacter);
        ShowNarration("             ???: 아...");
        ShowNarration("???: 당신이... 제 주인님이시군요.");
        ShowNarration("???: 배고픈 저를 사랑으로 키워주셔서 감사합니다.");
        ShowNarration("???: 사랑의 힘으로 진정한 제 모습을 찾을 수 있었어요.");
        ShowNarration("???: 이제 제가 사랑해 드리고 싶어요...");
        ShowNarration("             ???: 야옹. ♥");
        
        Console.Clear();
    }
   
}