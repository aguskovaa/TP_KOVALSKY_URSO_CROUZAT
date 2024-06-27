using UnityEngine;

public class Value : MonoBehaviour
{
    public int valor;

    void Start()
    {
        // Aquí obtendremos los GameObjects instanciados por SpawnerScripts
        GameObject[] instancias = GameObject.FindGameObjectsWithTag("Producto");

        foreach (GameObject instancia in instancias)
        {
            int valorObjeto = instancias[0].GetComponent<Value>().valor;
            int valorObjeto2 = instancias[2].GetComponent<Value>().valor;
            int valorObjeto3 = instancias[3].GetComponent<Value>().valor;
            int valorObjeto4 = instancias[4].GetComponent<Value>().valor;
            Debug.Log(valorObjeto);
            Debug.Log(valorObjeto2);
            Debug.Log(valorObjeto3);
            Debug.Log(valorObjeto4);

        }

    }
}
