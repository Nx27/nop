namespace Kevin.Mover {
    using UnityEngine;
    using System.Collections;
    public class Mover : MonoBehaviour {
        
        public void Update() {
            if(InteractWithMovement()) return;
        }

        private bool InteractWithMovement() {
            if(Input.GetKeyDown("left")) {
                Debug.Log("Left key was pressed!");
            }

            if(Input.GetKeyDown("right")) {
                Debug.Log("right is pressed!");
            }

            if(Input.GetKeyDown("up")) {
                Debug.Log("up is pressed!");
            }

            if(Input.GetKeyDown("down")) {
                Debug.Log("down is pressed!");
            }
        return false;
            
        }

    }
}