using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pizzaText : MonoBehaviour
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
        Debug.Log("????");
        GameObject obj = GameObject.Find("Pizza Cube");
        obj.GetComponent<Renderer>().material.color = new Color(0, 1, 1, 0);

    }
}
