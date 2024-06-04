namespace Laptop_SoloPractice;

public enum ProtossClass
{
    None,
    Zealot,
    Archon,
    Scout
}
public class Protoss : Tribe
{
    protected ProtossClass _type = ProtossClass.None;

    protected Protoss(ProtossClass tpye) : base(TribeClass.Protoss)
    {
        _type = _type;
    }
}

public class Zealot : Protoss
{
    public Zealot() : base(ProtossClass.Zealot)
    {
        
    }
}
public class Archon : Protoss
{
    public Archon() : base(ProtossClass.Archon)
    {
        
    }
}
public class Scout : Protoss
{
    public Scout() : base(ProtossClass.Scout)
    {
        
    }
}