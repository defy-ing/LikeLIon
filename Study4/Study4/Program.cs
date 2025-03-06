using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Study4
{
    class Program
    {
        static void Main(string[] args)
        {
            ////문자열
            //string greeting; //문자열 변수를 선언
            //greeting = "Hello, World!"; //변수에 값을 저장

            ////변수의 값을 사용
            //Console.WriteLine(greeting); //출력 : Hello, World!
            //전체주석 만들기 - 컨트롤+k+c 아니면 컨트롤+쉬프트+ 슬래쉬
            //취소하는 건 컨트롤+k+u

            /*int score = 100; //정수형 변수 선언과 동시에 100으로 초기화
            double temperature = 36.5; // 실수형 변수 선언과 초기화
            string city = "Seoul"; //문자열 변수 선언과 초기화


            //변수 출력
            Console.WriteLine(score); //출력 100
            Console.WriteLine(temperature); //출력 36.5
            Console.WriteLine(city); //출력 : Seoul*/

            //같은 데이터 타입의 변수를 쉼표로 구분해서 선언
            /*            int x = 10, y = 20, z = 30; //정수형 변수 x, y, z를 선언하고 초기화

                        Console.WriteLine(x);
                        Console.WriteLine(y);
                        Console.WriteLine(z);*/

            /*   const double Pi = 3.141592; //상수 pi 선언 및 초기화
               const int Maxscore = 100; //정수형 상수선언

               //출력
               Console.WriteLine("Pi : " + Pi); //출력 : Pi : 3.141592
               Console.WriteLine("Max score : " + Maxscore); //출력 : Maxscore : 100*/
            String name = "기본 특성";
            int 공격력 = 16755;
            int 최대생명력 = 78103;
            String att = "전투 특성";
            int 치명 = 36;
            int 특화 = 1017;
            int 제압 = 41;
            int 신속 = 611;
            int 인내 = 22;
            int 숙련 = 39;

            Console.WriteLine(name);
            Console.WriteLine("공격력 : " + 공격력);
            Console.WriteLine("최대생명력 : " + 최대생명력);
            Console.WriteLine(att);
            Console.WriteLine("치명 : " + 치명);
            Console.WriteLine("특화 : " + 특화);
            Console.WriteLine("제압 : " + 제압);
            Console.WriteLine("신속 : " + 신속);
            Console.WriteLine("인내 : " + 인내);
            Console.WriteLine("숙련 : " + 숙련);

                






        }
    }
}
