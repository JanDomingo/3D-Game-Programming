using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Player player;
    public float timeReset = 5f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.holdingPingPong == false)
        {
            timeReset -= Time.deltaTime;
            if (timeReset <= 0)
            {
                player.pingPong.transform.position = player.playerCam.transform.position + player.playerCam.transform.forward* player.ballDistance;
                if (Input.GetMouseButtonDown(0))
                {
                    player.holdingPingPong = false;
                    player.pingPong.GetComponent<Rigidbody>().useGravity = true;
                    player.pingPong.GetComponent<Rigidbody>().AddForce(player.playerCam.transform.forward* player.ballThrow);
                }
            }       
        }
    }
}
