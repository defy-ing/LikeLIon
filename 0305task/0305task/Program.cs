using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0305task
{
    //부모 클래스(기본 영웅)
    class Hero
    {
        public string Name;//영웅 이름
        protected int Health; //체력 (protected: 상속받은 클래스에서 접근 가능)


        //생성자(기본자 설정)
        public Hero()
        {
            Name = "Unknown";
            Health = 100;
        }

        //공격 메서드 (자식 클래스에서 재정의 가능)
        public virtual void Attack()
        {
            Console.WriteLine($"{Name}이(가) 기본 공격을 합니다.");
        }

        //이동 메서드(자식 클래스에서 재정의 가능)
        public virtual void Move()
        {
            Console.WriteLine($"{Name}이(가) 이동합니다.");
        }

        //궁극기(모든 영웅 공통 메서드, 하지만 기본 구현은 없음)
        public virtual void UseUltimate()
        {
            Console.WriteLine($"{Name}이가 궁극기를 사용할 수 없습니다.");
        }

    }

    //D.Va 클래스(탱커)
    class DVA : Hero
    {
        public DVA()
        {
            Name = "D.VA";
            Health = 600; //디바는 탱커니까 체력이 높음
        }

        public override void Attack()
        {
            Console.WriteLine($"{Name}가 '미사일'을 사용합니다!");
        }

        public override void Move()
        {
            Console.WriteLine($"{Name}가 '부스터'로 이동합니다!");
        }

        public override void UseUltimate()
        {
            Console.WriteLine($"{Name}가 '자폭'을 사용합니다!");
        }
    }

    //트레이서 클래스(딜러)
    class Tracer : Hero
    {
        public Tracer()
        {
            Name = "트레이서";
            Health = 150;
        }

        public override void Attack()
        {
            Console.WriteLine($"{Name}가 '펄스 쌍권총'으로 사격합니다!");
        }
        public override void Move()
        {
            Console.WriteLine($"{Name}가 '점멸'로 순간이동을 합니다!");
        }
        public override void UseUltimate()
        {
            Console.WriteLine($"{Name}가 '펄스 폭탄'을 사용합니다!");
        }

        //메르시 클래스(지원가)

        class Merci : Hero
        {
            public Merci()
            {
                Name = "메르시";
                Health = 200;
            }

            public override void Attack()
            {
                Console.WriteLine($"{Name}가 '딱총'으로 공격합니다!");
            }
            public override void Move()
            {
                Console.WriteLine($"{Name}가 '슈퍼 점프'로 날아갑니다!");
            }
            public override void UseUltimate()
            {
                Console.WriteLine($"{Name}가 '발키리'를 사용합니다!");
            }

            //메르시만의 특별 기능(치료)
            public void Heal(Hero target)
            {
                Console.WriteLine($"{Name}가 {target.Name}를 치료합니다.");
            }


        }



        class Program
        {
            //Unit units =new SCV();
            static void Main(string[] args)
            {

                //영웅 리스트 생성
                List<Hero> heroes = new List<Hero>();

                //영웅 객체 추가
                heroes.Add(new DVA());
                heroes.Add(new Tracer());
                heroes.Add(new Merci());

                //모든 영웅이 이동하고 공격하는 과정
                foreach (var hero in heroes)
                {
                    hero.Move();
                    hero.Attack();
                    hero.UseUltimate();
                    Console.WriteLine(); //줄바꿈
                }

                //메르시가 디바를 치료

                Merci merci = new Merci();
                merci.Heal(heroes[0]);// 디바를 치료


            }
        }
    }
}