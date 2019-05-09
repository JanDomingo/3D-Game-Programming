using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    CursorLockMode cursor;

    public GameObject pingPong;
    public GameObject playerCam;
    public float ballDistance = 2f;
    public float ballThrow = 5f;
    public bool holdingPingPong = true;
    public GameObject p3;
    public float timeReset = 2f;
    public int throwCount;
    public static int cupCount;

    public GameObject effectObject;

    // Start is called before the first frame update
    void Start()
    {
        pingPong.GetComponent<Rigidbody>().useGravity = false;
        effectObject.SetActive(false);
        throwCount = 0;
        cupCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (holdingPingPong)
        {
            pingPong.transform.position = playerCam.transform.position + playerCam.transform.forward * ballDistance;
            if (Input.GetMouseButtonDown(0))
            {
                throwCount += 1;
                holdingPingPong = false;
                pingPong.GetComponent<Rigidbody>().useGravity = true;
                pingPong.GetComponent<Rigidbody>().velocity = Vector3.zero;
                pingPong.GetComponent<Rigidbody>().AddForce(playerCam.transform.forward * ballThrow);
            }
        }

        if (holdingPingPong == false)
        {
            timeReset -= Time.deltaTime;
            if (timeReset <= 0)
            {
                pingPong.GetComponent<Rigidbody>().velocity = Vector3.zero;
                pingPong.GetComponent<Rigidbody>().useGravity = false;
                holdingPingPong = true;
                timeReset = 1.5f;
            }
        }

        if (throwCount - (cupCount) >= 4)
        {
            Cursor.lockState = cursor;
            Cursor.visible = true;
            cupCount = 0;
            throwCount = 0;
            SceneManager.LoadScene(6);

        }

        if (cupCount == 10)
        {
            Cursor.lockState = cursor;
            Cursor.visible = true;
            throwCount = 0;
            cupCount = 0;
            SceneManager.LoadScene(2);

        }

    }
}
