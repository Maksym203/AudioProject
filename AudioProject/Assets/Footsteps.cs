using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    public AudioClip[] footstepsOnGrass;
    public AudioClip[] footstepsOnWood;
    public AudioClip[] footstepsOnWater;

    public string material;

    void PlayFootstepSound()
    {
        AudioSource myAudioSource = GetComponent<AudioSource>();
        myAudioSource.volume = Random.Range(0.9f, 1.0f);
        myAudioSource.pitch = Random.Range(0.8f, 1.2f);

        switch (material)
        {
            case "Grass":
                myAudioSource.PlayOneShot(footstepsOnGrass[Random.Range(0, footstepsOnGrass.Length)]);
                break;

            case "Wood":
                myAudioSource.PlayOneShot(footstepsOnWood[Random.Range(0, footstepsOnWood.Length)]);
                break;
            case "Water":
                myAudioSource.PlayOneShot(footstepsOnWater[Random.Range(0, footstepsOnWood.Length)]);
                break; 
            default:
                break;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Grass":
                break; 
            case "Wood":
                material = collision.gameObject.tag;
                break;
            case "Water":
                break; 
            default:
                break;
        }
    }
}
