using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float timeBtwAttack;
    public float startTimeBtwAttack;

    public int health;
    public GameObject deathEffect;

    public int damage;
    public float normalSpeed;
    private PlayerMove player;
    void Start() { 
    }
    private void Update() {
        if (health <= 0) {
            Instantiate(deathEffect,transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
    public void TakeDamage(int damage) {
        Instantiate(deathEffect,transform.position, Quaternion.identity);
        health -= damage;
    }
}
