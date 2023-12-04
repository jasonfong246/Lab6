using UnityEngine;

namespace EndlessRunner
{
    public class LeftControl : MonoBehaviour
    {
        // Start is called before the first frame update
        bool isLeft = false;
        float distance = 2.5f;
        float distanceMoved = 0f;
        // Update is called once per frame
        public void ToggleLeft()
        {
            isLeft = true;
            distanceMoved = 0f;
        }
        public void ToggleStop()
        {
            isLeft = false;
            distanceMoved = 0f;
        }

        private void Update()
        {
            if (isLeft)
            {
                //((Mathf.Approximately(Mathf.Abs(transform.position.x), 0f)) || (Mathf.Approximately(Mathf.Abs(transform.position.x), -5f)))
                if (transform.position.x < -2.5f)
                {
                    ToggleStop();
                }
                if (distanceMoved < distance) { 
                float movement = 5f * Time.deltaTime;
                transform.Translate(Vector3.left * movement);
                distanceMoved += Mathf.Abs(movement);
                }
            }
        }
    }
}
