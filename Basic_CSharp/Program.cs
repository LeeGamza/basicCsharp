using System;


namespace Basic_CSharp
{


    class Program
    {
        //재귀 함수
        static int Factorial(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }

        //static int Factorial(int n)
        //{
        //    int result = 1;
        //    for (int i = 1; i <= n; i++)
        //    {
        //        result *= i;
        //    }
        //    return result;
        //}

        static void Main(string[] args)
        {
            // 5! = 5 * (4!)
            int ret = Factorial(5);
            Console.WriteLine(ret);
        }
    }
}

