using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study20
{
    //마린 클래스를 만드세요.
    //이름,미네랄  = 50
    //기본생성자 , 인자있는생성자 
    //SCV 클래스를 만드세요.
    //이름,미네랄  = 50
    //기본생성자 , 인자있는생성자 
   
    //미네랄 클래스를 만드시오
    //Mineral 1500개부터 주네요
    //7개가 시작부터 있습니다.
    //클래스화 해봅시다.
    class Mineral
    {
        public int MineralCount;
        

        public Mineral()
        {
            MineralCount = 1500;

        }
        public void ShowInfo()
        {
            Console.WriteLine($"현재 미네랄 갯수 : {MineralCount}");
        }

    }

    //Game 클래스를 만들어 보자
    class Game
    {
        public static int mineral;
        public static int gas;
        public static int charCount;


        public static void ShowInfo()
        {
            Console.WriteLine($"미네랄 {mineral} 가스 {gas} 인구수 {charCount}");
        }

    }


    class Barrack

    {
        public string Name;
        public int Mineral;

        public Barrack()
        {
            Name = "배럭";
            Mineral = 150;
        }

        public Barrack(string Name, int Mineral)
        {
            this.Name = Name;
            this.Mineral = Mineral;
        }


        public void ShowInfo()
        {
            Console.WriteLine($"이름 : {Name}, 미네랄 : {Mineral}");
        }


    }
    class Marin
    {
        public string Name;
        public int Mineral;

        public Marin()
        {
            Name = "마린";
            Mineral = 50;
        }

        public Marin(string _name, int _mineral)
        {
            Name = _name;
            Mineral = _mineral;
        }


        public void ShowInfo()
        {
            Console.WriteLine($"이름 : {Name}, 미네랄 : {Mineral}");
        }
    }

    //배럭클래스를 만드세요
    //Barrack 150
    //this 키워드를 사용해보자
    //this 자기 자신을 가리킨다.

    





    class SCV
    {
        public string Name;
        public int Mineral;

        public SCV()
        {
            Name = "SCV";
            Mineral = 50;
        }

        public SCV(string _name, int _mineral)
        {
            Name = _name;
            Mineral = _mineral;
        }


        public void ShowInfo()
        {
            Console.WriteLine($"이름 : {Name}, 미네랄 : {Mineral}");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {


            Game.mineral = 50;
            Game.gas = 0;
            Game.charCount = 4;
            Game.ShowInfo();
            

            Marin marin = new Marin("불꽃테란", 100);
            SCV scv = new SCV("열받은SCV", 70);
            Barrack barrack = new Barrack("이게뭔배럭", 150);
            //클래스의 배열
            Mineral[] mineral = new Mineral[7];
            //각 배열에 new 객체화
            for (int i=0; i<mineral.Length; i++)
            {
                mineral[i] = new Mineral();
                mineral[i].ShowInfo();
            }   
                    



            marin.ShowInfo();

            scv.ShowInfo();

            barrack.ShowInfo();


        }
    }
}