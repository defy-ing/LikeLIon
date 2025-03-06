using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study37
{
    class Person
    {
        public string Name;
        public int Age;

        public Person()//생성자
        {
            Name = "Unknown"; //값이 없어도 동작함!!
            Age = 0;
        }

        public Person(string name)
        {
            Name = name;
            Age = 0;
        }

        public Person(string name, int Age)
        {
            Name = name;
            Age = 0;
        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            
            
            //괄호 안에 이름 입력하면 매개변수 있는 생성자("이름")이 입력됨

            Person p = new Person(); //기본 생성자 호출 
            Person p1 = new Person("Bob"); //1개짜리 매개변수 있는 생성자
            Person p2 = new Person("카타리나",20); //2개짜리 매개변수 있는 생성자

            Console.WriteLine(p.Name+","+p.Age);
            Console.WriteLine(p1.Name + "," + p1.Age);
            Console.WriteLine(p2.Name + "," + p2.Age);
        }
    }
}
