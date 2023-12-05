using EndlessRunner;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class JumpControlHandler : MonoBehaviour
{

    public float moveSpeed = 5f;
    public GameObject playerToMove;
    private JumpControl jumpcontrol;

    public JumpControlHandler(InputAction RightAction, JumpControl jumpcont)
    {
        this.jumpcontrol = jumpcont;
        RightAction.performed += OnMove_performed;
        RightAction.Enable();
    }

    private void OnMove_performed(InputAction.CallbackContext obj)
    {
        this.jumpcontrol.Jump();
    }
}

