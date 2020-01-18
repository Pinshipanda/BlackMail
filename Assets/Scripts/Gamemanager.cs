using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Gamemanager : MonoBehaviour
{

    int actualDay = 1, minwhitCardAmount = 1, maxwhitCardAmount = 25, minBlackCardAmount = 1, maxBlackCardAmount = 25,totalBlackCard, totalWhiteCard;
    float actualCurrent = 0, currentGoal = 100, reputacion = 0, taxProp = 0, TimeToGo = 300, counter = 0, amountBlackCardDelivered, amountWhiteCardDeliverd, radius = 2;
    bool isTimeForABlackCard = false, setTime =  false;

    //CardsReward cardsReward;


    GameZoneManager gameZoneManager;
    
    public Slider whiteSlider, blackSlider;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);

        }

    }

    // Start is called before the first frame update
    void Start()
    {
        if(SceneManager.GetActiveScene().name == "CardScene")
        {
            whiteSlider.minValue = minwhitCardAmount;
            whiteSlider.maxValue = maxwhitCardAmount;

            blackSlider.minValue = minBlackCardAmount;
            blackSlider.maxValue = maxBlackCardAmount;
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "CardScene")
        {
            GetDay();
            whiteSlider.minValue = minwhitCardAmount;
            whiteSlider.maxValue = maxwhitCardAmount;

           
            blackSlider.minValue = minBlackCardAmount;
            blackSlider.maxValue = maxBlackCardAmount;
            

           
            if (!setTime)
            {
                gameZoneManager = GameObject.Find("GameZoneManager").GetComponent<GameZoneManager>();
                gameZoneManager.GetInactiveInRadius(radius * GetDay());
                TimeToGo = TimeToGo / actualCurrent;
                setTime = true;
            }
        }
        else if(SceneManager.GetActiveScene().name == "_Game")
        {
            //cardsReward = GameObject.Find("Player").GetComponent<MailManager>();

            //amountBlackCardDelivered = cardsReward.GetBlackMailDeliverd();
            //amountWhiteCardDeliverd = cardsReward.GetWhiteMailDeliverd();
            actualCurrent = amountWhiteCardDeliverd + amountBlackCardDelivered;
            counter += Time.deltaTime;
            if (counter >= TimeToGo)
            {                
                Time.timeScale = 0;
                Debug.Log("TimeOver!!!");

            }else if(actualCurrent >= currentGoal){
                Time.timeScale = 0;
                Debug.Log("You win");
            }
        }
    }

    public float GetCurrent()
    {
        return actualCurrent;
    }

    public void SetMoreCurrencyWhite()
    {
        actualCurrent += 100;
    }

    public void SetMoreCurrency()
    {
        actualCurrent += 100;
    }

    public float GetCurrentGoal()
    {
        return currentGoal;
    }


    public int GetDay()
    {
        if (actualDay >= 3)
        {
            isTimeForABlackCard = true;
        }
        return actualDay;
    }

    public bool GetBlackCard()
    {
        return isTimeForABlackCard;
    }

    public int GetMinWhiteCard()
    {
        return minwhitCardAmount;
    }

    public int GetMaxWhiteCard()
    {
        maxwhitCardAmount = (int)((actualDay * maxwhitCardAmount) / 2f);
        return maxwhitCardAmount;
    }

    public int GetMinBlackCard()
    {
        return minBlackCardAmount;
    }

    public int GetMaxBlackCard()
    {
        maxBlackCardAmount = (int)((actualDay * maxBlackCardAmount) / 2f);
        return maxBlackCardAmount;
    }

    public float GetReputation()
    {
         float percentage;
       // amountBlackCardDelivered = cardsReward.GetBlackMailDelivered();
        //taxProp = (amountBlackCardDelivered / totalBlackCard) * 100;
        return taxProp;
    }

    public void StartGame()
    {
        totalWhiteCard = (int)(whiteSlider.value);
        totalBlackCard = (int)(blackSlider.value);
        SceneManager.LoadScene(1);
    }

    public int GetTotalBlackMail()
    {
        return totalBlackCard;
    }


    public int GetTotalWhiteMail()
    {
        return totalWhiteCard;
    }

    public void FinishLevel()
    {
        SceneManager.LoadScene(0);
        setTime = false;
        actualDay++;
        counter = 0;
        float setmoney = (GetCurrent() * 2);
        //SetMoreCurrent(setmoney);
    }
}
