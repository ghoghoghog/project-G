using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMent : MonoBehaviour
{
    public gravity gr;
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    public Animator anim;

    int left = 0;
    int right = 0;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gr = GetComponent<gravity>();
        anim.SetBool("Idle", true);




    }

    private void Update()
    {

        //float horizontalInput = Input.GetAxisRaw("Horizontal");
        //int keyInput = Mathf.RoundToInt(horizontalInput);
        int keyInput = left + right;
        if (keyInput != 0)
        {
            GetComponent<SpriteRenderer>().flipX = keyInput == -1;
            anim.SetBool("Idle", false);
        }
        else
        {
            anim.SetBool("Idle", true);
        }
        
        // 좌우 입력을 받습니다. (키보드의 좌우 화살표 또는 A/D 키)

        // 움직임을 적용합니다.
        rb.velocity = new Vector2(keyInput * moveSpeed, rb.velocity.y);

        if (gr.wjdtkdwndfur == false)
        {
            transform.rotation=Quaternion.Euler(180, 0, 0);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }

    }

        public void leftPress()
        {
        left = -1;
        }

        public void rightPress()
    {
        right = 1;

    }

        public void leftUnPress()
    {
        left = 0;

    }

        public void rightUnPress()
    {
        right = 0;

    }
}
