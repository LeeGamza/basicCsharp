namespace Laptop_SoloPractice;

public enum TerranClass
{
    None,
    Marine,
    Tank,
    Wraith
}

public class Terran : Tribe
{
    protected TerranClass _type = TerranClass.None;
    
    protected Terran(TerranClass type) : base(TribeClass.Terran)
    {
        _type = type;
    }
}

public class Marin : Terran
{
    public Marin() : base(TerranClass.Marine)
    {
        
    }
}
public class Tank : Terran
{
    public Tank() : base(TerranClass.Tank)
    {
        
    }
}
public class Wraith : Terran
{
    public Wraith() : base(TerranClass.Wraith)
    {
        
    }
    
}


// 구도를

// 상수열거 = 집합

// 집합 변수들이 있자나, 중복된 변수는 지가걸러줌

