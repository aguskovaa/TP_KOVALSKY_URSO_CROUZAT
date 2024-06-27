using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScripts : MonoBehaviour
{
    public GameObject[] productos;
    public Transform position;
    // Start is called before the first frame update
    void Start()
    {
        GameObject prefab = productos[Random.Range(0, productos.Length)];
        Instantiate(prefab, position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
