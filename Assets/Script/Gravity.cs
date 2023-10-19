using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class gravity : MonoBehaviour
{
    
    private Rigidbody2D rb;
    float now_gravity = 2;
    public bool wjdtkdwndfur = true;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        wjdtkdwndfur = true;
    }
    bool isCh = false;
    void Update()
    {
        wjdtkdwndfur = dataController.wjdtkdwndfur;
        if (isCh)
        {
            rb.gravityScale = now_gravity * (wjdtkdwndfur ? 1 : -1);
        }
        else
        {
            if (wjdtkdwndfur)
            {
                rb.gravityScale = 2;
            }
            else
            {
                rb.gravityScale = -2;
            }

        }
    }

    public void gravity_to(float g)
    {
        isCh = true;
            now_gravity = g;
    }
    public void gravity_back()
    {
        isCh = false;
    }

    
}
