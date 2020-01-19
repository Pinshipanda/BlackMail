using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Hud : MonoBehaviour
{
    Gamemanager gamemanager;
    public Image img;

    void Start()
    {
        StartCoroutine(getManager());
    }

    IEnumerator getManager()
    {
        yield return new WaitForSeconds(1.0f);
        gamemanager = FindObjectOfType<Gamemanager>();
    }
}
