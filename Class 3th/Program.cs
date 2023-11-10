using System;

namespace Class_3th
{
    #region 메소드 숨기기
    public class Weapon
    {
        protected int attack;

        public void Information()
        {
            Console.WriteLine("Weapon Information");
        }

        public virtual void Action()
        {
            Console.WriteLine("Weapon Action");
        }
    }

    public class Sword : Weapon
    {
        public new void Information()
        {
            Console.WriteLine("Sword Information");
        }

        public override void Action()
        {
            Console.WriteLine("Sword Action");
        }
    }

    #endregion
    #region 프로퍼티
    public class Transform
    {
        private int x;
        private int y;
        private int z;

        public int X
        {
            set
            {
                if (value >= 100)
                {
                    Console.WriteLine("Recived an Unexpected Value");
                    return;
                }
                else
                {
                    x = value;
                }
            }
            get
            {
                return x;
            }
        }
    }

    #endregion
    #region 함수의 오버로딩
    public class GameObject
    {
        public void Destroy()
        {
            Console.WriteLine("Destroy GameObject");
        }

        public void Destroy(float timer)
        {
            Console.WriteLine("Destroy GameObject " + " Destroy Time : " + timer);
        }

        public void GetComponent(string name, int id)
        {
            Console.WriteLine("name : " + name);
            Console.WriteLine("id : " + id);
        }

        public void SetActive(bool active = true)
        {
            Console.WriteLine("GameObject state : " + active);
        }
    }
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            // 프로퍼티
            /*
            Transform transform = new Transform();

            transform.X = 100;

            Console.WriteLine(transform.X);
            */

            // 메소드 숨기기
            //Sword sword = new Sword();
            //sword.Action();

            // 가상 함수
            //Weapon weapon = new Sword();
            //weapon.Information();
            //weapon.Action();

            // 함수의 오버로딩
            GameObject gameObject = new GameObject();

            //gameObject.Destroy();

            //gameObject.Destroy(5f);

            // 명명된 매개변수
            //gameObject.GetComponent(id: 5, name: "Sphere");
            //gameObject.GetComponent("Box", 10);

            // 선택적 매개변수
            gameObject.SetActive();
            gameObject.SetActive(false);
        }
    }
