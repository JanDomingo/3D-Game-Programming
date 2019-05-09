using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beam : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 40;
    public Rigidbody2D rb;

    public bool isEnemyLaser = false;

    // Start is called before the first frame update
    void Start()
    {
        if (isEnemyLaser == false)
        {
            rb.velocity = transform.right * speed;
        } else
        {
            speed *= -1f;   //If it is an enemy bullet, it shoots towards the left
            rb.velocity = transform.right * speed;  
        }
        Invoke("DeactivateGameObject", 1.7f); //Delete bullet after 2 seconds

    }

    void DeactivateGameObject()
    {
        gameObject.SetActive(false);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isEnemyLaser == false)
        {
            if (collision.gameObject.tag == "Enemy")
            {
                gameObject.SetActive(false);

                //TODO: Figure out how to get enemy health
                //EnemyHealth enemyHealth = GetComponent<EnemyHealth>();
                //enemyHealth.TakeDamage(damage);
            }
        } else
        {
            if (collision.gameObject.tag == "bullet")
            {
                gameObject.SetActive(false);
            }
        }
    }
    }
    /*
    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        Destroy(gameObject);
    }*/

