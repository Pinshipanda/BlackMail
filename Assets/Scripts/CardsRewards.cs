using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CardsRewards : MonoBehaviour
{

    /*Rango1: Segunda Bolsa aumenta cartas
     * rango2 : 3er bolsa & bicicleta
     * rango3: Motoneta
     * rango4 Auto
    */
    Gamemanager gameManager;
    GameObject[] upGranded;
    public int upgrade = 0;

    public int bikeSpeed = 5;
    public int motorBikeSpeed = 10;
    public int CarSpeed = 20;


    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<Gamemanager>();
    }
    //Mejoras de Velocidad
    void BikeUpgrade()
    {
        
        gameManager.playerSpeed = bikeSpeed;
    }
    void motorBikeUpgrade()
    {
        gameManager.playerSpeed = motorBikeSpeed;      
    }
    void CarUpgrade()
    {
        gameManager.playerSpeed = CarSpeed;
    }

    //Mejoras de Capacidad
}
