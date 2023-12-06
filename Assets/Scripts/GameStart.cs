using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EndlessRunner.Inputs;
using TMPro;

namespace EndlessRunner
{
    public class GameStart : MonoBehaviour
    {
        private PlayerControl play;
        private LeftControlHandler left;
        [SerializeField] private LeftControl leftcontrol;
        private RightControlHandler right;
        private JumpControlHandler jump;
        [SerializeField] private RightControl rightcontrol;
        [SerializeField] private JumpControl jumpcontrol;
        // Start is called before the first frame update
        void Awake()
        {
            play = new PlayerControl();
            left = new LeftControlHandler(play.Player.Left, this.leftcontrol,this.rightcontrol);
            right = new RightControlHandler(play.Player.Right, this.rightcontrol,this.leftcontrol);
            jump = new JumpControlHandler(play.Player.Jump, this.jumpcontrol);

        }

    }
}


