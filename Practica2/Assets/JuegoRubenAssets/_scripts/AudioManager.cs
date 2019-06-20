using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public AudioClip[] clips = new AudioClip[3];

    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    public void meteMas()
    {
        if (audioSource.isPlaying)
            audioSource.Stop();
        audioSource.PlayOneShot(clips[0]);
    }

    public void meteMenos()
    {
        if (audioSource.isPlaying)
            audioSource.Stop();
        audioSource.PlayOneShot(clips[1]);
    }

    public void hasGanado()
    {
        if (audioSource.isPlaying)
            audioSource.Stop();
        audioSource.PlayOneShot(clips[2]);
    }
}
