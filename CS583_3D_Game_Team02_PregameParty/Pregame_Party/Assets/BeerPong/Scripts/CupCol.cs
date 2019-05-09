using System.Collections;
using UnityEngine;

public class CupCol : MonoBehaviour
{
    public GameObject p3;
    public GameObject effectObject;
    public Player player;

    void Start()
    {
        effectObject.SetActive(false);
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            Player.cupCount += 1;
            gameObject.GetComponent<AudioSource>().Play();
            effectObject.SetActive(true);
            Destroy(p3.gameObject, 1f);
            Score.scoreValue -= 1;
            player.holdingPingPong = true;
        }
    }
}