﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solo_Practice_CSharp
{
    public enum PlayerType
    {
        None,
        Knight,
        Archer,
        Mage
    }
    internal class Player : Creature
    {
        protected PlayerType _type = PlayerType.None;

        protected Player(PlayerType type) : base(CreatureType.Player)
        {
            _type = type;
        }
    }

    class Knight : Player
    {
        public Knight() : base(PlayerType.Knight)
        {
            SetInfo(100, 10);
        }
    }

    class Archer : Player
    {
        public Archer() : base(PlayerType.Archer)
        {
            SetInfo(75, 12);
        }
    }

    class Mage : Player
    {
        public Mage() : base(PlayerType.Mage)
        {
            SetInfo(50, 15);
        }
    }
}
