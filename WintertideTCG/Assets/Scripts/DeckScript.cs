using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckScript : MonoBehaviour
{
    [SerializeField] Card prefab;
    [SerializeField] CardData[] cards;

    private void Start()
    {
      Card card = Instantiate(prefab);
      card.Init(cards[0]);
    }
}
