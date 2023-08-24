using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonONOFF : MonoBehaviour
{
    public GameObject door; // 삭제할 오브젝트를 Inspector 창에서 지정합니다.
    public int on =1;

    private void Start()
    {
        door.SetActive(true);
        on = 1;

    }

    // 오브젝트가 다른 오브젝트와 충돌하는 순간 호출됩니다.
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (on == 1)
        {
         door.SetActive(false);
            Debug.Log("open");
            on = 0;
        }
        if ( on == 0)
        {
            door.SetActive(true);
            Debug.Log("close");
            on = 1;
        }

    }
}
