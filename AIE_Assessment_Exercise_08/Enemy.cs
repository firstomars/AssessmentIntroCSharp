﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AIE_Assessment_Exercise_08
{
    public class Enemy : Character
    {
        public Enemy()
        {
            SetPosition(5, 5);
        }

        public Enemy(int attack, int health, int defence) : base(attack, health, defence) 
        {

        }

        public override void Draw()
        {
            if (health > 10)
            {
                Console.Write("O");
            }

            else
            {
                Console.Write("o");
            }
        }
    }
}
