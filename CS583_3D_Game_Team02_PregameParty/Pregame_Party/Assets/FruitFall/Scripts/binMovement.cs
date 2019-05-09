using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class binMovement : MonoBehaviour
{

    private float binSpeed = .02f;
    private float upperbound = -15.3f;
    private float lowerbound = -17.1f;
    private float rightbound = 0f;
    private float leftbound = -2.73f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) && transform.root.position.z < upperbound) 
        {
            transform.root.position += Vector3.forward * this.binSpeed;
        }

        if (Input.GetKey(KeyCode.DownArrow) && transform.root.position.z > lowerbound)
        {
            transform.root.position += Vector3.back * this.binSpeed;
        }

        if (Input.GetKey(KeyCode.LeftArrow) && transform.root.position.x > leftbound)
        { 
            transform.root.position += Vector3.left * this.binSpeed;
        }

        if (Input.GetKey(KeyCode.RightArrow) && transform.root.position.x < rightbound) 
        {
            transform.root.position += Vector3.right * this.binSpeed;
        }


    }
}
