namespace Delegate_Practice2;
                 
                 class Program
                 {
                     public delegate void Mydele();
                     static void Main(string[] args)
                     {
                         Process process = new Process();
                         Mydele dele = new Mydele(process.AddOrder);     // 기본 값으로 AddOrder을 넣음
                 
                         while (true)
                         {
                             Console.WriteLine("[1] 장바구니에 물건 담기");
                             Console.WriteLine("[2] 장바구니 목록");
                             Console.WriteLine("[3] 장바구니 내 모든 품목 가격");
                             Console.WriteLine("[4] 나가기");
                 
                             int input = int.Parse(Console.ReadLine());
                 
                             if (input == 4)
                                 break;
                             
                             switch (input)
                             {
                                 case 1:
                                     dele();
                                     break;
                                 case 2:
                                     dele += process.ViewOrders;
                                     dele();
                                     break;
                                 case 3:
                                     dele += process.CalculateTotal;
                                     dele();
                                     break;
                                 default:
                                     break;
                             }
                         }
                 
                     }
                 }
                 // 듀얼모니터 개마렵네 시발꺼