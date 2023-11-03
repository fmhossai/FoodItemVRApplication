using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hotdogPlus : MonoBehaviour
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
        hotdogBox.currentPrice += 0.99;
        summaryBox.updatePrice();
    }
}
