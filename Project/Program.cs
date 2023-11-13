using System;

namespace Class_4th
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 얕은 복사
            //GameObject gameObject1 = new GameObject();

            //GameObject gameObject2 = gameObject1;

            //gameObject2.GUID = 99;

            //Console.WriteLine("gameObject1의 GUID : " + gameObject1.GUID);
            //Console.WriteLine("gameObject2의 GUID : " + gameObject2.GUID);
            #endregion

            #region 깊은 복사
            //GameObject clone1 = new GameObject();
            //GameObject clone2 = clone1.Clone();

            //clone1.GUID = 456;
            //clone2.GUID = 111;

            //Console.WriteLine("Clone1.GUID : " + clone1.GUID);
            //Console.WriteLine("Clone2.GUID : " + clone2.GUID);
            #endregion

            #region 인터페이스
            //Player player = new Player();

            //player.OnTriggerEnter(new Magnet());
            //player.OnTriggerEnter(new Missile());
            //player.OnTriggerEnter(new Shield());
            #endregion

            #region 추상 클래스

            //Juggling juggling = new Juggling();
            
            //juggling.Information();
            //juggling.Skill();

            #endregion
        }
    }
}
