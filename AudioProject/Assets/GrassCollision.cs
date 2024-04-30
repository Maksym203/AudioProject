using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassCollision : MonoBehaviour
{
    public AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    void Update()
    {
        //
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            source.Play();
        }
    }
}
