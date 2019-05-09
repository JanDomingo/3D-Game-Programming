using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour
{
    [SerializeField] public Text uiText;
    [SerializeField] public float initalTime;

    public float timer;
    private bool canCount = true;
    private bool doOnce = true;

    Text time;

    // Start is called before the first frame update
    void Start()
    {
        timer = initalTime;
        time = GetComponent <Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0.0f && canCount)
        {
            timer -= Time.deltaTime;
            uiText.text = "Time: " + timer.ToString("F");
        }

        else if (timer <= 0.0f && !doOnce)
        {
            canCount = false;
            doOnce = true;
            uiText.text = "0.00";
            timer = 0.0f;
        }
        if (timer <= 0.0f)
        {
            SceneManager.LoadScene(6);
        }
    }
}
