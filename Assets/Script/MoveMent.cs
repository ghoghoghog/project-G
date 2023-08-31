using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMent : MonoBehaviour
{
    public gravity gr;
    public float moveSpeed = 5f;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gr = GetComponent<gravity>();


    }

    private void Update()
    {
       int keyInput = Mathf.RoundToInt(Input.GetAxisRaw("Horizontal"));
        if (keyInput != 0)
        {
            GetComponent<SpriteRenderer>().flipX = keyInput == -1;
        }
        // 좌우 입력을 받습니다. (키보드의 좌우 화살표 또는 A/D 키)
        float horizontalInput = Input.GetAxisRaw("Horizontal");

        // 움직임을 적용합니다.
        rb.velocity = new Vector2(horizontalInput * moveSpeed, rb.velocity.y);

        if (gr.wjdtkdwndfur == false)
        {
            transform.rotation=Quaternion.Euler(180, 0, 0);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
