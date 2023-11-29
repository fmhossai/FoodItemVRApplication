using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class placeOrder : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseOver()
    {
        GetComponent<Renderer>().material.color = new Color(0.9f, 0.8f, 0.6f, 1f);
    }


    void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = Color.white;
    }
    private void OnMouseDown()
    {
        orderPlaced.txt.text = "Order Placed!\n" + summaryBox.obj.text;
        pizzaBox.currentPrice = 0.0f;
        cheesecakeBox.currentPrice = 0.0f;
        hotdogBox.currentPrice = 0.0f;
        milkshakeBox.currentPrice = 0.0f;
        summaryBox.updatePrice();
        orderPlaced.Show();
        closeButton.Show();
    }
}
