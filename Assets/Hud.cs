using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Hud : MonoBehaviour
{
    Gamemanager gamemanager;
    public Image img;
    float t=0;
    void Start()
    {
        StartCoroutine(getManager());
    }

    void Update()
    {
        if (gamemanager)
        {
            t=gamemanager.counter;
            t = MathCH.Remap(t, 0, 300, 0, 1);
            img.fillAmount = 1-t;
        }
    }
    IEnumerator getManager()
    {
        yield return new WaitForSeconds(1.0f);
        gamemanager = FindObjectOfType<Gamemanager>();
    }
}
