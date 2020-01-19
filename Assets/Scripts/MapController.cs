using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class MapController : MonoBehaviour
{
    public RectTransform mapa, pausa, settingsPanel;
    bool activateMap, activatePause, activePanel;
   
    void Start()
    {
        activateMap = false;
        activatePause = false;

        mapa.DOAnchorPos(new Vector2(-2000, 0), 0.25f);
        pausa.DOAnchorPos(new Vector2(0, 1500), 0.25f);
        settingsPanel.DOAnchorPos(new Vector2(0, -1500), 0.25f);

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
}
