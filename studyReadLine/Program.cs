using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace studyReadLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* //사용자 입력을 문자열 받기
             Console.Write("이름을 입력하세요: ");
             string userName = Console.ReadLine(); // 사용자로부터 입력 받기

             Console.WriteLine($"안녕하세요, {userName}님!");
 *//*

            Console.Write("나이를 입력하새요: ");
            string input = Console.ReadLine(); //사용자로부터 입력 받기
            int age = int.Parse(input); //문자열을 정수로 변환

            Console.WriteLine($"내년에는 {age + 1} 살이 되겠군요!"); //변환된 값 사용
            Console.WriteLine("내년에는 " + age + "살이 되겠군요!");
            Console.WriteLine("내년에는 {0} 살이 되겠군요!", age);
*/

            float Skill_Damage = 0.0f;
            float Card_Gage = 0.0f;
            float Awakedamage = 0.0f;
            int Max_Mana = 0;
            int CombatManaRegen;
            int manaRegenOutofCombat;
            float movespeed;
            float ridespeed;
            float carryspeed;
            float cooldownReduction;





            Console.WriteLine("스킬 피해량을 입력하세요 : ");

            Skill_Damage = float.Parse(Console.ReadLine());

            Console.Write("스킬 피해량을 입력하세요 : ");
            Card_Gage = float.Parse(Console.ReadLine());
            Console.Write("각성기 피해 : ");
            Awakedamage = float.Parse(Console.ReadLine());
            Console.Write("최대마나 :");
            Max_Mana = int.Parse(Console.ReadLine());
            Console.Write("전투 중 마나 회복량 : ");
            CombatManaRegen = int.Parse(Console.ReadLine());
            Console.Write("비전투 중 마나 회복량");
            manaRegenOutofCombat = int.Parse(Console.ReadLine());
            Console.Write("이동 속도 : ");
            movespeed = float.Parse(Console.ReadLine());
            Console.Write("탈 것 속도 : ");
            ridespeed = float.Parse(Console.ReadLine());
            Console.Write("운반 속도 : ");
            carryspeed = float.Parse(Console.ReadLine());
            Console.Write("스킬 재사용 대기시간 감소 : ");
            cooldownReduction = float.Parse(Console.ReadLine());

            Console.WriteLine($"루인 스킬 피해                          : {Skill_Damage}%");
            Console.WriteLine($"카드 게이지 획득량                          : {Card_Gage}%");
            Console.WriteLine($"각성기 피해                          : {Awakedamage}%");
            Console.WriteLine($"최대 마나                        : {Max_Mana}%");
            Console.WriteLine($"전투 중 마나 회복량                          : {CombatManaRegen}%");
            Console.WriteLine($"비전투 중 마나 회복량                          : {manaRegenOutofCombat}%");
            Console.WriteLine($"이동 속도                          : {movespeed}%");
            Console.WriteLine($"탈 것 속도                          : {ridespeed}%");
            Console.WriteLine($"운반 속도                          : {carryspeed}%");
            Console.WriteLine($"스킬 재사용 대기시간 감소                          : {cooldownReduction}%");














        }
    }
}
