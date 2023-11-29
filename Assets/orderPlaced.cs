using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class orderPlaced : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameObject obj;
    public static TMP_Text txt;
    void Start()
    {
        txt = GameObject.Find("Order Placed Text").GetComponent<TMP_Text>();
        obj = gameObject;
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void Show()
    {
        obj.SetActive(true);
    }
    public static void Hide()
    {
        obj.SetActive(false);
    }
}

