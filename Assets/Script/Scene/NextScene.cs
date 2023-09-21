using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextScene : MonoBehaviour
{
    public GameObject This;
    public Animator anim;


    private void Awake()
    {
        This.SetActive(true);
    }
    void Start()
    {
        anim.SetBool("Close", false);
    }

}
