namespace tutorial;

public class DrStrange: SuperHero
{
    public bool IsCapableOfTimeSpaceControlling { get; set; }
    public bool IsCapableOfFightingThanos { get; set; }

    public override void Attack()
    {
        Console.WriteLine("Started Attacking By Modifying Time and Space Dimensions");
    }
}