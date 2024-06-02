using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solo_Practice_CSharp
{
    public enum CreatureType
    {
        None,
        Player,
        Monster
    }
    internal class Creature
    {
        protected CreatureType _type = CreatureType.None;
        protected int hp;
        protected int maxHp;
        protected int atk;
        //protected int exp;
        //protected int maxExp;
        
        protected Creature(CreatureType type)
        {
            _type = type;
        }

        protected void SetInfo(int maxHp, int atk)
        {
            this.maxHp = maxHp;
            this.atk = atk;
            hp = this.maxHp; 
        }

        public int GetHp() { return hp; }
        
        public bool IsDead() { return hp <= 0; }

        public void Attack(int damage)
        {
            hp -= damage;
        }

        public void OnDamaged()
        {
            if (hp <= 0)
            {
                hp = 0;
            }
        }

    }
}
