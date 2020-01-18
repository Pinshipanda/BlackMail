using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System

public class CardsRewards : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> WhiteMailSoldList;
    private List<GameObject> BlackMailSoldList;

    Gamemanager gamemanager;

    private void Start()
    {
        WhiteMailSoldList = new List<GameObject>();
        BlackMailSoldList = new List<GameObject>();

        gamemanager = GameObject.Find("GameManager").GetComponent<Gamemanager>();
    }

    private void Update()
    {
        //var x = gamemanager.GetTotalWhiteMail();

        

        for(int i = 0; i < Whitemail; i++ )
        {

        }
    }
}
