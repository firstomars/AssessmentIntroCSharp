using System;
using System.Collections.Generic;
using System.Text;

namespace AIE_Assessment_Exercise_08
{   
    public class GameObject
    {
        protected int xPosition;
        protected int yPosition;

        public GameObject()
        {

        }

        public GameObject(int xPos, int yPos)
        {
            this.xPosition = xPos;
            this.yPosition = yPos;
        }

        public virtual void Draw()
        {

        }

        public void SetPosition(int x, int y)
        {
            xPosition = x;
            yPosition = y;
        }
    }
}
