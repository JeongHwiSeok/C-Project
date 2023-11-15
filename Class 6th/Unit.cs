using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_6th
{
    public abstract class Unit
    {
        protected int atk;
        protected int hp;

        public int Atk
        {
            set
            {
                atk = value;
            }
            get
            {
                return atk;
            }
        }

        public int Hp
        {
            set
            {
                hp = value;
            }
            get
            {
                return hp;
            }
        }

        public abstract void Move();
        public abstract void Attack();
    }
}
