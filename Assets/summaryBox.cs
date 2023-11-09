using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class summaryBox : MonoBehaviour
{
    public static TMP_Text obj;
    // Start is called before the first frame update
    void Start()
    {
        obj = GameObject.Find("Summary").GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void updatePrice()
    {
        string str = "";
        if(pizzaBox.currentPrice > 0.0)
        {
            int pizzaQuantity = (int)Math.Round(pizzaBox.currentPrice / 1.99);
            str += $"\npizza : ${Math.Round(pizzaBox.currentPrice, 2)} Quantity: {pizzaQuantity}";
        }
        
        if(cheesecakeBox.currentPrice > 0.0)
        {
            int cheeseCakeQuantity = (int)Math.Round(cheesecakeBox.currentPrice / 2.99);
            str += $"\ncheese cake : ${Math.Round(cheesecakeBox.currentPrice, 2)} Quantity: {cheeseCakeQuantity}";
        }
        
        if(hotdogBox.currentPrice > 0.0)
        {
            int hotdogQuantity = (int)Math.Round(hotdogBox.currentPrice / 0.99);
            str += $"\nhotdog : ${Math.Round(hotdogBox.currentPrice, 2)} Quantity: {hotdogQuantity}";
        }
        
        if(milkshakeBox.currentPrice > 0.0)
        {
            int milkshakeQuantity = (int)Math.Round(milkshakeBox.currentPrice / 0.5);
            str += $"\nmilkshake : ${Math.Round(milkshakeBox.currentPrice, 2)} Quantity: {milkshakeQuantity}";
        }

        double total = Math.Round(pizzaBox.currentPrice + cheesecakeBox.currentPrice + hotdogBox.currentPrice + milkshakeBox.currentPrice, 2);
        if(total > 0.00)
        {
            str += $"\nTotal : ${total}";
        }

        obj.text = str;
    }
}
