using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerDead : MonoBehaviour
{
    private bool hasEntered;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Enemy") && !hasEntered)
        {
            Destroy(gameObject);
            SceneManager.LoadScene(0);
        }
    }
}
