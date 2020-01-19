using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clipsDeAudio : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] clips;

    public static clipsDeAudio instancia;
    void start() 
    {
        if(instancia == null) 
        {
            instancia = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void PlayClips(int _cpindex) 
    {
        audioSource.PlayOneShot(clips[_cpindex]);
    }
}
