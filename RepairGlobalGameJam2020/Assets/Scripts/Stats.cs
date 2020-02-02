using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stats : MonoBehaviour
{
    public Text moneyValue;
    public Sprite[] staminaSprites;
    public Image currentStamina;
    public Image currentKarma;
    public Sprite[] karmaSprites;
    public GameObject player;

    private void Update()
    {
        moneyValue.text = player.GetComponent<Money>().currentMoney.ToString();

        int staminaValue = (player.GetComponent<Stamina>().currentStamina < staminaSprites.Length) ? player.GetComponent<Stamina>().currentStamina : staminaSprites.Length-1; //Shows 3 Stamina Herarts
        Vector2 staminaSpriteSize = new Vector2(staminaSprites[staminaValue].rect.width, staminaSprites[staminaValue].rect.height); //Sizes the Stamina Image
        currentStamina.rectTransform.sizeDelta = staminaSpriteSize; //Rect Transform
        currentStamina.sprite = staminaSprites[staminaValue]; //2 Hearts

        int karmaValue = (player.GetComponent<Karma>().currentKarma < karmaSprites.Length) ? player.GetComponent<Karma>().currentKarma : karmaSprites.Length - 1;
        Vector2 karmaSpriteSize = new Vector2(karmaSprites[karmaValue].rect.width, karmaSprites[karmaValue].rect.height);
        currentKarma.rectTransform.sizeDelta = karmaSpriteSize;
        currentKarma.sprite = karmaSprites[karmaValue];
    }
}
