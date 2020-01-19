using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening; // Tween for Mail Delivery Animations

public class MailManager : MonoBehaviour
{
    public GameObject backpack;
    public List<Letter> letterList;
    public int whiteLettersDelivered;
    public int blackLettersDelivered;

    private bool canDeliverLetter = true;
    public Gamemanager gamemanager;


    private void Start()
    {
        gamemanager = GameObject.FindGameObjectWithTag("Gamemanager").GetComponent<Gamemanager>();
    }

    void SearchLetters(GameObject _mailbox)
    {
        int tempIndex = -1;

        for (int i = 0; i < letterList.Count; i++)
        {
            if (letterList[i].mailbox == _mailbox)
            {
                tempIndex = i;
            }
        }

        if (tempIndex != -1)
        {
            if (letterList[tempIndex].type == 0) //blanca
            {
                whiteLettersDelivered++;
                gamemanager.SetMoreCurrencyWhite();
                letterList.RemoveAt(tempIndex);
                StartCoroutine(SendToMailbox(0, _mailbox));
            }
            else if (letterList[tempIndex].type == 1)//negra
            {
                blackLettersDelivered++;
                gamemanager.SetMoreCurrencyBlack();
                letterList.RemoveAt(tempIndex);
                StartCoroutine(SendToMailbox(1, _mailbox));
            }  
        }   
    }

    public int GetWhiteLettersDelivered()
    {
        return whiteLettersDelivered;
    }

    public int GetBlackLettersDelivered()
    {
        return blackLettersDelivered;
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetButtonDown("Jump") && canDeliverLetter)
        {
            if (other.gameObject.tag == "MailBox")
            {
                Debug.Log("Con el Buzon");
                // Find the first letter for this mailbox and deliver it.
                SearchLetters(other.gameObject);
                canDeliverLetter = false;
            }
        }

        if (Input.GetButtonUp("Jump"))
        {
            canDeliverLetter = true;
        }
    }

    IEnumerator SendToMailbox(int _type, GameObject _mailbox)
    {
        float timeToWait = 1f;
        //Debug.Log(_typeList.Count);
        GameObject go = new GameObject();

        switch (_type)
        {
            case 0:
                // White Letter
                //go = Instantiate(whitePrefab, backpack.transform.position, backpack.transform.rotation);
                go = ObjectPooler.instancia.SpawnFromPool("WhiteLetter", backpack.transform.position, backpack.transform.rotation);
                break;

            case 1:
                // Black Letter
                //go = Instantiate(blackPrefab, backpack.transform.position, backpack.transform.rotation);
                go = ObjectPooler.instancia.SpawnFromPool("BlackLetter", backpack.transform.position, backpack.transform.rotation);
   
                break;
        }

        if (_type == 0 || _type == 1)
        {
            go.transform.DOMove(new Vector3(go.transform.position.x, go.transform.position.y + Random.Range(2f, 2.5f), go.transform.position.z), 1f);

            go.transform.DORotate(new Vector3(0f, 180f, 0f), 1f);

            yield return new WaitForSeconds(timeToWait);

            go.transform.DOJump(_mailbox.transform.position, 2f, 1, 1f);

            yield return new WaitForSeconds(5f);

            go.SetActive(false);
        }     
    }

    public void AddLetter(Letter _letter)
    {
        Debug.Log(_letter.mailbox.name);
        letterList.Add(_letter);
    }
}
