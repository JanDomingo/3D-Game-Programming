using System.Timers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketDespawn : MonoBehaviour
{
    public AudioSource MyAudioSrc1;
    public AudioClip effect1;
    private float addTime;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "fruit")
        {
            MyAudioSrc1.Play();
            Destroy(collision.gameObject, 30);
            addTime = GameObject.Find("CountdownTimer").GetComponent<CountdownTimer>().timer;
            addTime += 1.0f;
            GameObject.Find("CountdownTimer").GetComponent<CountdownTimer>().timer = addTime;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        MyAudioSrc1.clip = effect1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
