/*
 * Appendix 4 - Exercise 2: Adventure Game
 */

using System;

namespace AIE_Assessment_Exercise_08
{
    public class Program
    {
        static void Main(string[] args)
        {
            Room[,] map = new Room[3, 3];
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    map[row, col] = new Room();
                }
            }

            Player p = new Player();
            Enemy e = new Enemy(10, 27, 6);
            PowerUp pu = new PowerUp();

            //instantiate three gameObjects

            //The objects array in the Room class is always initialized as an array of 3 GameObjects.
            //When the Room.AddGameObject() function is called, the input argument is inserted into the first index in the array containing a null value.


            map[1, 1].AddGameObject(p);
            map[2, 0].AddGameObject(e);
            map[0, 1].AddGameObject(pu);

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    map[row, col].Draw();
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
