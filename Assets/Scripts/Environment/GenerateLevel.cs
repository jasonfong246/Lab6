using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    public GameObject[] sections;
    public int zPos = 64;
    bool createSection = false;
    public int secNum;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if(createSection == false)
        {
            createSection = true;
            StartCoroutine(GenerateSection());
        }
    }

    IEnumerator GenerateSection()
    {
        secNum = Random.Range(0,3);
        Instantiate(sections[secNum],new Vector3(-0.5f,0.5f,zPos),Quaternion.identity);
        zPos += 64;
        yield return new WaitForSeconds(2);
        createSection = false;
    }
}
