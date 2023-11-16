using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_6th
{
    #region 의존관계 역전 원칙
    // 상위 계층이 하위 께층에 의존하는 전통적인 관계를 반전시킴으로써 상위 계층이 하위 계층의 구현으로부터 독립될 수 있도록 설계하는 원칙

    public class Character
    {
        private int health;
        Weapon weapon;

        public Character(int health, Weapon weapon)
        {
            this.health = health;
            this.weapon = weapon;
        }
        public void ChangeWeapon(Weapon weapon)
        {
            this.weapon = weapon;
        }

        public void Information()
        {
            Console.WriteLine("Weapon name : " + this.weapon.Name);
            Console.WriteLine("Weapon Atk : " + this.weapon.Attack);
            Console.WriteLine("Weapon durability : " + this.weapon.Durability);
            Console.WriteLine();
        }
    }

    #endregion
}
