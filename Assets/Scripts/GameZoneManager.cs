using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameZoneManager : MonoBehaviour
{

    GameObject[] objs, mailBox;
    Gamemanager gamemanager;

    public Button exit;

    public float distance= 2;
    public int ilegalMail = 0, legalMail = 0, NumberOfLegalMailToDeliver = 0, NumberOfILegalMailToDeliver = 0;
    List<GameObject> activeMailBox = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        


        gamemanager = GameObject.FindGameObjectWithTag("Gamemanager").GetComponent<Gamemanager>();
        objs = GameObject.FindGameObjectsWithTag("Obstaculos");
        //GetInactiveInRadius();
        mailBox = GameObject.FindGameObjectsWithTag("MailBox");

        GetInactiveInRadius(5 * gamemanager.GetDay());
        for (int i = 0; i < mailBox.Length; i++)
        {
            if (mailBox[i].GetComponent<MailBox>().IsInArea)
            {
                activeMailBox.Add(mailBox[i]);                
            }
        }

        Debug.Log("Buzones activos: " + activeMailBox.Count);

        for(int i = 0; i < activeMailBox.Count; i++)
        {
            if (activeMailBox[i].GetComponent<MailBox>().IsWhiteMail)
            {
                Debug.Log("Es Buzon Blanco");
                legalMail++;
            }
            else
            {
                Debug.Log("Es Buzon Negro");
                ilegalMail++;
            }
        }

        if(gamemanager.GetDay() >= 3)
        {
            if(ilegalMail > 0)
                NumberOfILegalMailToDeliver = gamemanager.GetTotalBlackMail() / ilegalMail;
        }       
        
        NumberOfLegalMailToDeliver = gamemanager.GetTotalWhiteMail()/ legalMail;
        //Debug.Log(NumberOfLegalMailToDeliver + " " + gamemanager.GetTotalWhiteMail() + " " + legalMail);

        for (int i = 0; i < activeMailBox.Count; i++)
        {
            if (activeMailBox[i].GetComponent<MailBox>().IsWhiteMail)
            {
                activeMailBox[i].GetComponent<MailBox>().HowManyMails = NumberOfLegalMailToDeliver;
            }
            else
            {
                activeMailBox[i].GetComponent<MailBox>().HowManyMails = NumberOfLegalMailToDeliver;
            }
        }

        exit.onClick.AddListener(GameObject.FindGameObjectWithTag("Gamemanager").GetComponent<Gamemanager>().FinishLevel);
    }

    // Update is called once per frame
    void Update()
    {
        GetInactiveInRadius(distance);
    }

    public void GetInactiveInRadius(float _radius)
    {
        foreach (GameObject obj in objs)
        {
            if (Vector3.Distance(transform.position, obj.transform.position) < _radius)
            {
                obj.SetActive(false);

            }
                
        }

        foreach (GameObject mail in mailBox)
        {
            if (Vector3.Distance(transform.position, mail.transform.position) < _radius)
            {
                mail.GetComponent<MailBox>().IsInArea = true;

            }

        }
    }
}
