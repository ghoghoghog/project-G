using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class haveSay : MonoBehaviour
{
    private Queue<says> HaveS = new Queue<says>();
    [SerializeField]
    private Text person;
    [SerializeField]
    private Text say;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame  
    void Update()
    {
        Debug.Log($"1 {HaveS.Count}");
        if (Input.GetMouseButtonDown(0) && gameObject.activeSelf)
        {      
            if (HaveS.Count > 0)
            {
                says i = HaveS.Dequeue();
                Debug.Log(i.person);
                Debug.Log(i.say);
                person.text = i.person;
                say.text = i.say;
            }
            else
            {
               // gameObject.SetActive(false);
            }
        }
        Debug.Log($"2 {HaveS.Count}");
    }

    public void Add (List<says> s)
    {
        for (int i = 0; i < s.Count; i++)
        {
            HaveS.Enqueue(s[i]);
        }
        Debug.Log(HaveS.Count);
        gameObject.SetActive(true);
        Debug.Log(HaveS.Count);
    }
}
