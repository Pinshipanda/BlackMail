using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Gamemanager : MonoBehaviour
{

    public int actualDay = 1, minwhitCardAmount = 10, maxwhitCardAmount = 35, minBlackCardAmount = 10, maxBlackCardAmount = 35, totalBlackCard, totalWhiteCard, punish = 0, rango = 1, exp = 0, expRango = 100, amountBlackCardDelivered, amountWhiteCardDeliverd, actualDeliveredTotalMail = 0;
    public float actualCurrency = 0, currencyDuringGame =0, currentGoal = 100, reputacion = 0, taxProp = 0, TimeToGo, counter = 0,  radius = 500, time = 300, amountWhiteCurrencyCardDeliverd, amountBlackCurrencyCardDelivered;
    bool isTimeForABlackCard = false, setTime = false, countPunish = false;

    //CardsReward cardsReward;


    GameZoneManager gameZoneManager;
    
    public Slider whiteSlider, blackSlider;
    public Text whiteText, blackText;
    public GameObject _ui, _uiMenu;

    void Awake()
    {
        _ui.SetActive(false);
        
        TimeToGo = time;
        DontDestroyOnLoad(this.gameObject);
        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);

        }



    }

    // Start is called before the first frame update
    void Start()
    {
        _ui.SetActive(false);
       

        if (SceneManager.GetActiveScene().name == "CardScene")
        {
            whiteText.text = whiteSlider.value.ToString();
            whiteSlider.minValue = minwhitCardAmount;
            whiteSlider.maxValue = maxwhitCardAmount;

            blackText.text = blackSlider.value.ToString();
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
           // _ui.SetActive(true);
            whiteText.text = ((int)(whiteSlider.value)).ToString();
            whiteSlider.minValue = minwhitCardAmount;
            whiteSlider.maxValue = maxwhitCardAmount;

            blackText.text = ((int)(blackSlider.value)).ToString();
            blackSlider.minValue = minBlackCardAmount;
            blackSlider.maxValue = maxBlackCardAmount;
            

           
            if (!setTime)
            {                
                actualCurrency += currencyDuringGame;
                currencyDuringGame = 0;
                TimeToGo = time / actualDay;
                exp += (int)(actualCurrency) / 10;
                if(exp >= expRango)
                {
                    rango++;
                    exp = 0;
                    expRango += 50;
                }
                whiteSlider.value = 0;
                blackSlider.value = 0;
                amountWhiteCardDeliverd = amountBlackCardDelivered = 0;
                countPunish = true;
                setTime = true;
                
            }
        }
        else if(SceneManager.GetActiveScene().name == "_Game")
        {
            
            if (GetReputation() >= 100  && countPunish)
            {
                Debug.Log("Castigo!!");
                punish++;                
                taxProp = 0;
                countPunish = false;
            }
            else
            {
                taxProp = 0;
            }
            //cardsReward = GameObject.Find("Player").GetComponent<MailManager>();
            //_ui.SetActive(false);
            //_uiMenu.SetActive(false);
            //amountBlackCurrencyCardDelivered += cardsReward.GetBlackCurrencyMailDeliverd(); // este regresa la cantidad de dinero juntada en las cartas blancas
            //amountWhiteCurrencyCardDeliverd += cardsReward.GetWhiteCurrencyMailDeliverd(); // este regresa la cantidad de dinero juntada en las cartas negras

            //amountBlackCardDelivered += cardsReward.GetBlackMailDeliverd(); // este regresa la cantidad de cartas blancas entregadas
            //amountWhiteCardDeliverd += cardsReward.GetWhiteMailDeliverd();// este regresa la canitdad de cartas negras entregradas

            gameZoneManager = GameObject.Find("GameZoneManager").GetComponent<GameZoneManager>();
            gameZoneManager.GetInactiveInRadius(radius * GetDay());

            actualDeliveredTotalMail = amountWhiteCardDeliverd + amountBlackCardDelivered;
            currencyDuringGame += amountBlackCurrencyCardDelivered + amountWhiteCurrencyCardDeliverd;

            counter += Time.deltaTime;
            if (counter >= TimeToGo)
            {                
                Time.timeScale = 0;
                Debug.Log("TimeOver!!!");

            }else if(currencyDuringGame >= currentGoal){
                
                Time.timeScale = 0;
                Debug.Log("You win");
            }
        }
    }

    public float GetCurrency()
    {
        return actualCurrency;
    }

    public void SetMoreCurrencyWhite()
    {
        actualCurrency += 100;
    }

    public void SetMoreCurrencyBlack()
    {
        actualCurrency += 200;
    }

    public float GetCurrentGoal()
    {
        return currentGoal;
    }


    public int GetDay()
    {
        if (actualDay >= 3)
        {
            blackSlider.gameObject.SetActive(true);
            blackText.gameObject.SetActive(true);
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
       taxProp = (amountBlackCardDelivered / totalBlackCard) * 100;
        Debug.Log(taxProp);
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


    public int GetRango()
    {
        return rango;
    }

    public int GetTotalWhiteMail()
    {
        return totalWhiteCard;
    }

    public void FinishLevel()
    {
        setTime = false;
        actualDay++;
        counter = 0;
        float setmoney = (GetCurrency() * 2);
        GetMaxBlackCard();
        GetMaxWhiteCard();
        SceneManager.LoadScene(0);
       
        //SetMoreCurrent(setmoney);
    }


}
