using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0226task
{



   

    class Program
    {
        
         static int Max(int a, int b, int c) // 입력한 정수
        {int max= a;

            if(b>max)
            {
                max = b;

            }
            if (max<c)
            {
                max = c;
            }

            return max; //가장 큰 값을 반환
        }

        //문제 - 세개의 정수를 입력받아 가장 큰 값을 반환하는 함수 작성
        static void Main() //void를 붙이면 아무것도 반환할(result) 필요가 없음
        {
            Console.Write("첫번째 정수: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("두번째 정수: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("세번째 정수: ");
            int num3 = int.Parse(Console.ReadLine());

            int maxvalue = Max(num1, num2, num3);
            Console.WriteLine($"가장 큰 값: {maxvalue}");


        }






    }



        }
    

