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

    class Knight    // 참조
    {
        public int hp;
        public int attack;

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

    struct Mage // 복사
    {
        public int hp;
        public int attack;
    }
    
    
    
    class Program
    { 
        
        static void KillMage(Mage mage)
        {
            mage.hp = 0;
        }
        static void KillKnight(Knight knight)
        {
            knight.hp = 0;
        }
        static void Main(string[] args)
        {
            Mage mage;
            mage.hp = 100;
            mage.attack = 50;
            

            Mage mage2 = mage;
            mage2.hp = 0;

            Knight knight = new Knight();
            knight.hp = 100;
            knight.attack = 10;
            knight.Move();
            knight.Attack();
            


            Knight knight2 = knight.Clone();
            knight2.hp = 0;
            
        }
    }
}

