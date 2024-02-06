//using System;
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class NewBehaviourScript : MonoBehaviour
//{
//    Vector2 sizeOfHitBox;
//    NewBehaviourScript()
//    {

//    }
//    // Start is called before the first frame update
//    void Start()
//    {
//        sizeOfHitBox = gameObject.GetComponent<BoxCollider2D>().size;
//    }

//    // Update is called once per frame
//    void Update()
//    {  
//    }

//    void Spawn()
//    {
//        for (int i = 0; i < 2; i++)
//        {
//            int randomInt = UnityEngine.Random.Range(minRange, maxRange + 1);
//            int tempLoc = UnityEngine.Random.Range(BoxCollider., maxRange + 1); ;
//            randomInt = ((int)Math.Floor((double)randomInt));

//            if (randomInt == 0 && i == 0)
//            {
//                tempLoc = UnityEngine.Random.Range(this.sizeOfHitBox.x + boundingBox[0]);
//                this.enemyPos[0] = -tempLoc - this.sizeOfHitBox.x + boundingBox[0];
//            }
//            else if (randomInt == 1 && i == 0)
//            {
//                tempLoc = UnityEngine.Random.Range(this.sizeOfHitBox.x + boundingBox[0]);
//                this.enemyPos[0] = tempLoc + this.sizeOfHitBox.x;
//            }
//            else if (randomInt == 0 && i == 1)
//            {
//                tempLoc = UnityEngine.Random.Range(this.sizeOfHitBox.y + boundingBox[1]);
//                this.enemyPos[1] = -tempLoc - this.sizeOfHitBox.y + boundingBox[1];
//            }
//            else if (randomInt == 1 && i == 1)
//            {
//                tempLoc = UnityEngine.Random.Range(this.sizeOfHitBox.y + boundingBox[1]);
//                this.enemyPos[1] = tempLoc + this.sizeOfHitBox.y;
//            }
//        }
//    }

//}
