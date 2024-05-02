using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio; 

public class MusicChange : MonoBehaviour
{
    public AudioMixerSnapshot baseSnapshot;
    public AudioMixerSnapshot actionSnapshot;
    public AudioMixerSnapshot caveSnapshot;

    public float slowTransitionTime = 2.0f;
    public float fastTransitionTime = 0.5f;

    private void OnTriggerEnter(Collider other)
    {
        switch (other.gameObject.tag)
        {
            case "Tension":
                actionSnapshot.TransitionTo(slowTransitionTime);
                break;

            case "Cave":
                caveSnapshot.TransitionTo(fastTransitionTime);
                break;

            default:
                break;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        switch (other.gameObject.tag)
        {
            case "Tension":
                baseSnapshot.TransitionTo(slowTransitionTime);
                break;

            case "Cave":
                baseSnapshot.TransitionTo(slowTransitionTime);
                break;

            default:
                break;
        }
    }
}
