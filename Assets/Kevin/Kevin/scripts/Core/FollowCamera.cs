namespace Kevin.Core
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class Follow : MonoBehaviour {
        [SerializeField] Transform target;

        //update called once per frame
        void update() {
            transform.position = target.position;
        }
    }

}