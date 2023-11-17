using System;

namespace Class_6th
{
    #region S O L I D
    // S : 단일 책임 원칙
    // O : 개방 폐쇄 원칙
    // L : 
    // I : 인터페이스 분리 원칙
    // D : 의존관계 역전 원칙
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            #region SRP 5대 원칙
            //Monster spider = new Monster("Spider", 10, 100);

            //spider.Patrol();

            //Information information = new Information();

            //information.MosterInfo(spider);
            #endregion

            #region OCP 5대 원칙
            //Marine marine1 = new Marine();
            //FireBet firebet1 = new FireBet();
            //Ghost ghost1 = new Ghost();

            //UnitManager unitmanager = new UnitManager();

            //unitmanager.MoveCommand(marine1);
            //unitmanager.MoveCommand(firebet1);
            //unitmanager.MoveCommand(ghost1);
            #endregion

            #region LSP 5대 원칙
            //Zergling zergling = new Zergling();

            //zergling.Ground();
            //zergling.AttackCommand();
            //zergling.Move();

            //Console.WriteLine();

            //Mutalisk mutalisk = new Mutalisk();

            //mutalisk.Fly();
            //mutalisk.AttackCommand();
            //mutalisk.Move();
            #endregion

            #region ISP 5대 원칙
            //Wraith wraith = new Wraith();

            //wraith.Skill();
            //wraith.Move();
            //wraith.Attack();

            //Valkyrie valkyrie = new Valkyrie();

            //valkyrie.Move();
            //valkyrie.Attack();

            //Dropship dropship = new Dropship();

            //dropship.Skill();
            //dropship.Move();

            //Battlecruiser battlecruiser = new Battlecruiser();

            //battlecruiser.Skill();
            //battlecruiser.Move();
            //battlecruiser.Attack();

            #endregion

            #region DIP 5대 원칙

            //Axe axe = new Axe();
            //Rifle rifle = new Rifle();
            //Knife knife = new Knife();

            //Character player = new Character(100, knife);
            //player.Information();

            //player.ChangeWeapon(rifle);
            //player.Information();

            //player.ChangeWeapon(axe);
            //player.Information();

            #endregion
        }
    }
}
