namespace Delegate_Practice2;

public class Process
{
    public delegate void orderDele();
    
    
    private List<Order> orderList = new List<Order>();
    public void AddOrder()      // 장바구니 담기
    {
        while (true)
        {
            Console.WriteLine("주문하실 물건을 선택해 담아주세요");
            Console.WriteLine("[1] 샴푸");
            Console.WriteLine("[2] 세재");
            Console.WriteLine("[3] 치약");
            Console.WriteLine("[4] 장바구니 확인하기");
            Console.WriteLine("[5] 상품 주문하기");
        
            int input = int.Parse(Console.ReadLine());

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
                case 4:
                    foreach (Order basket in orderList)
                        basket.OrderInfo();
                    break;
                case 5:
                    
                    break;
                default:
                    break;
            }
        }
        
        

        // 신성한 빌드 중에 아빠가 난입
        // 머릿속으로 구현방법 떠올림
        // 리스트에 제너릭써서 Order클래스 속성들을 들고와서 리스트에 담자
        
        // 이후 작업
        // AddOrder에 반복문 써서 충분히 담았으면 담기종료만들기
    }
    
    public void ViewOrders()    // 장바구니 내역보기
    {
        // Order 클래스의 OrderInfo를 담으면 될듯
    }
    
    public void CalculateTotal()    // 장바구니 담긴 물건 전체가격
    {
        
    }
}

// 간단한 사칙연산 델리
// 굳이??
