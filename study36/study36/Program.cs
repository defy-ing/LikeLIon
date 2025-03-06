using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study36
{

    class Person
    {
        private string name="홍길동"; 
        //필드 선언하면서  초기화도 가능함!!
        //필드 클래스의 데이터를 저장하는 멤버입니다. private로 바꾸면 밑에서 사용 불가
        public void SetName(string n)
        {
            name = n;
        }
        public string GetName()
        { 
            return name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();// 객체로 만들기 p=붕어빵 틀
            Console.WriteLine(p.GetName());
            p.SetName("Bob"); //필드에 값 넣기 메모리를 넣을 때 붕어빵이 만들어짐
            Console.WriteLine(p.GetName());

        }
    }
}
