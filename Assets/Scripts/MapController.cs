using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class MapController : MonoBehaviour
{
    public RectTransform mapa, pausa, settingsPanel;
    bool activateMap, activatePause, activePanel;
    public GameObject camaraMap;

    public float Xmove = 2 , Zmove = 2, ZoomSpeed = 2;
    public float speed = 3, speedZoom = 2;


    void Start()
    {
        activateMap = false;
        activatePause = false;


        mapa.DOAnchorPos(new Vector2(-2000, 0), 0.25f);
        pausa.DOAnchorPos(new Vector2(0, 1500), 0.25f);
        settingsPanel.DOAnchorPos(new Vector2(0, -1500), 0.25f);

        camaraMap.GetComponent<Camera>().fieldOfView = 80f;

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.M) && !activatePause)
        {
            if(!activateMap)
            {
               
                mapa.DOAnchorPos(Vector2.zero, 0.25f);
                activateMap = true;
            }
            else
            {
                
                mapa.DOAnchorPos(new Vector2(-2000, 0), 0.25f);
                activateMap = false;

            }
        }

        if(Input.GetKeyDown(KeyCode.Escape) && !activateMap && !activePanel  )
        {
            if(!activatePause)
            {
                pausa.DOAnchorPos(new Vector2(0, 0), 0.25f);
                activatePause = true;
            }
            else
            {
                pausa.DOAnchorPos(new Vector2(0, 1500), 0.25f);
                activatePause = false;
            }

        }

        CameraMovement();
        
    }


    public void reanudarBTN()
    {
        if (activatePause)
        {
            pausa.DOAnchorPos(new Vector2(0, 1500), 0.25f);
            activatePause = false;
        }

    }

    public void SettingsPanel()
    {
        if(activatePause && !activePanel)
        {
            pausa.DOAnchorPos(new Vector2(0, 1500), 0.25f);
            settingsPanel.DOAnchorPos(new Vector2(0, 0), 0.25f).SetDelay(0.25f);
            activePanel = true;

        }
    }

    public void getBackPauseMenu()
    {
        if (activatePause && activePanel)
        {
            settingsPanel.DOAnchorPos(new Vector2(0, -1500), 0.25f);
            pausa.DOAnchorPos(new Vector2(0, 0), 0.25f).SetDelay(0.25f);

            activePanel = false;

        }
    }

    public void exitGame()
    {
        SceneManager.LoadScene(0);
    }

    public void CameraMovement()
    {
        if(activateMap)
        {
            if(Input.GetKey(KeyCode.L) && camaraMap.transform.position.x <= 70f)
            {
                camaraMap.transform.position = camaraMap.transform.position + new Vector3(Xmove * speed * Time.deltaTime, 0, 0);
            }

            if(Input.GetKey(KeyCode.J) && camaraMap.transform.position.x >= -60f)
            {
                camaraMap.transform.position = camaraMap.transform.position + new Vector3( - Xmove * speed * Time.deltaTime, 0, 0);

            }

            if (Input.GetKey(KeyCode.I) && camaraMap.transform.position.z <= 100f)
            {
                camaraMap.transform.position = camaraMap.transform.position + new Vector3(0, 0, Zmove * speed * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.K) && camaraMap.transform.position.z >= -55f)
            {
                camaraMap.transform.position = camaraMap.transform.position + new Vector3(0, 0, -Zmove * speed * Time.deltaTime);

            }

            if(Input.GetKey(KeyCode.E) && camaraMap.GetComponent<Camera>().fieldOfView >= 30)
            {
                camaraMap.GetComponent<Camera>().fieldOfView -= ZoomSpeed * speedZoom;

            }

            if (Input.GetKey(KeyCode.Q) && camaraMap.GetComponent<Camera>().fieldOfView <= 90 )
            {
                camaraMap.GetComponent<Camera>().fieldOfView += ZoomSpeed * speedZoom;

            }
        }
    }
}
