using UnityEngine;

namespace EndlessRunner
{
    public class RightControl : MonoBehaviour
    {
        // Start is called before the first frame update
        bool isRight = false;
        // Update is called once per frame
        public void ToggleRight()
        {
            isRight = true;
        }
        public void ToggleStop()
        {
            isRight = false;
        }

        private void Update()
        {
            if (isRight)
            {
                if (transform.position.x >= 9)
                {
                    ToggleStop();
                }
                transform.Translate(Vector3.left * 5f * Time.deltaTime * -1);
            }
        }
    }
}
