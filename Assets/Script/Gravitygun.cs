using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class Gravitygun : MonoBehaviour
{

    private Ray2D ray;
    private RaycastHit2D hit;
    [SerializeField] private float distance;

    private GameObject box = null;

    // Start is called before the first frame update
    private int isRight = -1;

    // Update is called once per frame
    void Update()
    {
        //Debug.DrawRay();
        transform.localPosition = new Vector2(0.3f * (transform.parent.GetComponent<SpriteRenderer>().flipX ? -1 : 1), 0);
        if (Input.GetKey(KeyCode.Q))
        {
            Debug.Log("Q");
            if (box == null)
            {
                ray.origin = transform.position;
                ray.direction = new Vector2(10 * (transform.parent.GetComponent<SpriteRenderer>().flipX ? -1 : 1), 0);
                hit = Physics2D.Raycast(ray.origin, ray.direction, distance, 1 << 8);
                Debug.Log(hit.collider);
                if (hit.collider != null)
                {
                    isRight = ray.direction.x > 0 ? -1 : 1;
                    box = hit.collider.gameObject;
                }
            }
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            if (box != null)
            {
                box.GetComponent<gravity>().gravity_back();

            }
            box = null;



            // 중력 = (처음 값)
        }
        if (box != null)
        {
            if (Vector2.Distance(box.transform.position, transform.position) > 4)
            {
                box.GetComponent<gravity>().gravity_back();
                box = null;
            }
        }

        if (box != null)
        {
            box.GetComponent<gravity>().gravity_to(0);

            if (transform.parent.GetComponent<SpriteRenderer>() != null)
            {
                box.GetComponent<Rigidbody2D>().MovePosition(new Vector2(transform.position.x - 2 * isRight, 0.15f + transform.position.y));
                // 중력 = 0
            }
        }
    }
}
