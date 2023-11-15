using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_6th
{
    #region 단일 체계 원칙
    // 하나의 객체는 반드시 하나의 동작만의 책임을 수행해야함

    public class Monster
    {
        private string name;
        private int attack;
        private int health;

        public Monster(string name, int attack, int health)
        {
            this.name = name;
            this.attack = attack;
            this.attack = health;
        }

        public void Patrol()
        {
            Console.WriteLine("순찰하는 중...");
        }

        public string Representation()
        {
            return "name : " + name + ", attack : " + attack + ", health : " + health;
        }
    }
    #endregion
}
