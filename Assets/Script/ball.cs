using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public GameObject youWinText;
    // Start is called before the first frame update
    void Start()
    {
        youWinText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // void Endgame()
    // {
    //     if(collision.gameObject.tag =="menang")
    //     {
    //         Time.timeScale = 0;
    //         Destroy(gameObject);
    //     }
    // }
    // private void OnCollisionEnter(Collision collision)
    // {
    //     if(collision.collider.CompareTag("bola"));
    //     {
    //         Time.timeScale = 0;
    //         Destroy(gameObject);
    //     }
    // }
    void OnTriggerEnter(Collider obj)
    {
        if (obj.gameObject.tag == "bola"){
            Destroy(obj.gameObject);
            youWinText.SetActive(true);
            
        }    
    }
}
