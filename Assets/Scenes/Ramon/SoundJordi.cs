using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundJordi : MonoBehaviour
{
    private AudioSource audioSource;
    [SerializeField] private AudioClip sound1;
    [SerializeField] private AudioClip sound2;
    [SerializeField] private AudioClip sound3;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlaySound1()
    {
        audioSource.PlayOneShot(sound1);
    }
    public void PlaySound2()
    {
        audioSource.PlayOneShot(sound2);
    }
    public void PlaySound3()
    {
        audioSource.PlayOneShot(sound3);
    }
}
