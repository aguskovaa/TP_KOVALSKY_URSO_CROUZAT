﻿using System.Drawing;
using UnityEngine;
using UnityEngine.UI;

public class Value : MonoBehaviour
{
    public int valor;
    public Text suma;
    public Text resultado;
    public Text btn1;
    public Text btn2;
    public Text btn3;
    public Text escondio;

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
        suma.text = "               +               ?               =              " ;
        resultado.text = sumastring;
        int jaja = suma2 - valorObjeto;
        escondio.text = jaja.ToString();


        btn1.text =  valorObjeto2.ToString();
        btn2.text = valorObjeto3.ToString();
        btn3.text = valorObjeto4.ToString();

        PrecioProd.text = "Precio: " + valorObjeto;


        
    }
   
}