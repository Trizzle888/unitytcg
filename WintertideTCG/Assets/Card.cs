using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    [SerializeField] Image body, icon;
    [SerializeField] TMPro.TextMeshProUGUI cardName, scrapCost, health, damage;

    public void Init(CardData data)
    {
        icon.sprite = data.cardIcon;
        body.sprite = data.cardBody;
        health.text = data.health + " ";
        damage.text = data.damage + " ";
        scrapCost.text = data.scrapCost + " ";
        cardName.text = data.cardName + " ";
         
    }

}
