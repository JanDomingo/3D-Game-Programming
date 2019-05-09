using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthText : MonoBehaviour
{
    public static int healthValue = 100;
    Text health;

    // Start is called before the first frame update
    void Start()
    {
        healthValue = 100;
        health = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        health.text = "Health: " + healthValue;
    }
}
