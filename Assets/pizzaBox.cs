using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class pizzaBox : MonoBehaviour
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
        GameObject obj = GameObject.Find("Summary");
        TMP_Text txt = obj.GetComponent<TMP_Text>();
        txt.text = "hello";

    }
}
