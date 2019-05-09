using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    //TODO: FIGURE OUT HOW TO PLAY ANIMATION BACK TO CENTER WHEN KEY IS RELEASED

    public Animator animator;

    public Transform FirePoint;

    private float upperbound = 4.674f;
    private float lowerbound = -4.64f;
    private float leftbound = -8.292f;
    private float rightbound = -5.0f;
    public int playerHealth = 100;

    public bool endGame;

    // Start is called before the first frame update
    void Start()
    {
        playerHealth = 100;
        ScoreScript.scoreValue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) && transform.root.position.y < upperbound)
        {
            //animator.Play("Player_Center"); //THIS DOESNT WORK BECAUSE IT CONSTANTLY LOOPS BETWEEN LEFT BANK AND CENTER
            animator.Play("Player_BankLeft");
            transform.root.position += Vector3.up * .11f;
        }


        if (Input.GetKey(KeyCode.DownArrow) && transform.root.position.y > lowerbound)
        {
            //animator.Play("Player_Center");
            animator.Play("Player_BankRight");
            transform.root.position += Vector3.down * .11f;
        }

        if (Input.GetKey(KeyCode.RightArrow) && transform.root.position.x < rightbound)
        {
            transform.root.position += Vector3.right * .13f;
        }

        if (Input.GetKey(KeyCode.LeftArrow) && transform.root.position.x > leftbound)
        {
            transform.root.position += Vector3.left * .13f;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            playerHealth -= 10;
            PlayerHealthText.healthValue -= 10;
        }

        if (playerHealth <= 0)
        {
            gameObject.SetActive(false);
            SceneManager.LoadScene("GameOver");
        }
    }
}

