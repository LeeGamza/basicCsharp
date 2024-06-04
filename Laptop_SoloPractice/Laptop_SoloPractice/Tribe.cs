namespace Laptop_SoloPractice;

public enum TribeClass
{
    None,
    Terran,
    Protoss,
    Zerg
}

public class Tribe
{
    protected TribeClass _tribe = TribeClass.None;
    protected int hp;
    protected int mp;
    protected int shild;
    protected int atk;

    protected Tribe(TribeClass tribe)
    {
        _tribe = tribe;
    }
    
}