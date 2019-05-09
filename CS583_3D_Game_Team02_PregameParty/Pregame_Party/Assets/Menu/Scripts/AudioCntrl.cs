using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioCntrl : MonoBehaviour
{
    public AudioClip sfx;
    public AudioSource MyAudioSrc1;
    // Start is called before the first frame update
    void Start()
    {
        MyAudioSrc1.clip = sfx;
        MyAudioSrc1.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
