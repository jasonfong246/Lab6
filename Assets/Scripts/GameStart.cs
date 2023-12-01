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
        // Start is called before the first frame update
        void Awake()
        {
            play = new PlayerControl();
            left = new LeftControlHandler(play.Player.Left, this.leftcontrol);
        }

        // Update is called once per frame
        void Update()
        {

        }

    }
}


