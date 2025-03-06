using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0304task
{
    class Program
    {

/*        class Warrior
        {
            public string Name;
            public string Score;
            public int Strength;
        }*/
        static void Main(string[] args)
        {
            /*1번 문제            
             * Warrior warrior = new Warrior();

                        string Name = "해라";
                        string Score = "10";
                        int Strength = 5920;


                        Console.WriteLine("Name: " + Name);
                        Console.WriteLine("score: " + Score);
                        Console.WriteLine("Strength: " + Strength);*/


            //2번문제
            //Console.Write("정수를 입력하세요: " );
            //string input = Console.ReadLine();


            //try
            //{
            //    int number = int.Parse(input);
            //    Console.WriteLine($"입력한 숫자는 {number}입니다.");
            //}

            //catch (FormatException)
            //{
            //    Console.WriteLine("올바른 숫자를 입력하세요!");


            //}

            //3번 문제
            //List<string> fruits = new List<string> { "사과", "바나나", "포도" };
            //foreach (var fruit in fruits)
            //{
            //    Console.WriteLine(fruit);
            //}

            //Queue<string> tasks = new Queue<string>();
            //tasks.Enqueue("첫 번째 작업");
            //tasks.Enqueue("두 번째 작업");
            //tasks.Enqueue("세 번째 작업");

            //foreach (var task in tasks)
            //{
            //    Console.WriteLine(task);
            //}

            //Stack<int> ints = new Stack<int>();
            //ints.Push(10);
            //ints.Push(20);
            //ints.Push(30);

            //while (ints.Count >0)
            //    {
            //    Console.WriteLine(ints.Pop());
            //}

            //4번 문제

            /*            Console.Write("문자열을 입력하세요: ");
                        string input = Console.ReadLine();

                        string upperText = input.ToUpper();
                        Console.WriteLine(upperText);
                        string replacedText = upperText.Replace("C#", "CSHARP");
                        Console.WriteLine(replacedText);
                        int length = replacedText. Length;

                        Console.WriteLine($"문자열 길이: {length}");*/

            //5번 문제

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evens = numbers.Where(n => n % 2 == 0);
            Console.WriteLine("짝수: ");
            foreach(var even in evens)
            {
                Console.WriteLine(even);
            }

            int sum = numbers.Sum();
            Console.WriteLine($"전체 숫자의 합: {sum}");
        }

        
    }
}
