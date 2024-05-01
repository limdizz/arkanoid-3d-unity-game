using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallControl : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        LaunchBall();
    }

    void LaunchBall()
    {
        Vector3 launchDirection = new Vector3(Random.Range(-2f, 4f), 0, Random.Range(-0f, 4f)).normalized;
        rb.velocity = launchDirection * speed;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Border"))
        {
            Vector3 reflectDir = Vector3.Reflect(rb.velocity, collision.contacts[0].normal).normalized;
            rb.velocity = speed * reflectDir;
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            Vector3 reflectDir = Vector3.Reflect(rb.velocity, collision.contacts[0].normal).normalized;
            rb.velocity = speed * reflectDir;
        }
        if (collision.gameObject.CompareTag("Block"))
        {
            Vector3 reflectDir = Vector3.Reflect(rb.velocity, collision.contacts[0].normal).normalized;
            rb.velocity = speed * reflectDir;
            Destroy(collision.gameObject, 0.5f);
        }

        // Loading Lose Menu 1
        if (collision.gameObject.CompareTag("Lose") && (SceneManager.GetActiveScene().buildIndex == 1))
        {
            SceneManager.LoadScene(2);

        }
        // Loading Lose Menu 2
        if (collision.gameObject.CompareTag("Lose") && (SceneManager.GetActiveScene().buildIndex == 4))
        {
            SceneManager.LoadScene(6);

        }

        // Loading Win Menu 1
        if (GameObject.FindGameObjectsWithTag("Block").Length == 0 && (SceneManager.GetActiveScene().buildIndex == 1))
        {
            SceneManager.LoadScene(7);
        }
        // Loading Win Menu 2
        if (GameObject.FindGameObjectsWithTag("Block").Length == 0 && (SceneManager.GetActiveScene().buildIndex == 4))
        {
            SceneManager.LoadScene(3);
        }
    }
}