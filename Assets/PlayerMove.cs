using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    // void Start()
    // {
    //     
    // }
    // Анимации
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Animator animator;
    // Update is called once per frame
    // Хранение позиции
    private Vector2 movement;

    // Стрельба
    public Transform shotPoint;
    public GameObject bullet;
    private float timeBtwShots;
    public float StartTimeBtwShots;
    void Update()
    {
        // Дает нам информацию о движениях
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

        // Стрельба
        if (timeBtwShots <= 0) {
            if (Input.GetMouseButton(0)) {
                Instantiate(bullet, shotPoint.position, transform.rotation);
                timeBtwShots = StartTimeBtwShots;
            }
        }
        else {
            timeBtwShots -= Time.deltaTime;
        }
        
            
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement.normalized * moveSpeed * Time.fixedDeltaTime); 
    }
}
