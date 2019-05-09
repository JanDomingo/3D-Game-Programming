using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spaceship : MonoBehaviour
{

    public float movingSpeed = .2f;
    public float rotationSpeed = .1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(transform.right * movingSpeed);

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.RotateAround(Vector3.forward, rotationSpeed);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.RotateAround(Vector3.back, rotationSpeed);
        }

        //TODO: INSTEAD OF MOVING RIGHT, HAVE THE BACKGROUND MOVE FASTER
        /* 
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.root.position += Vector3.right * .18f;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.root.position += Vector3.left * .18f;
        } */
    }


}
