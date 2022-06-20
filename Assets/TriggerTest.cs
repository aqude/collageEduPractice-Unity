using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTest : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) {
        Debug.Log(collision.name);
    }
    private void OnTriggerStay2D(Collider2D collision) {
        Debug.Log("Стоит");
    }
    private void OnTriggerExit2D(Collider2D collision) {
        Debug.Log("Вышел");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
