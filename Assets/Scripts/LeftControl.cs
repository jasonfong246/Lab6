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
        public void ToggleStop()
        {
            isLeft = false;
        }

        private void Update()
        {
            if (isLeft)
            {
                if (transform.position.x <= 0)
                {
                    ToggleStop();
                }   
                transform.Translate(Vector3.left * 5f * Time.deltaTime);
            }
        }
    }
}
