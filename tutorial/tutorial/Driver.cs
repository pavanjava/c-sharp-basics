using System.Collections;

namespace tutorial;

public class Driver
{
    static void Main(string[] args)
    {
        var ironMan = new IronMan();
        ironMan.FirstName = "Toney";
        ironMan.LastName = "Stark";
        ironMan.IsCapableOfFightingThanos = true;
        ironMan.SuiteVersion = 8;
        
        var drStrange = new DrStrange();
        drStrange.FirstName = "dr";
        drStrange.LastName = "strange";
        drStrange.IsCapableOfFightingThanos = true;
        drStrange.IsCapableOfTimeSpaceControlling = true;
        
        var hero1 = new HeroHelper<IronMan>(ironMan);
        hero1.PrintName();
        hero1.AskHeroToAttack();

        var hero2 = new HeroHelper<DrStrange>(drStrange);
        hero2.PrintName();
        hero2.AskHeroToAttack();
    }
}