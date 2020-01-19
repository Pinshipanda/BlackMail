using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FP_Semaforo : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject colorAmarillo, colorRojo, colorVerde;
    public Color cverde, crojo, camarillo;
    public bool amarillo, verde, rojo;
    FP_NPCpatrol npc;
    public float tiempo = 15f;
    void Start()
    {

        colorAmarillo.GetComponent<Renderer>().material.SetFloat("_IsBlue", 0);
        colorVerde.GetComponent<Renderer>().material.SetFloat("_IsGree", 0);
        colorRojo.GetComponent<Renderer>().material.SetFloat("_IsRed", 0);
        verde = true;
        rojo = false;
        amarillo = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (verde)
        {
            colorVerde.GetComponent<Renderer>().material.SetFloat("_IsGree", 1);
            colorAmarillo.GetComponent<Renderer>().material.SetFloat("_IsBlue", 0);
            colorRojo.GetComponent<Renderer>().material.SetFloat("_IsRed", 0);
            //colorRojo.color = Color.gray;
            //colorAmarillo.color = Color.gray;
            StartCoroutine(EsperarV(tiempo));
            //Debug.Log("verde" +colorAmarillo.color);



        }

        else if (amarillo)
        {
            colorAmarillo.GetComponent<Renderer>().material.SetFloat("_IsBlue", 1);
            colorAmarillo.GetComponent<Renderer>().material.SetFloat("_IsGlue", 0);
            colorRojo.GetComponent<Renderer>().material.SetFloat("_IsRed", 0);
            //colorRojo.color = Color.gray;
            //colorAmarillo.color = Color.gray;
            StartCoroutine(EsperarA(tiempo));
           // Debug.Log("Ama " +colorVerde.color);




        }

        else if (rojo)
        {
            colorRojo.GetComponent<Renderer>().material.SetFloat("_IsRed", 1);
            colorAmarillo.GetComponent<Renderer>().material.SetFloat("_IsBlue", 0);
            colorVerde.GetComponent<Renderer>().material.SetFloat("_IsGree", 0);
            //colorRojo.color = Color.gray;
            //colorAmarillo.color = Color.gray;
            StartCoroutine(EsperarR(tiempo));

           //    Debug.Log("Red "+colorRojo.color);


        }
        else
        {
            colorVerde.GetComponent<Renderer>().material.SetFloat("_IsGree", 0);
            colorAmarillo.GetComponent<Renderer>().material.SetFloat("_IsBlue", 0);
            colorRojo.GetComponent<Renderer>().material.SetFloat("_IsRed", 0);
        }
    }

    IEnumerator EsperarV(float _tiempo)
    {
        
        yield return new WaitForSeconds(tiempo);
        colorVerde.GetComponent<Renderer>().material.SetFloat("_IsGree", 0);
        verde = false;
        amarillo = true;


    }
    IEnumerator EsperarR(float tiempo)
    {
        
        yield return new WaitForSeconds(tiempo);
        colorRojo.GetComponent<Renderer>().material.SetFloat("_IsRed", 0);
        rojo = false;
        verde = true;
    }
    IEnumerator EsperarA(float tiempo)
    {
        yield return new WaitForSeconds(tiempo);
        amarillo = false;
        
        rojo = true;
        
    }
   

    
    private void OnTriggerEnter(Collider hit)
    {
        if (rojo)
        {
            if (hit.gameObject.tag == "Carro")
            {
                hit.gameObject.GetComponent<NavMeshAgent>().enabled = false;
                hit.gameObject.GetComponent<FP_NPCpatrol>().enabled = false;

                Debug.Log("yay");
             

            }
        }

    }
    private void OnTriggerStay(Collider other)
    {
        if (verde)
        {
            if (other.gameObject.tag == "Carro")
            {
                other.gameObject.GetComponent<FP_NPCpatrol>().enabled = true;
                other.gameObject.GetComponent<NavMeshAgent>().enabled = true;
                Debug.Log("Puchamonooonnn");
            }
        }
            
       
        
    }


}
