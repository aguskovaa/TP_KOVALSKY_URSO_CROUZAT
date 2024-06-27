using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScripts : MonoBehaviour
{

    public GameObject[] productos;
    public Transform position;
    public Transform position2;
    public Transform position3;
    public Transform position4;
    // Start is called before the first frame update
    void Start()
    {
        GameObject prefab = productos[Random.Range(0, productos.Length)];
        Instantiate(prefab, position).tag = "Producto";
        GameObject prefab2 = productos[Random.Range(0, productos.Length)];
        Instantiate(prefab2, position2).tag = "Producto";
        GameObject prefab3 = productos[Random.Range(0, productos.Length)];
        Instantiate(prefab3, position3).tag = "Producto";
        GameObject prefab4 = productos[Random.Range(0, productos.Length)];
        Instantiate(prefab4, position4).tag = "Producto";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
