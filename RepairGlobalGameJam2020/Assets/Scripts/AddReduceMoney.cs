using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddReduceMoney : MonoBehaviour
{
    public GameObject cam; //reff to MainCamera (used to get the Money script)

    void Update()
    {
        //Call the Add and Remove Money functions when Left/Right Clicks are pressed
        
        if(Input.GetButtonDown("Fire1")) //LeftMouse - AddMoney
        {
            cam.GetComponent<Money>().AddMoney(3); //Use the AddMoney() func from Money to add a set amount of Money from currentMoney
        }

        if(Input.GetButtonDown("Fire2")) //RightMouse - Remove Money
        {
            cam.GetComponent<Money>().RemoveMoney(3); //Use the RemoveMoney() func from Money to subtract a set amount of Money from currentMoney
        }
    }
}

/*This script works with Money Script - it runs constantly (Update) as the game is going
 * The functions in this script will run when LeftClick(Fire1) and RightClick(Fire2) are pressed (See them in input)
 * 1) In Update, create the GetButtoDownFire1+ Fire2 functions which will be used to Add and Remove money -> if(Input.GetButtonDown("Fire1")) / if(Input.GetButtonDown("Fire2"))
 * 2) At the top where you declare variables, Grab the refference to the GO attatched to the Money Script (MainCamera) through a variable -> public GameObject cam;
 * 3) In Update->GetButtonDown(Fire1). Get the Money script through MainCamera -> cam.GetComponent<Money>();
 * 4) Add the AddMoney() func next to cam.GetComponent<Money> from GetButtonDown(Fire1)-> cam.GetComponent<Money>(addMoney);
 * 5) Add the RemoveMoney() func next to cam.GetComponent<Money> from GetButtonDown(Fire2) -> cam.GetComponent<Money>(RemoveMoney);
 * 6) Attach the AddRemoveMoney(this) script to the Main Camera GO
 * 7) [Editor] Attach the MainCamera as a Go in the CAM container of AddReduceMoney Script
*/
