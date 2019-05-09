using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform firePoint;
    public GameObject enemyLaser;

    private Animator explodeAnimation;
    private AudioSource explosionSound;

    private int health = 100;
    public float speed = 4f;
    public float outOfBounds = -10f;

   

    private void Awake()
    {
        explodeAnimation = GetComponent<Animator>();
        explosionSound = GetComponent<AudioSource>();
    }

    private void Start()
    {
        Invoke("StartShooting", Random.Range(1f, 3f));
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        Vector3 move = transform.position;
        move.x -= speed * Time.deltaTime;
        transform.position = move;

        if (move.x < outOfBounds)
            gameObject.SetActive(false);
    }

    void StartShooting()
    {
        GameObject beam = Instantiate(enemyLaser, firePoint.position, Quaternion.identity);
        beam.GetComponent<Beam>().isEnemyLaser = true;

        Invoke("StartShooting", Random.Range(1f, 3f));
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlayerBeam")
        {
            health -= 20;
        } else if (collision.gameObject.tag == "BigBeam")
        {
            health -= 50;
        }

            if (health <= 0)
        {
            CancelInvoke("StartShooting");
            gameObject.SetActive(false);
            ScoreScript.scoreValue += 1;
            Debug.Log("destroyed!");
        }
    }
}






    /*
    public int health = 100;

    public GameObject deathEffect;

    public void TakeDamage (int damage)
    {
        health -= damage;
       
        if (health <= 0) 
        {
            Die();
        }
    }

    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }*/

