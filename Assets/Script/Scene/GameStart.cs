using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameStart : MonoBehaviour
{
   public Image image;
    public Button button;
    float time = 0;
    float F_time = 1;
    public void Fade()
    {
        StartCoroutine(FadeFlow());
    }
    IEnumerator FadeFlow()
    {
        button.gameObject.SetActive(false);
        image.gameObject.SetActive(true);
        Color alpha = image.color;
        while (alpha.a <1)
        {
            time += Time.deltaTime / F_time;
            alpha.a = Mathf.SmoothStep(0,1, time);
            image.color = alpha;
            yield return null;
        }
        time = 0;

        yield return new WaitForSeconds(1);
        while (alpha.a > 0)
        {
            time += Time.deltaTime / F_time;
            alpha.a = Mathf.SmoothStep(1, 0, time);
            image.color = alpha;
            yield return null;
        }
        image.gameObject.SetActive(false);
        yield return null;
    }
       
   
  
}
