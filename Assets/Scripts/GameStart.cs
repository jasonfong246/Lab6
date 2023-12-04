using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EndlessRunner.Inputs;


namespace EndlessRunner
{
    public class GameStart : MonoBehaviour
    {
        private PlayerControl play;
        private LeftControlHandler left;
        [SerializeField] private LeftControl leftcontrol;
        private RightControlHandler right;
        [SerializeField] private RightControl rightcontrol;
        // Start is called before the first frame update
        void Awake()
        {
            play = new PlayerControl();
            left = new LeftControlHandler(play.Player.Left, this.leftcontrol,this.rightcontrol);
            right = new RightControlHandler(play.Player.Right, this.rightcontrol,this.leftcontrol);
        }

        // Update is called once per frame
        void Update()
        {

        }

    }
}


