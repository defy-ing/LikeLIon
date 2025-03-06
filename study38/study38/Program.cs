using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study38
{
   

    class Program
    { 
        //ref 포인터 개념 참조
        //메서드 ref, out
    static void Increase(ref int x)
    {
            x++;
    }

        //out은 반환이 여러개일 때 유용하다
        static void OutFunc(int a, int b, out int x, out int y)
        {
            x = 10;
            y = 20;
        }



        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            //Increase(ref a); //ref 를 넣으면 증가를 해서 증감된 값이 더해져서 나옴

            //Console.WriteLine("A의 값: " +a);
            int x, y;
            OutFunc(a, b, out x, out y);

            Console.WriteLine("x : "+ x +"y : " + y);
               
        }
    }
}
