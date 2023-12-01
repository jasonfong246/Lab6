using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.InputSystem;

namespace EndlessRunner
{
    public class LeftControl : MonoBehaviour
    {
        // Start is called before the first frame update
        public float moveSpeed = 5f;
        public GameObject playerToMove;
        public LeftControl(InputAction leftAction)
        {
            leftAction.performed += OnMove;
            leftAction.Enable();
        }
        // Update is called once per frame
        private void OnMove(InputAction.CallbackContext obj)
        {
            playerToMove.transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
    }
}
