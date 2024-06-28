using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sumador : MonoBehaviour
{

    public Button btn;
    public Button btn1;
    public Button btn2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnMouseDown()
    {
        btn.image.color = Color.gray;
        btn1.image.color = Color.white;
        btn2.image.color = Color.white;
    }

}
