using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dataController : MonoBehaviour
{
    public static bool wjdtkdwndfur = true;
    public void ChangeGravity()
    {
        wjdtkdwndfur = !wjdtkdwndfur;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeGravity();
        }
    }
}
