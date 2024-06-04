namespace Laptop_SoloPractice;

public enum ZergClass
{
    None,
    Zergling,
    Mutalisk,
    Ultralisk
}

public class Zerg : Tribe
{
    protected ZergClass _type = ZergClass.None;

    protected Zerg(ZergClass type) : base(TribeClass.Zerg)
    {
        _type = type;
    }
}

public class Zergling : Zerg
{
    public Zergling() : base(ZergClass.Zergling)
    {
        
    }
}
public class Mutalisk : Zerg
{
    public Mutalisk() : base(ZergClass.Mutalisk)
    {
        
    }
}
public class Ultralisk : Zerg
{
    public Ultralisk() : base(ZergClass.Ultralisk)
    {
        
    }
}