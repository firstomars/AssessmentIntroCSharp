using System;
using System.Collections.Generic;
using System.Text;

namespace AIE_Assessment_Exercise_08
{
    class Character : GameObject
    {
        public int attack;
        public int health;
        public int defence;

        public Character()
        {

        }

        public Character(int att, int hp, int def)
        {
            this.attack = att;
            this.health = hp;
            this.defence = def;
        }

        public bool IsAlive()
        {
            return true;
        }

    }
}
