using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pizzaPlus : MonoBehaviour
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
        pizzaBox.currentPrice += 1.99f;
        summaryBox.updatePrice();
   }
}
