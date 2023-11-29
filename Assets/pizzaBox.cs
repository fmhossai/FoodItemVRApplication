﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class pizzaBox : MonoBehaviour
{

    static public double currentPrice = 0.0; 
    public GameObject prefabToSpawn;
    public GameObject spawnedObject;
    private bool hasSpawned = false;
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
        if (!hasSpawned) 
        {
            SpawnObject();
            hasSpawned = true;
        }
         
    }


    void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = Color.white;
        if (spawnedObject != null)
        {
            Destroy(spawnedObject);
            spawnedObject = null;
            hasSpawned = false;
        }
    }

    void SpawnObject()
    {
        Debug.Log(prefabToSpawn);
        if (prefabToSpawn != null)
        {
            Vector3 spawnPosition = new Vector3(2.5f, 1f, 0.2f);
            spawnedObject = Instantiate(prefabToSpawn, spawnPosition, Quaternion.identity);

            Vector3 newScale = new Vector3(10f, 10f, 10f);
            spawnedObject.transform.localScale = newScale;
            spawnedObject.transform.Rotate(-20, 0, 0, Space.Self);
            spawnedObject.transform.Rotate(0, 180, 0, Space.Self);

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Renderer>().material.color = new Color(0.9f, 0.8f, 0.6f, 1f);
        if (!hasSpawned)
        {
            SpawnObject();
            hasSpawned = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        GetComponent<Renderer>().material.color = Color.white;
        if (spawnedObject != null)
        {
            Destroy(spawnedObject);
            spawnedObject = null;
            hasSpawned = false;
        }
    }
}
