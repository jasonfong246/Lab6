using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EndlessRunner { 
    public class FollowWithOffset : MonoBehaviour
    {
        [SerializeField] private Transform target;
        [SerializeField] private Vector3 offset;
        private void Update()
        {
            //Updates the position of the camera so that it follows the camera
            transform.position = target.position + offset;
        }
    }
}
