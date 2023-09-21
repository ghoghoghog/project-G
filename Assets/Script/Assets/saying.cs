using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
[Serializable]
public struct says
{
    public string person;
    public string say;
}
public class saying : MonoBehaviour
{
    
    [SerializeField]
    private List<says> s;

    [SerializeField]
    private GameObject say;
    // Start is called before the first frame update
    void Start()
    {
        say.GetComponent<haveSay>().Add(s);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
