using System;
using System.Net.WebSockets;
using System.Security.Cryptography;
using Microsoft.Win32.SafeHandles;

namespace Basic_CSharp
{
    
    class Program
    {
        static int GetHighestScore(int[] scores)
        {

            int score = scores.Max();
            return score;
        }

        static int GetAverageScore(int[] scores)
        {
            return (int)scores.Average();
        }

        static int GetIndexOf(int[] scores, int value)
        {
            return Array.IndexOf(scores, value);
        }

        static void Sort(int[] scores)
        {
            Array.Sort(scores);
            
        }
        static void Main(string[] args)
        {
            // 배열
            
            int[] scores = new int[5] { 10, 30, 40, 20, 50 };
            Console.WriteLine($"Max : {GetHighestScore(scores)}");
            Console.WriteLine($"Avr : {GetAverageScore(scores)}");
            Console.WriteLine($"GetIndexOf : scores의 {GetIndexOf(scores, 100)}번째 인덱스 ** -1값은 잘못된 값을 넣을 시 반환됩니다. **");
            Sort(scores);
            Console.WriteLine($"Sort : {String.Join(", ", scores)}");
        }
    }
}