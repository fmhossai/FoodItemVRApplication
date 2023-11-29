using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class closeButton : MonoBehaviour
{
    public static GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        obj = gameObject;
        gameObject.SetActive(false);
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
    public void OnMouseDown()
    {
        orderPlaced.Hide();
        obj.SetActive(false);
        GetComponent<Renderer>().material.color = Color.white;
    }
    public static void Show()
    {
        obj.SetActive(true);
    }
    public static void Hide()
    {
        obj.SetActive(false);
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
        orderPlaced.Hide();
        obj.SetActive(false);
        obj.GetComponent<Renderer>().material.color = Color.white;
    }
}
