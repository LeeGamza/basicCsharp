using System;
using System.Collections.Generic;
using System.Linq;

namespace Delegate_Practice2;

public class Process
{
    
    private List<Order> orderList = new List<Order>();
    
    public void AddOrder()      // 장바구니 담기
    {
        while (true)
        {
            Console.WriteLine("주문하실 물건을 선택해 담아주세요");
            Console.WriteLine("[1] 샴푸");
            Console.WriteLine("[2] 세재");
            Console.WriteLine("[3] 치약");
            Console.WriteLine("[4] 장바구니 담고 나가기");
            int input = int.Parse(Console.ReadLine());

            if (input == 4)
                break;
            
            switch (input)
            {
                
                case 1:
                    orderList.Add(new Order("샴푸",1,6000));
                    break;
                case 2:
                    orderList.Add(new Order("세재", 1, 4000));
                    break;
                case 3:
                    orderList.Add(new Order("치약", 1, 1500));
                    break;
                default:
                    break;
            }
        } 
    }
    
    public void ViewOrders()    
    {
        foreach (Order basket in orderList)
            basket.OrderInfo();
    }
    
    public void CalculateTotal()    
    {
        // 문제자체가 잘못됏다.
        // 이 당시나는 LINQ를 쓸줄 모른다. 하지만 LINQ가 필요한 문제를 GPT가 냈다.
        // GPT가 내준 메서드명으로만 꾸며볼려했다. 하지만 할 수없는 구조이다.
        // 그렇다면 이걸 푸는방법은 2가지다
        // GetTotalPrice라는 메서드를 Order.cs에 만들거나
        // Order클래스의 필드를 private => public으로 바꿔야한다.
        // 그럼 대체 왜 델리케이트를 쓰는거지
        // 델리케이트는 의존성을 낮출려고 하고, 은닉성을 키울려고하는건데
        // 클래스의 속성을 public으로 할꺼면 쓸 이유조차도 없어지게된다.
        // 따라서 calculateTotal은 풀지않겠다.
    }
}
