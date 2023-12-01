using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EndlessRunner.Inputs;


namespace EndlessRunner
{
    public class GameStart : MonoBehaviour
    {
        private PlayerControl play;
        private LeftControl left;
        // Start is called before the first frame update
        void Awake()
        {
            play = new PlayerControl();
            left = new LeftControl(play.Player.Left);
        }

        // Update is called once per frame
        void Update()
        {

        }

    }
}


