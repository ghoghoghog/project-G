using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grab : MonoBehaviour
{
    private Rigidbody2D rb;
    GameObject gr = null;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {   
        transform.localPosition = new Vector2(Mathf.Abs(transform.localPosition.x) * (transform.parent.GetComponent<SpriteRenderer>().flipX ? -1 : 1), transform.localPosition.y);
        if (gr != null)
        {
            //Debug.DrawRay();
            gr.transform.position = transform.position;
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("back");
                gr.GetComponent<gravity>().gravity_back();
                gr.AddComponent<BoxCollider2D>();
                gr.GetComponent<Rigidbody2D>().velocity= Vector3.zero;
                gr = null;
            }
        }
        else
        {
            if (touch != null)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    gr = touch;
                    gr.GetComponent<gravity>().gravity_to(0);
                    Destroy(gr.GetComponent<BoxCollider2D>());
                }

            }
            
        }
    }
    GameObject touch = null;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("item") || collision.CompareTag("box"))
        {
            touch = collision.gameObject;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        touch = null;
    }
}
