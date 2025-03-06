using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study14
{
    class Program
    {

        //재귀함수(자기 자신을 호출)

        static int Factorial(int n)
        {
            if (n <= 1)
            {
                Console.WriteLine("*" + n);
                  return 1; //출력겸 탈출
            }
            Console.WriteLine("*" + n);
            return n * Factorial(n - 1);
        }





        static void Print()
        {
            /*Console.WriteLine("나는 재귀함수다.");
            Print(); //무한반복
*/
            //Factorial(5) = 5*4*3*2*1 =120
            Console.WriteLine(Factorial(5));

        }



        static void Main(string[] args)
        {
            Print();

        }
    }
}
