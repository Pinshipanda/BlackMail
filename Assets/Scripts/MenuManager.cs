using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public GameObject menuCanvas, sliderCanvas;
    public Transform target;

    public float smoothTime = 0.3F;
    private Vector3 velocity = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        menuCanvas.SetActive(true);
        sliderCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void gotoSlider()
    {
        menuCanvas.SetActive(false);
        sliderCanvas.SetActive(true);

     

    }

    public void exitGame()
    {
        Application.Quit();
    }
}
