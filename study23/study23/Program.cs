﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study23
{
    class Program
    {
        static void Main(string[] args)
        {

            //값 형식과 참조 형식
            //값 형식은 스택에 저장되고, 참조 형식은 힙에 저장됩니다.

            /*            int valueType = 10;
                        object refernceType = valueType;

                        valueType = 20;

                        Console.WriteLine($"ValueType : {valueType}"); //20
                        Console.WriteLine($"RefernceType: {refernceType}"); //10

                        //내부적으로는 다른 형식으로 저장됨(메모리 형식이 다름)

                        //박싱 언박싱
                        //값 형식을 참조형식으로 변환(*박싱), 다시 값 형식으로 변환(언박싱)

                        int value = 42;
                        object boxed = value; //박싱
                        int unboxed = (int)boxed; //언박싱

                        Console.WriteLine($"Boxed: {boxed}, Unboxed:{unboxed}");*/

            /*//is 연산자 형식 비교하기
            //객체가 특정 형식인지 확인할 수 있다.

            object obj = "Hello";

            Console.WriteLine(obj is string); //true
            Console.WriteLine(obj is int); //false*/

            //as 연산자로 형식 변환하기
            //as 연산자를 사용해 안전하게 형 변환을 수행한다

            //object obj = "Hello";
            //string str = obj as string;  //null값 형태가 있는거만

            //Console.WriteLine(str is string);

            /*            object obj = 42; //object도 되고 var도 됨
                        var obj2 = 42;


                        if(obj is int number)
                        {
                            Console.WriteLine($"Number: {number}");

                        }
                        else 
                        {
                            Console.WriteLine("Not a number");
                        }*/

            //문자열 다루기
            /*
                        string greeting = "Hello";
                        string name = "Alice";
                        string message = greeting + "," + name + "!";
                        Console.WriteLine(message); //Hello, Alice

                        Console.WriteLine($"Length of name: {name.Length}"); //문자열 길이
                        Console.WriteLine($"To Upper: {name.ToUpper()}"); //대문자 변환 
                        Console.WriteLine($"Substring:{name.Substring(1)}"); //부분 문자열*/


            //string 다양한 메서드
            /*            string text = "C# is awesome!";
                        Console.WriteLine($"Cotains 'awesome' : {text.Contains("awesome")}");
                        Console.WriteLine($"Starts with 'C#' : {text.StartsWith("C#")}");
                        Console.WriteLine($"Index of 'is' : {text.IndexOf("is")}");
                        Console.WriteLine($"Replace 'awsome' with 'great' : {text.Replace("awsome", "great")}");*/



            /*            StringBuilder sb = new StringBuilder("Hello");
                        sb.Append(",");
                        sb.Append("World!");
                        Console.WriteLine(sb.ToString());*/

            //String과 StringBuilder 클래스 성능차이 비교
            //반복적으로 문자열을 ㅅ수정할 때 StringBuilder가 효율적이다

            /*            int iterations = 10000;
                        Stopwatch sw = Stopwatch.StartNew();
                        string text = "";
                        for(int i=0; i<iterations; i++)
                        {
                            text += "a";
                        }

                        sw.Stop();
                        Console.WriteLine($"String: {sw.ElapsedMilliseconds}ms");

                        sw.Restart();
                        StringBuilder sb = new StringBuilder();

                        for(int i=0; i<iterations;i++)
                        { 
                            sb.Append("a");

                        }

                        sw.Stop();
                        Console.WriteLine($"StringBuilder:{sw.ElapsedMilliseconds}ms");*/



            //예외 처리하기

            //프로그램 실행 중 발생하는 오류를 "예외"라고 합니다.
            //예외를 처리하면 프로그램이 중단되지 않으며 실행을 계속할 수 있습니다.
            //try catch -> 종료를 시키지 않고 오류만 캐치해서 고칠 수 있음
            //흐름은 실행되게 하면서 진행 가능

            /*while (true)
            {
                try
                {
                    int[] numbers = { 1, 2, 3 };
                    Console.WriteLine(numbers[5]); //오류 발생

                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

            }*/


            //final 블록은 예외 발생 여부와 상관없이 항상 실행됩니다.

            /*            while(true)
                        try
                        {
                            int number = int.Parse("NotANumber"); //오류발생

                        }
                        catch(FormatException ex)
                        {
                            Console.WriteLine($"Format Error: {ex.Message}");
                        }
                        finally
                        {
                            Console.WriteLine("항상 실행됩니다.");
                        }*/


            //Exception 클래스
            //모든 예외의 기본 클래스입니다.
            /*
                        try
                        {
                            int number = int.Parse("abc");

                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine($"General Error : {ex.Message}");
                        }*/

            //throw 구문으로 직접 예외 발생시키기

            try
            {
                int age = -5;
                if (age < 0)
                {
                    throw new ArgumentException("Age cannot be negative");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }
}
