using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AIE_Assessment_Exercise_08
{
    public class Room
    {
        protected GameObject[] gameObjects = new GameObject[3];
        
        public void AddGameObject(GameObject go)
        {
            for (int i = 0; i < gameObjects.Length; i++)
            {
                if(gameObjects[i] == null)
                {
                    gameObjects[i] = go;
                    break;

                }
            }
        }

        public void RemoveGameObject(GameObject go)
        {
            for (int i = 0; i < gameObjects.Length; i++)
            {
                if (gameObjects[i] == go)
                {
                    gameObjects[i] = null;
                }
            }

            // kinda hacky
            gameObjects = gameObjects.OrderByDescending(obj => (obj == null ? 0 : 1)).ToArray();
        }

        public void Draw()
        {

            bool isRoomEmpty = gameObjects[0] == null;
            if(isRoomEmpty)
            {
                Console.Write("_");
            }
            else
            {
                gameObjects[0].Draw();
            }
        }
    }
    //REMOVE GAMEOBJECT FROM ARRAY

    //1
    //List<GameObject> gameObjectList = gameObject.ToList();
    //gameObjectList.Remove(go);
    //        gameObjectList.ToArray(); //this creates a new array. not ideal

    //        //2 
    //        gameObject = gameObject.Where(val => val != go).ToArray(); // this filters all values except for go back to array

    //        //find empty spots in array
    //        for (int i = 0; i<gameObject.Length; i++)
    //        {
    //            if (gameObject[i] == null)
    //            {
    //                if (gameObject[i + 1] != null)
    //                {
    //                    gameObject[i] = gameObject[i + 1];
    //                }

    //                else
    //                {
    //                    go = gameObject[i];
    //                }
    //            }
    //        }
}
