using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_6th
{
    #region 리스코프 치환 원칙
    // 상위 클래스와 하위 클래스가 있을 때 상위 클래스가 호출하는 동작에서 하위 클래스가 상위 클래스를 완벽하게 대체할 수 있어야 하는 원칙
    
    public abstract class Zerg
    {
        protected int health;
        protected int attack;
        protected int depence;

        public int Health
        {
            set
            {
                this.health = value;
            }
            
            get
            {
                return health;
            }
        }

        public int Attack
        {
            set
            {
                this.attack = value;
            }

            get
            {
                return attack;
            }
        }

        public int Depence
        {
            set
            {
                this.depence = value;
            }

            get
            {
                return depence;
            }
        }

        public abstract void Move();

        public abstract void AttackCommand();
    }

    #endregion
}
