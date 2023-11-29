using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cheesecakeMinus : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if (cheesecakeBox.currentPrice > 0.0)
        {
            cheesecakeBox.currentPrice -= 2.99;
        }
        summaryBox.updatePrice();
    }

    void OnMouseOver()
    {
        GetComponent<Renderer>().material.color = new Color(0.9f, 0.8f, 0.6f, 1f);
    }


    void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = Color.white;
    }

    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Renderer>().material.color = new Color(0.9f, 0.8f, 0.6f, 1f);
    }
    private void OnCollisionExit(Collision collision)
    {
        GetComponent<Renderer>().material.color = Color.white;
    }
    public static void OnClick()
    {
        if (cheesecakeBox.currentPrice > 0.0)
        {
            cheesecakeBox.currentPrice -= 2.99;
        }
        summaryBox.updatePrice();
    }
}
