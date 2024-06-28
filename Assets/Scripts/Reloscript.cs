using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reloscript : MonoBehaviour
{
    public Button resol;
    public Button btn1;
    public Button btn2;
    public Button btn3;
    public Text ganador;
    public Text btn1t;
    public Text btn2t;
    public Text btn3t;
    public Text noti;
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
        
        int w = System.Convert.ToInt32(ganador.text);
        int poder = int.Parse(btn1t.text);
        int poder1 = int.Parse(btn2t.text);
        int poder2 = int.Parse(btn3t.text);
        if (btn1.image.color == Color.gray && w == poder )
        {
            noti.text = "ganaste";
        }
        if (btn2.image.color == Color.gray && w == poder1)
        {
            noti.text = "ganaste";

        }
        if (btn3.image.color == Color.gray && w== poder2)
        {
            noti.text = "ganaste";
        }
    }
}
