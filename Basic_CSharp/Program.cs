using System;
using System.Linq.Expressions;
using System.Threading.Channels;
using System.Xml.Serialization;

namespace Basic_CSharp
{

    // 객체 (OOP Object Oriented Programming)

    // Knight
    // 속성 : hp, atk, pos(위치)
    // 기능 : Move, Attack, Die

    class Knight
    {
        public int hp;
        public int attack;

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
            Knight knight = new Knight();

            knight.hp = 100;
            knight.attack = 10;

            knight.Move();
            knight.Attack();
        }
    }
}

