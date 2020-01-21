using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Letter :MonoBehaviour
{
    public int type;
    public GameObject mailbox;

    public void Ini(int _type, GameObject _mailbox )
    {
        type = _type;
        mailbox = _mailbox;
        this.transform.position = GameObject.FindGameObjectWithTag("Hand").transform.position;
        this.transform.parent = GameObject.FindGameObjectWithTag("Player").transform.transform;
    }
}
