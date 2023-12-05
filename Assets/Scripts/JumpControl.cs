using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

namespace EndlessRunner
{
    public class JumpControl : MonoBehaviour
    {

        bool jump = false;
        bool down = false;
        float jumpDistance = 2.5f;

        public void Jump()
        {
            jump = true;
        }
        public void JumpStop()
        {
            jump = false;
        }
        public void Down()
        {
            down = true;
        }
        public void DownStop()
        {
            down = false;
        }

        private void Update()
        {
            if (jump)
            {
                DownStop();
                jumpDistance = 2f * Time.deltaTime;
                transform.Translate(Vector3.up * jumpDistance);
                if(transform.position.y > 2f)
                {
                    JumpStop();
                    Down();
                }
            }
            if (down)
            {
                jumpDistance = 2f * Time.deltaTime;
                transform.Translate(Vector3.down * jumpDistance);
                if (transform.position.y < 0.5f)
                {
                    DownStop();
                }
            }
            
        }
    }
}