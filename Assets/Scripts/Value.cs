using System.Drawing;
using UnityEngine;
using UnityEngine.UI;

public class Value : MonoBehaviour
{
    public int valor;
    public Text suma;



    public Text btn1;
    public Text btn2;
    public Text btn3;

    public Text PrecioProd;

    void Start()
    {
        GameObject instancias = GameObject.FindGameObjectWithTag("Producto");
        GameObject instancias2 = GameObject.FindGameObjectWithTag("Producto2");
        GameObject instancias3 = GameObject.FindGameObjectWithTag("Producto3");
        GameObject instancias4 = GameObject.FindGameObjectWithTag("Producto4");


        int valorObjeto = instancias.GetComponent<Value>().valor;
        int valorObjeto2 = instancias2.GetComponent<Value>().valor;
        int valorObjeto3 = instancias3.GetComponent<Value>().valor;
        int valorObjeto4 = instancias4.GetComponent<Value>().valor;


        int[] valores = { valorObjeto2, valorObjeto3, valorObjeto4 };
        int suma2 = valores[Random.Range(0, valores.Length)] + valorObjeto;
        string sumastring = suma2.ToString();
        suma.text = "               +               ?               =              " + sumastring;


        btn1.text = "Precio: " + valorObjeto2;
        btn2.text = "Precio: " + valorObjeto3;
        btn3.text = "Precio: " + valorObjeto4;

        PrecioProd.text = "Precio: " + valorObjeto;


        
    }
   
}