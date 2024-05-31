using System;


namespace Basic_CSharp
{

    // 오버로딩 : 함수 이름의 재사용

    class Program
    {

        static void Main(string[] args)
        {
            for (int i = 2; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
            }
        }
    }
}