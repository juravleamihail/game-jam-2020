using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stamina : MonoBehaviour
{

    public int currentStamina = 1;
    public int maxStamina = 3;
    public int staminaCost = 5; //how much money is 1 stamina point worth
    public Money moneyScript;
    public bool dayIsOver = false; //the day has ended;
    public int dayCounter = 1; //Number of days passed
    public bool npcHelped = false; //BlackSmith has helped an NPC, moves to the next
    bool gameOver = false;

    void Start()
    {
        currentStamina = maxStamina;
    }

    
    void Update()
    {
        if (currentStamina >= maxStamina)
            currentStamina = maxStamina;
        if (moneyScript.currentMoney < staminaCost)
        {
            FindObjectOfType<GameManager>().EndGame();
            gameOver = true;
        }
    }

    public void AddStamina() //Increase the value of currentMoney by a set int value
    {
        if (dayIsOver)
        {
            if (moneyScript.currentMoney > staminaCost)
            {
                for (int i = 0; i < 3; i++)
                {
                    currentStamina++; //Increase the value of currentMoney
                    moneyScript.RemoveMoney(5); //Remove set amount of money when buying stamina
                    dayCounter++;
                }
            }    
        }
    }

    public void RemoveStamina() //Decrease the value of currentMoney
    {
        if(npcHelped)
        {
            if (currentStamina < 0)
                currentStamina = 0;
            else
                currentStamina--;
        }
        
    }
}
