using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solo_Practice_CSharp
{
    public enum MonsterType
    {
        None,
        Slime,
        Goblin,
        Undead
    }
    internal class Monster : Creature
    {
        protected MonsterType _type = MonsterType.None;

        protected Monster (MonsterType type) : base(CreatureType.Monster)
        {
            _type = type;
        }
    }

    class Slime : Monster
    {
        public Slime() : base(MonsterType.Slime)
        {
            SetInfo(15, 5);
        }
    }
    class Goblin : Monster
    {
        public Goblin() : base(MonsterType.Goblin)
        {
            SetInfo(20, 10);
        }
    }
    class Undead : Monster
    {
        public Undead() : base(MonsterType.Undead)
        {
            SetInfo(16, 15);
        }
    }
}
