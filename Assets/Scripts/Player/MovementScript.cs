using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UIElements;

namespace EndlessRunner
{
    public class MovementScript : MonoBehaviour
    {
        // Start is called before the first frame update
        public float moveSpeed = 5f;
        public GameObject playerToMove;
        public TMP_Text scoreText;
        private float totalTime = 0f;
        private int score = 0;
        // Update is called once per frame
        void Update()
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
            totalTime += Time.deltaTime;
            if (totalTime >= 1f)
            {
                score++;
                scoreText.text = "Score: " + score.ToString();
                totalTime = 0f;
            }
        }
    }
}
