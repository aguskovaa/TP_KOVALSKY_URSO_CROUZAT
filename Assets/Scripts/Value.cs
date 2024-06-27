using UnityEngine;

public class Value : MonoBehaviour
{
    public int valor;

    void Start()
    {
        // Aquí obtendremos los GameObjects instanciados por SpawnerScripts
        GameObject[] instancias = GameObject.FindGameObjectsWithTag("Producto");

        
            int valorObjeto = instancias[0].GetComponent<Value>().valor;
            int valorObjeto2 = instancias[2].GetComponent<Value>().valor;
            int valorObjeto3 = instancias[3].GetComponent<Value>().valor;
            int valorObjeto4 = instancias[4].GetComponent<Value>().valor;
            Debug.Log(valorObjeto + "v0");
            Debug.Log(valorObjeto2 + "v2");
            Debug.Log(valorObjeto3 + "v3");
            Debug.Log(valorObjeto4 + "v4");

        }

    }

