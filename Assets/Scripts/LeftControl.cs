using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EndlessRunner
{
    public class LeftControl : MonoBehaviour
    {
        // Start is called before the first frame update
        bool isLeft = false;
        // Update is called once per frame
        public void ToggleLeft()
        {
            isLeft = true;
        }

        private void Update()
        {
            if (isLeft)
            {
                transform.Translate(Vector3.left * 5f * Time.deltaTime);
            }
        }
    }
}
