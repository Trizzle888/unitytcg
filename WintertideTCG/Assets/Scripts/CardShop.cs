using UnityEngine;
using System.Collections.Generic;

public class CardShop : MonoBehaviour
{
    public CurrencyManager currencyManager; // Reference to the CurrencyManager script
    public List<Card> cardsInPack; // List of cards in a pack (assuming Card is a class or struct representing a card)

    public void BuyCardPack()
    {
        // Define the cost of a card pack (e.g., 20 currency)
        int packCost = 20;

        // Check if the player has enough currency to buy the card pack
        if (currencyManager.SubtractCurrency(packCost))
        {
            // If the currency deduction is successful, award the player a pack of cards
            List<Card> obtainedCards = GenerateCardPack(); // Generate a pack of cards
            // Here you would typically add the obtained cards to the player's collection or inventory
            Debug.Log("Card pack purchased! Obtained cards: " + obtainedCards.Count);
        }
        else
        {
            // If the player has insufficient funds, display an error message
            Debug.Log("Insufficient funds!");
        }
    }

    private List<Card> GenerateCardPack()
    {
        // This method generates a pack of cards. You can customize the logic based on your game's requirements.
        // For simplicity, let's assume each pack contains 4 random cards from the cardsInPack list.
        List<Card> pack = new List<Card>();
        for (int i = 0; i < 4; i++)
        {
            int randomIndex = Random.Range(0, cardsInPack.Count);
            pack.Add(cardsInPack[randomIndex]);
        }
        return pack;
    }
}
