using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingwalk : MonoBehaviour
{


    public float objectSpeed = 5f; // 오브젝트의 이동 속도

    private void OnCollisionStay2D(Collision2D collision)
    {
        
        
            // 충돌한 오브젝트의 transform을 왼쪽으로 이동시키기
            Vector3 leftDirection = Vector3.left;
            float moveSpeed = 5f; // 이동 속도 조절
            collision.transform.Translate(leftDirection * objectSpeed * Time.deltaTime);
        
    }

}
