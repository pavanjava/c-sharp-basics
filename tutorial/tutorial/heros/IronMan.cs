namespace tutorial;

public class IronMan : SuperHero
{
    public int SuiteVersion { get; set; }
    public bool IsCapableOfFightingThanos { get; set; }

    public override void Attack()
    {
        Console.WriteLine("Started Attacking with High Intensity Flare");
    }
}