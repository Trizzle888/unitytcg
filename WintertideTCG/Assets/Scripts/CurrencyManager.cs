using System;
using System.Collections.Generic;
using UnityEngine;

public class CurrencyManager : MonoBehaviour
{
    private int currencyBalance;

    public int CurrencyBalance
    {
        get { return currencyBalance; }
    }

    public void AddCurrency(int amount)
    {
        currencyBalance += amount;
    }

    public bool SubtractCurrency(int amount)
    {
        if (currencyBalance >= amount)
        {
            currencyBalance -= amount;
            return true; // Currency deducted successfully
        }
        else
        {
            return false; // Insufficient currency
        }
    }
}

