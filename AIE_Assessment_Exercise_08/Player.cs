using System;
using System.Collections.Generic;
using System.Text;

namespace AIE_Assessment_Exercise_08
{
    public class Player : Character
    {
        public Player() : base ()
        {
            SetPosition(10, 10);
        }

        public Player(int attack, int health, int defence) : base (attack, health, defence)
        {

        }

        public override void Draw()
        {
            Console.Write("X");
        }
    }
}
