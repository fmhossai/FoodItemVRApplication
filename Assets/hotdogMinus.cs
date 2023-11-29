using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hotdogMinus : MonoBehaviour
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
        if(hotdogBox.currentPrice > 0.0)
        {
            hotdogBox.currentPrice -= 0.99;

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
        if (hotdogBox.currentPrice > 0.0)
        {
            hotdogBox.currentPrice -= 0.99;

        }
        summaryBox.updatePrice();
    }
}
