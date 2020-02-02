using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
struct Accepting
{
    public int Gold;
    public int Karma;
    static int Stamina;
}

[Serializable]
struct Declining
{
    public int Gold;
    public int Karma;
    static int Stamina;
}

[Serializable]
struct Customer
{
    public string name;
    public Accepting accepting;
    public Declining declining;
}

public class DayContent : MonoBehaviour
{
    [SerializeField]
    private Customer[] customers;
    [SerializeField]
    private string[] names;
    [SerializeField]
    VIDE_Assign vide_AssignScript;
    [SerializeField]
    private GameObject nextSlide;
    [SerializeField]
    private GameObject Dialogue;
    [SerializeField]
    private GameObject player;
    int customerCount = 0;

    private void OnEnable()
    {
        VIDE_Data.VD.OnEnd += VD_OnEnd;
        Dialogue.SetActive(true);
        SpeakTo();
    }

    private void VD_OnEnd(VIDE_Data.VD.NodeData data)
    {
        if (data.extraData[0] == "Accept")
        {
            player.GetComponent<Money>().AddMoney(customers[customerCount].accepting.Gold);
            player.GetComponent<Karma>().currentKarma += customers[customerCount].accepting.Karma;
            player.GetComponent<Stamina>().currentStamina--;
        }
        else if (data.extraData[0] == "Decline")
        {
            player.GetComponent<Money>().AddMoney(customers[customerCount].declining.Gold);
            player.GetComponent<Karma>().currentKarma += customers[customerCount].declining.Karma;
        }

        customerCount++;
        SpeakTo();
    }

    private void VD_OnActionNode(int nodeID)
    {
        Debug.Log(nodeID);
    }

    void SpeakTo()
    {
        if (customerCount < names.Length)
            vide_AssignScript.AssignNew(names[customerCount]);
        else
        {
            EndOfTheDay();
        }
    }

    public void EndOfTheDay()
    {
        nextSlide.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
