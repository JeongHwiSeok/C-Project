using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_6th
{
    #region 개방 폐쇄 원칙
    // 객체의 확장은 열려있어야 하며, 객체의 수정에는 닫혀있어야 함

    class UnitManager
    {
        public void UnitCreater(Unit unit, int attack, int health)
        {
            unit.Atk = attack;
            unit.Hp = health;
        }

        public void MoveCommand(Unit unit)
        {
            unit.Move();
        }

        public void AttackCommand(Unit unit1, Unit unit2)
        {
            unit2.Hp -= unit1.Atk;
        }
    }
    #endregion
}
