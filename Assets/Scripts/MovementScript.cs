using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace EndlessRunner
{
    public class MovementScript : MonoBehaviour
    {
        // Start is called before the first frame update
        public float moveSpeed = 5f;
        public GameObject playerToMove;
        // Update is called once per frame
        void Update()
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
    }
}
