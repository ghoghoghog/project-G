using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public Animator anim;
    void Start()
    {
        anim.SetBool("Close", false); 
    }
    public void Scenechange()
    {
        anim.SetBool("Close", true);
        Invoke("Gamestart" , 3f);
        
    }
    void Gamestart()
    {
        Debug.Log("111111111111");
         SceneManager.LoadScene("Stage");
    }
}
