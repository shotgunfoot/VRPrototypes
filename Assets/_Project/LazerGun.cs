using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Valve.VR.InteractionSystem
{
    public class LazerGun : MonoBehaviour
    {
        //The point where the gun is held in hand.
        public Transform HandleTransform;

        private void Start() {
            transform.localRotation = Quaternion.Euler(4.826f, -85.775f, -62.35f);
            
        }
        
        

    }
}