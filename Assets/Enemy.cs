using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    public float speed;
    public Transform player;
    private Rigidbody2D rb;

    private Vector2 movement;

    void Start() { 
        rb = this.GetComponent<Rigidbody2D>();
    }
    private void Update() {
        Vector3 direction = player.position - transform.position;
        // float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        // rb.rotation = angle;
        direction.Normalize();
        movement = direction;
        // rb.rotation = angle; 
        if (health <= 0) {
            Destroy(gameObject);
        }
        //  transform.Translate(Vector2.left* speed * Time.deltaTime);
    }
    private void FixedUpdate() {
        moveCharacter(movement);
    }
    void moveCharacter(Vector2 direction){
        rb.MovePosition((Vector2)transform.position + (direction * speed * Time.deltaTime));
    }
    public void TakeDamage(int damage) {
        health -= damage;
    }
}
