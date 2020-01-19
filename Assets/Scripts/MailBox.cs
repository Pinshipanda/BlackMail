using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MailBox : MonoBehaviour

{ 
        // Start is called before the first frame update

        public bool IsInArea = false, IsWhiteMail = true, HaveMail = false, IsLetter = false;
        public int HowManyMails;

        public GameObject _valiza;    

        void Start()
        {

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


   
    
}
