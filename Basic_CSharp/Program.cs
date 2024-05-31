using System;


namespace Basic_CSharp
{

    // 오버로딩 : 함수 이름의 재사용

    class Program
    {

        static int Add(int a, int b)
        {
            Console.WriteLine("Add int 호출");
            return a + b;
        }

        //static int Add(int a, int b, int c)
        //{
        //    Console.WriteLine("Add int 인자 3개 호출");
        //    return a + b + c;
        //}                 
        static int Add(int a, int b, int c = 0, float d = 1.0f, double e = 3.0)                 // 선택적 매게변수 || 받는 외부에서 인자가 2개를 받아도되고, 3개를 받아도됨 
        {
            Console.WriteLine("Add int 인자 3개 호출");
            return a + b + c;
        }

        static float Add(float a, float b)
        {
            Console.WriteLine("Add float 호출");
            return a + b;
        }


        static void Main(string[] args)
        {
            int ret = Program.Add(2, 3);
            int ret2 = Program.Add(3, 4, d:2.0f);
            float ret3 = Program.Add(2.0f, 3.0f);
            //Console.WriteLine(ret);
        }
    }
}