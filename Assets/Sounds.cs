using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    public static Sounds instance;
    private void Awake()
    {
        instance = this;
    }
    public void PlayThisSound(string clipName)
    {
        AudioSource audioSource = this.gameObject.AddComponent<AudioSource>();
        audioSource.PlayOneShot((AudioClip)Resources.Load("Sounds/" + clipName, typeof (AudioClip)));
    }
}
