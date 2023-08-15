using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDino : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject dino;
    void Start()
    {
        StartCoroutine(DinoSpawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator DinoSpawn()
    {
        Instantiate(dino, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(60);
        StartCoroutine(DinoSpawn());
    }
}
