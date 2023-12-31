using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    Rigidbody rb;
    BoxCollider bx;
    bool disableRotation;
    public float destroyTime = 3f;
    AudioSource arrowAudio;
    public int damageAmount = 20;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        bx = GetComponent<BoxCollider>();
        arrowAudio = GetComponent<AudioSource>();

        Destroy(this.gameObject, destroyTime);
    }
    void Update()
    {
        if(!disableRotation)
            transform.rotation = Quaternion.LookRotation(rb.velocity);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag != "Player")
        {
            arrowAudio.Play();
            disableRotation = true;
            rb.isKinematic = true;
            bx.isTrigger = true;
        } 
    }

    private void OnTriggerEnter(Collider other)
    {
        // getHitSFX.Play();
        Destroy(transform.GetComponent<Rigidbody>());
        if(other.tag == "Enemy")
        {
            transform.parent = other.transform;
            other.GetComponent<Enemy>().TakeDamage(damageAmount);
        }
    }
}
