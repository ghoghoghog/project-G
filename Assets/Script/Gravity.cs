using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class gravity : MonoBehaviour
{

    private Rigidbody2D rb;
    int now_gravity = 1;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            now_gravity *= -1;
            if (rb.gravityScale != 0)
            {
                rb.gravityScale = now_gravity;

            }
        }
    }

    public void gravity_to(float g)
    {
        rb.gravityScale = g;
    }
    public void gravity_back()
    {
        rb.gravityScale = now_gravity;
    }
}
