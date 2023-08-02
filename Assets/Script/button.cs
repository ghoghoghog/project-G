using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    public GameObject door; // 삭제할 오브젝트를 Inspector 창에서 지정합니다.

    private void Start()
    {
        door.SetActive(true);
    }

    // 오브젝트가 다른 오브젝트와 충돌하는 순간 호출됩니다.
    private void OnTriggerStay2D(Collider2D other)
    {
        door.SetActive(false);
        
       
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        door.SetActive(true);
    }
}
