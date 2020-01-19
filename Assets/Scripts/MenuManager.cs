using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public GameObject menuCanvas, sliderCanvas;
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
