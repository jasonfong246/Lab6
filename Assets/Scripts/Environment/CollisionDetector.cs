using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EndlessRunner;
using UnityEngine.SceneManagement;
using TMPro;

public class CollisionDetector : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject characterModel;

    // Start is called before the first frame update
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("obstacle"))
        {
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
            player.GetComponent<MovementScript>().enabled = false;
            player.GetComponent<JumpControl>().enabled = false;
            characterModel.GetComponent<Animator>().Play("Stumble Backwards");
            StartCoroutine(EndGame());
        }
    }
    IEnumerator EndGame()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(0);

    }
}
