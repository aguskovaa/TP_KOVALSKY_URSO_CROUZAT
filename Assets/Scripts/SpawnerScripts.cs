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
        prefab.SetActive(true);
        Instantiate(prefab, position).tag = "Producto";

        int prueba = Random.Range(1, productos.Length-1);

        GameObject prefab2 = productos[prueba];
        prefab2.SetActive(true);
        Instantiate(prefab2, position2).tag = "Producto2";

        int prueba3 = prueba - 1;
        GameObject prefab3 = productos[prueba3];
        prefab3.SetActive(true);
        Instantiate(prefab3, position3).tag = "Producto3";

        int prueba4 = prueba + 1;
        GameObject prefab4 = productos[prueba4];
        prefab4.SetActive(true);
        Instantiate(prefab4, position4).tag = "Producto4";
                
            
        }

    // Update is called once per frame
    void Update()
    {
        
    }
}
