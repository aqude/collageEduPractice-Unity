using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIzombie : MonoBehaviour
{
    public GameObject player;
    public float speed;
    private float distance;
    public float distDetect;
    void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;
        if (distance < distDetect)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
        }

    }
}
