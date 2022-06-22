using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float timeBtwAttack;
    public float startTimeBtwAttack;

    public int health;
    public float speed = 5f;
    private Rigidbody2D rb;
    private Vector2 movement;
    public GameObject deathEffect;

    public int damage;
    private float stopTime;
    public float startStopTime;
    public float normalSpeed;
    private PlayerMove player;
    private Animation anim;
    void Start() { 
        rb = this.GetComponent<Rigidbody2D>();
        anim = GetComponent<Animation>();
        player = FindObjectOfType<PlayerMove>();
        normalSpeed = speed;
    }
    private void Update() {
        if (stopTime <= 0) {
            speed = normalSpeed;
        } else {
            speed = 0;
            stopTime -= Time.deltaTime;
        }
        // rb.rotation = angle; 
        if (health <= 0) {
            Instantiate(deathEffect,transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        //  transform.Translate(Vector2.left* speed * Time.deltaTime);
    }
    public void TakeDamage(int damage) {
        stopTime = startStopTime;
        Instantiate(deathEffect,transform.position, Quaternion.identity);
        health -= damage;
    }

    public void OnEnemyAttack() {
        Instantiate(deathEffect,player.position, Quaternion.identity);
        player.health -= damage;
    }
}
