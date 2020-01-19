using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class GameZoneManager : MonoBehaviour
{

    public GameObject[] objs, mailBox;
    Gamemanager gamemanager;

    public MailManager mailManager;
    public Button exit;

    public float distance = 2;
    public int ilegalMail = 1, legalMail = 1, NumberOfLegalMailToDeliver = 0, NumberOfILegalMailToDeliver = 0, auxTotalOfMailsWhite, auxTotalOfMailsBlack;
    List<GameObject> activeMailBox = new List<GameObject>();
    public List<GameObject> activeMailBoxWithPossibleDelivers = new List<GameObject>();

    public List<GameObject> activeMailBoxWhite = new List<GameObject>();

    public List<GameObject> activeMailBoxBlack = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        //mailManager = GameObject.FindGameObjectWithTag("Player").GetComponent<MailManager>();


        gamemanager = GameObject.FindGameObjectWithTag("Gamemanager").GetComponent<Gamemanager>();
        objs = GameObject.FindGameObjectsWithTag("Obstaculos");
        //GetInactiveInRadius();
        mailBox = GameObject.FindGameObjectsWithTag("MailBox");

        GetInactiveInRadius(45 * gamemanager.GetDay());
        for (int i = 0; i < mailBox.Length; i++)
        {
            if (mailBox[i].GetComponent<MailBox>().IsInArea)
            {
                activeMailBox.Add(mailBox[i]);
            }
        }

        Debug.Log("Buzones activos: " + activeMailBox.Count);

        for (int i = 0; i < activeMailBox.Count; i++)
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

        if (gamemanager.GetDay() >= 3)
        {
            if (ilegalMail > 0)
            {
                NumberOfILegalMailToDeliver = gamemanager.GetTotalBlackMail() / ilegalMail;
                auxTotalOfMailsBlack = gamemanager.GetTotalBlackMail();
            }

        }

        NumberOfLegalMailToDeliver = gamemanager.GetTotalWhiteMail() / legalMail;
        auxTotalOfMailsWhite = gamemanager.GetTotalWhiteMail();
        //Debug.Log(NumberOfLegalMailToDeliver + " " + gamemanager.GetTotalWhiteMail() + " " + legalMail);

        for (int i = 0; i < activeMailBox.Count; i++)
        {
            if (activeMailBox[i].GetComponent<MailBox>().IsWhiteMail)
            {

                if (auxTotalOfMailsWhite > 0)
                {
                    activeMailBox[i].GetComponent<MailBox>().HowManyMails = NumberOfLegalMailToDeliver;
                    activeMailBox[i].GetComponent<MailBox>().SetBool();



                }
                else
                {
                    activeMailBox[i].GetComponent<MailBox>().HowManyMails = 0;
                }
                auxTotalOfMailsWhite -= NumberOfLegalMailToDeliver;
            }
            else
            {

                if (auxTotalOfMailsBlack > 0)
                {
                    activeMailBox[i].GetComponent<MailBox>().HowManyMails = NumberOfILegalMailToDeliver;
                    activeMailBox[i].GetComponent<MailBox>().SetBool();


                }
                else
                {
                    activeMailBox[i].GetComponent<MailBox>().HowManyMails = 0;
                }
                auxTotalOfMailsBlack -= auxTotalOfMailsBlack;
            }

        }

        //activeMailBoxWithPossibleDelivers = GameObject.FindGameObjectsWithTag("MailBox").
        Debug.Log(activeMailBox.Count);
        for (int i = 0; i < activeMailBox.Count; i++)
        {
            Debug.Log(activeMailBox[i].GetComponent<MailBox>().HaveMail);
            if (activeMailBox[i].GetComponent<MailBox>().GetBool())
            {
                if (activeMailBox[i].GetComponent<MailBox>().IsWhiteMail)
                {
                    activeMailBoxWhite.Add(activeMailBox[i]);
                }
                else
                {
                    activeMailBoxBlack.Add(activeMailBox[i]);
                }

                activeMailBoxWithPossibleDelivers.Add(activeMailBox[i]);
            }


        }


        for (int i = 0; i < activeMailBoxBlack.Count; i++)
        {
            Letter letter = new Letter(1, activeMailBoxBlack[Random.Range(0, activeMailBoxBlack.Count)]);
            EditorUtility.SetDirty(letter);
            mailManager.AddLetter(letter);

        }

        for (int i = 0; i < activeMailBoxWhite.Count; i++)
        {
            Letter letter = new Letter(0, activeMailBoxWhite[Random.Range(0, activeMailBoxWhite.Count)]);
            //EditorUtility.SetDirty(letter);

            mailManager.AddLetter(letter);
        }

        //exit.onClick.AddListener(GameObject.FindGameObjectWithTag("Gamemanager").GetComponent<Gamemanager>().FinishLevel);
    }

    // Update is called once per frame
    void Update()
    {
        //GetInactiveInRadius(distance);
    }

    public void GetInactiveInRadius(float _radius)
    {
        foreach (GameObject obj in objs)
        {
            if (Vector3.Distance(transform.position, obj.transform.position) < _radius){
                obj.SetActive(false);

            }

        }

        foreach (GameObject mail in mailBox)
        {
            //Debug.Log("Buzon " + mail.name + " posicion: " + Vector3.Distance(transform.position, mail.transform.position) + " radio "+ _radius.ToString());
            if (Vector3.Distance(transform.position, mail.transform.position) < _radius)
            {


                mail.GetComponent<MailBox>().IsInArea = true;

            }

        }
    }
}

