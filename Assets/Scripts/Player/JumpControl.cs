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
        [SerializeField] GameObject characterModel;

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
                jumpDistance = 5f * Time.deltaTime;
                transform.Translate(Vector3.up * jumpDistance);
                characterModel.GetComponent<Animator>().Play("Jump");
                if(transform.position.y > 3.5f)
                {
                    JumpStop();
                    Down();
                }
            }
            if (down)
            {
                jumpDistance = 7f * Time.deltaTime;
                transform.Translate(Vector3.down * jumpDistance);
                if (transform.position.y < 1.5f)
                {
                    DownStop();
                }
            }
            if(!jump){
                    characterModel.GetComponent<Animator>().Play("Standard Run");
            }
        }
    }
}