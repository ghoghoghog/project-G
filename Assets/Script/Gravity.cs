using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input .GetKeyDown (KeyCode.Space))
        {
            rb.gravityScale *= -1;
        }
    }
}
