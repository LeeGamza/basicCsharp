namespace Solo_Practice_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 별을 중앙부터 찍어서 5층까지 내려가보자
            /*
             *      *
             *     **
             *    ***
             *   ****
             *  *****
             *  */

            int i, j, k, l;

            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < (4 - i - 1); j++)               
                {
                    Console.Write(" ");
                }
                for (k = 0; k <= i; k++)
                {
                    Console.Write("*");
                }
                for (l = 0; l < i; l++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}