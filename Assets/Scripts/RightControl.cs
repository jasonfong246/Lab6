using Unity.VisualScripting;
using UnityEngine;

namespace EndlessRunner
{
    public class RightControl : MonoBehaviour
    {
        // Start is called before the first frame update
        bool isRight = false;
        float distance = 2.5f;
        float distanceMoved = 0f;
        // Update is called once per frame
        public void ToggleRight()
        {
            isRight = true;
            distanceMoved = 0f;
        }
        public void ToggleStop()
        {
            isRight = false;
            distanceMoved = 0f;
        }

        private void Update()
        {
            if (isRight)
            {
                //((Mathf.Approximately(Mathf.Abs(transform.position.x), 0f)) || (Mathf.Approximately(Mathf.Abs(transform.position.x), 5f)))
                if (transform.position.x >2.5f)
                {
                    ToggleStop();
                }
                if (distanceMoved < distance)
                {
                    float movement = 5f * Time.deltaTime;
                    transform.Translate(Vector3.right * movement);
                    distanceMoved += Mathf.Abs(movement);
                }
            }
        }
    }
}
