using UnityEngine;
using UnityEngine.UI;

public class PurchaseButton : MonoBehaviour
{
    public CurrencyManager currencyManager;
    public CardShop cardShop;

    private void Start()
    {
        // Assuming you have a reference to the CurrencyManager and CardShop
        // You can assign these references in the Unity Editor
    }

    public void OnPurchaseButtonClick()
    {
        // Subtract 20 currency when the purchase button is clicked
        if (currencyManager.SubtractCurrency(20))
        {
            // If the currency deduction is successful, buy the card pack
            cardShop.BuyCardPack();
        }
        else
        {
            // If the player has insufficient funds, display an error message
            Debug.Log("Insufficient funds!");
        }
    }
}
