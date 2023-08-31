using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sw : MonoBehaviour
{
    [SerializeField]
    private GameObject door;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
             door.SetActive(!door.activeSelf);
    }
}
