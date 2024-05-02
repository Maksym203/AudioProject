using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    public AudioClip[] footstepsOnGrass;
    public AudioClip[] footstepsOnWood;
    public AudioClip[] footstepsOnWater;
    public AudioClip[] footstepsOnGround; 

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
                myAudioSource.PlayOneShot(footstepsOnWater[Random.Range(0, footstepsOnWater.Length)]);
                break;
            case "Ground":
                myAudioSource.PlayOneShot(footstepsOnGround[Random.Range(0, footstepsOnGround.Length)]);
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
                material = collision.gameObject.tag; 
                break; 
            case "Wood":
                material = collision.gameObject.tag;
                break;
            case "Water":
                material = collision.gameObject.tag; 
                break;
            case "Ground":
                material = collision.gameObject.tag;
                break; 
            default:
                break;
        }
    }
}
