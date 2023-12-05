using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.InputSystem;

namespace EndlessRunner
{
    public class RightControlHandler
    {
        // Start is called before the first frame update
        public float moveSpeed = 5f;
        public GameObject playerToMove;
        private RightControl rightcontrol;
        private LeftControl leftcontrol;
        public RightControlHandler(InputAction RightAction, RightControl rightcont, LeftControl leftcont)
        {
            this.rightcontrol = rightcont;
            this.leftcontrol = leftcont;
            RightAction.performed += OnMove_performed;
            RightAction.Enable();
        }
        // Update is called once per frame
        private void OnMove_performed(InputAction.CallbackContext obj)
        {
            this.rightcontrol.ToggleRight();
            this.leftcontrol.ToggleStop();
        }
    }
}
