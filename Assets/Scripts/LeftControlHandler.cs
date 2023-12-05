using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.InputSystem;

namespace EndlessRunner
{
    public class LeftControlHandler
    {
        // Start is called before the first frame update
        public float moveSpeed = 5f;
        public GameObject playerToMove;
        private LeftControl leftcontrol;
        private RightControl rightcontrol;
        public LeftControlHandler(InputAction leftAction, LeftControl leftcont, RightControl rightcont)
        {
            this.leftcontrol = leftcont;
            this.rightcontrol = rightcont;
            leftAction.performed += OnMove_performed;
            leftAction.Enable();
        }
        // Update is called once per frame
        private void OnMove_performed(InputAction.CallbackContext obj)
        {
            this.leftcontrol.ToggleLeft();
            this.rightcontrol.ToggleStop();
        }
    }
}
