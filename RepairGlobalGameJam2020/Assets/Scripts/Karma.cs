using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Karma : MonoBehaviour
{

    public int currentKarma = 1;
    public int maxKarma = 4;
    public Money moneyScript;
    public bool dayIsOver = false; //the day has ended;
    public int dayCounter = 1; //Number of days passed
    bool gameOver = false;
    bool helpedGoodNpc = false;
    bool helpedBadNpc = false;

    // Start is called before the first frame update
    void Start()
    {
        currentKarma = maxKarma;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentKarma >= maxKarma)
            currentKarma = maxKarma;

        if (currentKarma <= 0)
        {
            FindObjectOfType<GameManager>().EndGame();
            gameOver = true;
        }
            
    }

    public void AddKarma() //Increase the value of karma by a set int value
    {
        if (helpedGoodNpc)
        {
            if (currentKarma >= maxKarma)
                currentKarma = maxKarma;
            else
                currentKarma++;
        }
    }

    public void RemoveKarma() //Decrease the value of currentMoney
    {
        if (helpedBadNpc)
        {
            currentKarma--;
            helpedBadNpc = false;
        }        
    }
}
