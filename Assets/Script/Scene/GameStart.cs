using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class GameStart : MonoBehaviour
{
   public GameObject image;
   public GameObject Button;
   
   public void NextScene()
   {
      Button.SetActive(false);
      Fadechange();
      
      SceneManager.LoadScene("Stage");
   }

    IEnumerator Fadechange()
   {
      float fadecount = 0;
      while (fadecount<1)
      {
         fadecount += 0.1f;
         yield return new WaitForSeconds(0.1f);
      }
   }
}
