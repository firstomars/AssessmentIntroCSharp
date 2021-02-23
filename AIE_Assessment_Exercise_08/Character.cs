using System;
using System.Collections.Generic;
using System.Text;

namespace AIE_Assessment_Exercise_08
{
    public class Character : GameObject
    {
        protected int attack;
        protected int health;
        protected int defence;

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
