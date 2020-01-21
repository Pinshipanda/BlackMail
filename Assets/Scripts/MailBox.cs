using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MailBox : MonoBehaviour

{ 
        // Start is called before the first frame update

        public bool IsInArea = false, IsWhiteMail = true, HaveMail = false, IsLetter = false;
        public int HowManyMails;

        public GameObject _valiza;

        GameZoneManager gameZoneManager;

        void Start()
        {
        gameZoneManager = GameObject.Find("GameZoneManager").GetComponent<GameZoneManager>();
        }

        // Update is called once per frame
        void Update()
        {
            
            _valiza.SetActive(IsLetter);
            

        }

        public void SetBool()
        {
            HaveMail = !HaveMail;
        }

        public bool GetBool()
        {
            return HaveMail;
        }


        public void ReachToWin()
    {
        gameZoneManager.reachToWin++;
    }


   
    
}
