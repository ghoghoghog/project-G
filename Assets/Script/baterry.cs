using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baterry : MonoBehaviour
{
    public void Start()
    {
        gameObject.GetComponent<BoxCollider2D>().enabled = false;


    }
}
