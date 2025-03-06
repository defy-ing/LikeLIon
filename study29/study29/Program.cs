using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace study29
{
    
    //메서드 오버라이딩(overriding)
    //부모 클래스의 메서드를 자식 클래스에서 재정의(overriding) 하여 다른 동작을 수행할 수 있습니다.


    class Animal //앞에 public 써주는게 좋음
    {
        public string Name { get; set; }
        //가상(virtual)메서드 : 자식 클래스에서 재정의 가능

        public virtual void Speak()
        {
            Console.WriteLine("동물이 소리를 냅니다.");
        }
    }
    class Dog : Animal
    {
        //부모 클래스의 메서드를 오버라이딩(재정의)
        public override void Speak()
        {
            Console.WriteLine($"{Name}이가 멍멍 짖습니다.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            myAnimal.Name = "일반동물";
            myAnimal.Speak(); //부모클래스의 기본 메서드 실행

            Dog myDog = new Dog();
            myDog.Name = "바둑이";
            myDog.Speak(); //오버라이딩된 매서드 실행
            

        }
    }
}
