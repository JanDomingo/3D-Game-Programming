using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitGController : MonoBehaviour
{
    public GameObject fruit1;
    public GameObject fruit2;
    public GameObject fruit3;
    public GameObject fruit4;
    public GameObject hazard;

    public Vector3 spawnValues;

    private float upperbound = -15.3f;
    private float lowerbound = -17.1f;
    private float rightbound = 0f;
    private float leftbound = -2.73f;

    //[SerializeField] Text scoreText;

    public AudioClip Music;
    public AudioSource MyAudioSrc1;

    // Start is called before the first frame update

    void spawnFruit1()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(leftbound, rightbound), spawnValues.y, Random.Range(lowerbound, upperbound));
        Quaternion spawnRotation = new Quaternion();
        Instantiate(fruit1, spawnPosition, spawnRotation);
    }

    void spawnFruit2()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(leftbound, rightbound), spawnValues.y, Random.Range(lowerbound, upperbound));
        Quaternion spawnRotation = new Quaternion();
        Instantiate(fruit2, spawnPosition, spawnRotation);
    }

    void spawnFruit3()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(leftbound, rightbound), spawnValues.y, Random.Range(lowerbound, upperbound));
        Quaternion spawnRotation = new Quaternion();
        Instantiate(fruit3, spawnPosition, spawnRotation);
    }

    void spawnFruit4()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(leftbound, rightbound), spawnValues.y, Random.Range(lowerbound, upperbound));
        Quaternion spawnRotation = new Quaternion();
        Instantiate(fruit4, spawnPosition, spawnRotation);
    }

    void Start()
    {
        MyAudioSrc1.clip = Music;
        MyAudioSrc1.Play();
        InvokeRepeating("spawnFruit1", 0.5f, Random.Range(4.4f, 4.5f));
        InvokeRepeating("spawnFruit2", 0.9f, Random.Range(4.0f, 4.5f));
        InvokeRepeating("spawnFruit3", 3.2f, Random.Range(5.0f, 5.5f));
        InvokeRepeating("spawnFruit4", 4.4f, Random.Range(5.0f, 5.1f));
    }

    // Update is called once per frame
    void Update()
    {

    }

}
