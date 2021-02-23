using System;
using System.Collections.Generic;
using System.Text;

namespace AIE_Assessment_Exercise_08
{
    public class PowerUp : GameObject
    {
        public PowerUp()
        {

        }
        
        public PowerUp(int xPos, int yPos) : base(xPos, yPos)
        {

        }

        public override void Draw()
        {
            Console.Write("?");
        }
    }
}
