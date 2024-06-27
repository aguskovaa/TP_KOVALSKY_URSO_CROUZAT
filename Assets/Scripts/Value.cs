using UnityEngine;
using UnityEngine.UI;

public class Value : MonoBehaviour
{
    public int valor;
    public Text suma;
    void Start()
    {
        // Aquí obtendremos los GameObjects instanciados por SpawnerScripts
        GameObject[] instancias = GameObject.FindGameObjectsWithTag("Producto");

        
            int valorObjeto = instancias[1].GetComponent<Value>().valor;
            int valorObjeto2 = instancias[3].GetComponent<Value>().valor;
            int valorObjeto3 = instancias[5].GetComponent<Value>().valor;
            int valorObjeto4 = instancias[7].GetComponent<Value>().valor;
            Debug.Log(valorObjeto + "v0");
            Debug.Log(valorObjeto2 + "v2");
            Debug.Log(valorObjeto3 + "v3");
            Debug.Log(valorObjeto4 + "v4");
        int suma2 = (Random.Range(valorObjeto, valorObjeto4)) ;
        suma.text = "               +               ?               =              " + valorObjeto + suma2;
        }

    }

