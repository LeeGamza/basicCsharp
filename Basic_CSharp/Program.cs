using System;


namespace Basic_CSharp
{
    class Program
    {
        static void Divide(int a, int b, out int result1, out int result2)
        {
            result1 = a / b;
            result2 = a % b;
        }
        //static void Swap(ref int a, ref int b)          // 인자 값 서로 바꾸기
        //{
        //    int temp = 0;
        //    temp = a;
        //    a = b;
        //    b = temp;
        //}


        //static void AddOne(ref int number)          // 원본 값 참조해서 값 더하기
        //{
        //    number = number + 1;
        //}

        //static int AddOne2(int number)              // 원본 값 복사해서 반환하기
        //{
        //    return number + 1;
        //}


        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 3;

            int result1;
            int result2;
            Divide(10, 3, out result1, out result2);
            Console.WriteLine($"{result1} {result2}");
        }
    }
}