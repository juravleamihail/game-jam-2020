using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{

    public int currentMoney = 1; //Current Amount of Money
    public int startMoney = 10; //Amount of Money at Start
    public Text moneyText; //create a text variable which will be used to update the Money Text
    bool helpedNpc = false;
    public int moneyToPass = 30;
    public bool dayPassed = false;
    public bool gameOver = false;


    void Start()
    {
        currentMoney = startMoney; //Set amount of money at Start
        moneyText.text = currentMoney.ToString(); //convert the value of (int) currentMoney to a string for moneyText.
    }

    // Update is called once per frame
    void Update()
    {
        if (!dayPassed)
        {
            if (currentMoney < moneyToPass)
            {
                FindObjectOfType<GameManager>().EndGame();
                gameOver = true;
            }     
        }
    }

    public void AddMoney(int moneyToAdd) //Increase the value of currentMoney by a set int value
    {
        if(helpedNpc)
        {
            currentMoney += moneyToAdd; //Increase the value of currentMoney
            moneyText.text = currentMoney.ToString(); //convert the value of (int) currentMoney to a string for moneyText.
        }
        
    }

    public void RemoveMoney(int moneyToSubtract) //Decrease the value of currentMoney
    {
        if (currentMoney - moneyToSubtract < 0)
            currentMoney = 0;

        else
        {
            currentMoney -= moneyToSubtract; //Decrease the value of currentMoney
            moneyText.text = currentMoney.ToString(); //convert the value of (int) currentMoney to a string for moneyText.
        } 
    }
}


//Algorithm

/* 1) Set an int for the Current Money value; -> public int CurrentMoney
 * 2) Set an int for the Start Money value; -> public int StartMoney
 * 3) Set amount of Money on Start -> Void Start() -> currentMoney = StartMoney;
 * 4) Drag Money" Script to the Main Camera GO
 * 5) Create Method to Add Money -> AddMoney()
 * 6) Inside the AddMoney brackets use an int to determine the amount to add -> AddMoney(int moneyToAdd)
 * 7) Create SubtractMoney() and add the param MoneyToSubtract -> public void subtractMoney(int moneyToSubtract)
 * 8) Dont run SubtractMoney() if CurrentMoney < 0 -> if(currentMoney - moneyToSubtract < 0)...
 * 9) Decrease CurrentMoney by MoneyToSubtract if currentMoney - MoneyToSubtract is not < 0 -> else currentMoney -= moneyToSubtract;
 * Updating Text to Display CurrentMoney 
 * 1) Create a Text GO in the Editor
 * 2) Add "using UnityEngine.UI" on top
 * 3) Create a Text variable "moneyText" -> public text moneyText;
 * 4) [Editor] Add the Text GO from Canvas to the MoneyText section of the Money script;
 * We want to convert the Text GO in the amount of currentMoney
 * 1) On Start(), Grab the Text comp of Text GO -> moneyText.text
 * 2) Set moneyText.text to the value of currentMoney bu converting curMoney to a string -> moneyText.text = money.ToString();
 * Update the CurrMoney text when Adding or Removing
 * 1) In the AddMoney() func, add moneyText.text = money.ToString();
 * 2) In the RemovedMoney() func, add moneyText.text = money.ToString();
*/
