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
            str += $"\npizza : {pizzaBox.currentPrice}";
        }
        
        if(cheesecakeBox.currentPrice > 0.0)
        {
            str += $"\ncheese cake : {cheesecakeBox.currentPrice}";
        }
        
        if(hotdogBox.currentPrice > 0.0)
        {
            str += $"\nhotdog : {hotdogBox.currentPrice}";
        }
        
        if(milkshakeBox.currentPrice > 0.0)
        {
            str += $"\nmilkshake : {milkshakeBox.currentPrice}";
        }


        obj.text = str;
    }
}
