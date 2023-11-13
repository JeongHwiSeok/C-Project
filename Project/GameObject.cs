using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_4th
{
    public class GameObject
    {
        private int guID;

        public int GUID
        {
            set
            {
                guID = value;
            }
            get
            {
                return guID;
            }
        }

        public GameObject Clone()
        {
            GameObject gameObjectClone = new GameObject();

            gameObjectClone.guID = guID;

            return gameObjectClone;
        }

    }
}
