using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orderPlaced : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameObject obj;
    void Start()
    {
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

