using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class milkshakeBox : MonoBehaviour
{
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

        if (!hasSpawned)
        {
            SpawnObject();
            hasSpawned = true;
        }

    }


    void OnMouseExit()
    {
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
            Vector3 spawnPosition = new Vector3(2.5f, 0.5f, 0.2f);
            spawnedObject = Instantiate(prefabToSpawn, spawnPosition, Quaternion.identity);

            Vector3 newScale = new Vector3(5f, 5f, 5f);
            spawnedObject.transform.localScale = newScale;

        }
    }
}
