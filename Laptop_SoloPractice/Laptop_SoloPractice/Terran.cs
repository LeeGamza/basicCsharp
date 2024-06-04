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

// Terran, Protoss, Zerg는 Player와 Enemy에 상속된다? 
// 그럼 우예 둘다 상속받게함? 다중상속은 현직에서도 더러워져서 안쓰는데?
// 그럼 Player, Enemy를 Tribe소스를 쓰면되지않나?
// 너무 쓸데없이 자원낭비(시간복잡도 낭비)를한다.
// 현 방식은 Tribe -> Terran,Protoss,Zerg 
// 원하는 방식 Player -> Tribe -> Terran,Protoss,Zerg
//           Enemy -> Tribe -> Terran,Protoss,Zerg
// 근데 이걸 왜만들려고했던거임?? 그러게;...
// 내가 이걸 왜만들려고했찌....????????????
// 기획본질부터 찾아보자

// 턴제로 할꺼잖아
// 마린 = 2턴
// 탱크 = 5턴
// 레이스 = 3턴

// 적 인공지능 알고리즘
// player와 같은방식인데
// player파워에 밀리자않게 상황에따라 뽑게만들어야함
// 즉 if문으로 자원이 남아돌면 뽑게한다?? -> 원하는게 아님
// if문과 Random문도 쓴다?? -> 그건 랜덤이지 상황에따라 뽑는게아님 즉 레이스인데 저글링을 뽑을 수도있음
// 내가 하나하나 전부 if를 쓴다?? -> 소스엄청 더러울꺼같긴함 그리고 기준이 애매모호함

// 방벙은 찾았는데 지금 실력으론 구현 못함 그냥 더 공부하는게 Best임!!

