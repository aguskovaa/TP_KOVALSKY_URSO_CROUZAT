using System.Drawing;
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


        int[] valores = { valorObjeto2, valorObjeto3, valorObjeto4 };
        int suma2 = valores[Random.Range(0, valores.Length)] + valorObjeto;
        string sumastring = suma2.ToString();
        suma.text = "               +               ?               =              " + sumastring;
        }

    }

