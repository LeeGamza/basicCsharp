using System;
using System.Net.WebSockets;
using System.Security.Cryptography;
using Microsoft.Win32.SafeHandles;

namespace Basic_CSharp
{
    class Program
    {
        abstract class Monster      // 추상클래스
        {
            public abstract void Shout(); // 추상함수
        }

        interface IFlayable         // 나의 기능을 갖고 있는 아이라면 반드시 Fly 함수를 제공해야한다
        {
            void Fly();
        }

        class Orc : Monster
        {
            public override void Shout()    // 추상클래스안에있는 추상함수를 반드시 사용하라 라고 강요함
            {
                Console.WriteLine("록타르 오가르!");
            }
        }

        class FlableOrc : Orc, IFlayable      // C#에서는 다중상속 안됨!
        {
            public void Fly()
            {
                
            }
        }

        class Skeleton : Monster
        {
            public override void Shout()
            {
                Console.WriteLine("꾸에에에엑");
            }
        }
        
        static void Main(string[] args)
        {
            // 추상클래스와 Interface
            
        }
    }
}