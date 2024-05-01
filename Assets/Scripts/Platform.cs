using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
   public float speed = 5f;
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(horizontalInput * speed * Time.deltaTime * Vector3.right);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -9, 8), transform.position.y, transform.position.z);
    }
}
