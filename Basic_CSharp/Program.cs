using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading.Channels;
using System.Xml.Serialization;

namespace Basic_CSharp
{
    class Knight    // 참조
    {

        // 필드
        static public int counter = 1;    // 오로지 1개만 존재!

        public int id;
        public int hp;
        public int attack;

        public Knight()    // 생성자
        {
            id = counter;
            counter++;
            hp = 100;
            attack = 10;
            Console.WriteLine("생성자 호출!");
        }

        static public void Test()
        {
            counter++;  // 붕어빵 틀(class)에 종속적인 필드 or 함수가 되는것 || 만약 static이 없다면 인스턴스 즉 객체 자체의 종속된 함수로 됨
        }

        static public Knight CreateKnight()
        {
            Knight knight = new Knight();
            knight.hp = 100;
            knight.attack = 1;
            return knight;
        }
        public Knight Clone()
        {
            Knight knight = new Knight();
            knight.hp = hp;
            knight.attack = attack;
            return knight;
        }
        public void Move()
        {
            Console.WriteLine("Knight Move");
        }
        
        public void Attack()
        {
            Console.WriteLine("Knight Attack");
        }
    }
    
    class Program
    { 

        static void Main(string[] args)
        {
            Knight knight = Knight.CreateKnight();  // static
            knight.Move();  // 일반

            Console.WriteLine();

            Random rand = new Random();
            rand.Next();
        }
    }
}