using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Letter :MonoBehaviour
{
    public int type;
    public GameObject mailbox;

    public Letter()
    {

    }

    public Letter(int _type, GameObject _mailbox)
    {
        type = _type;
        mailbox = _mailbox;
    }
}
