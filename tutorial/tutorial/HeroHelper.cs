namespace tutorial;

public class HeroHelper<T>(T data) where T : SuperHero
{
    public void PrintName()
    {
        data.DisplayName();
    }

    public void AskHeroToAttack()
    {
        data.Attack();
    }
}