namespace Delegate_Practice2;

public class Order
{
    
    // 이걸 프로퍼티로도 바꾸자 나중에
    
    private string _name { get; }
    private int _count { get; }
    private int _price { get; }

    public Order(string name, int count, int price)
    {
        _name = name;
        _count = count;
        _price = price;
    }

    public void OrderInfo()
    {
        _count.ToString();
        _price.ToString();
        
        // 이게 필요할까? 일단 미리 만들어놓자
        Console.Write($"{_name} ");             // _name이 2개 이상될때 분류를 ,로 자동추가해주는거 찾아봐라
        
        
    }
}