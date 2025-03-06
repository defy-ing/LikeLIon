﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEXTRPG
{
    public class Monster
    {
        public INFO m_tMonster; //인포구조에 체력 공격력 방어력 다잇엇음 얘눈 몬스터 데이터임

        public void SetDamage(int iAttack) { m_tMonster.iHp -= iAttack; } //들어오는 인자값으로 hp 감소

        //INFO 클래스 타입 인자로 몬스터 데이터를 넣어준다.
        public void SetMonster(INFO tMonster) { m_tMonster=tMonster; }

        public INFO GetMonster() { return m_tMonster; }


        public void Render()
        {
            Console.WriteLine("=========================");
            Console.WriteLine("몬스터 이름 : " + m_tMonster.strName);
            Console.WriteLine("체력 : " + m_tMonster.iHp + "\t공격력 :  " + m_tMonster.iAttack);
        }

        public Monster() { } //기본 생성자
        ~Monster() { } //소멸자 

    }
}
