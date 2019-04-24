using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorController : MonoBehaviour
{
    private Renderer Rend;
    public int cambioColor, cambioColor1, cambioColor2, cambioColor3;
    public int cambioColorTotal;


    void Start()
    {
        GameObject colorEnemigo = GameObject.Find("defensa");
        BaseController baseScript = colorEnemigo.GetComponent<BaseController>();
        cambioColor = baseScript.cambioColor;
        Rend = GetComponent<Renderer>();

    }

    // Update is called once per frame
    void Update()
    {
        GameObject colorEnemigo = GameObject.Find("defensa");
        GameObject colorEnemigo1 = GameObject.Find("defensa (1)");
        GameObject colorEnemigo2 = GameObject.Find("defensa (2)");
        GameObject colorEnemigo3 = GameObject.Find("defensa (3)");
        BaseController baseScript = colorEnemigo.GetComponent<BaseController>();
        BaseController baseScript1 = colorEnemigo1.GetComponent<BaseController>();
        BaseController baseScript2 = colorEnemigo2.GetComponent<BaseController>();
        BaseController baseScript3 = colorEnemigo3.GetComponent<BaseController>();
        cambioColor = baseScript.cambioColor;
        cambioColor1 = baseScript1.cambioColor;
        cambioColor2 = baseScript2.cambioColor;
        cambioColor3 = baseScript3.cambioColor;
        cambioColorTotal = cambioColor + cambioColor1 + cambioColor2 + cambioColor3;


        if (cambioColorTotal == 1)
        {   
            Rend.material.SetColor("_Color", Color.blue);
        }
        if (cambioColorTotal == 2)
        {
            Rend.material.SetColor("_Color", Color.red);
        }
        if (cambioColorTotal == 3)
        {
            Rend.material.SetColor("_Color", Color.yellow);
        }
        if (cambioColorTotal == 4)
        {
            Rend.material.SetColor("_Color", Color.magenta);
        }
        if (cambioColorTotal == 5)
        {
            Rend.material.SetColor("_Color", Color.cyan);
        }
        if (cambioColorTotal == 6)
        {
            Rend.material.SetColor("_Color", Color.gray);
        }
        if (cambioColorTotal == 7)
        {
            Rend.material.SetColor("_Color", Color.green);
        }
        if (cambioColorTotal == 8)
        {
            Rend.material.SetColor("_Color", Color.cyan);
        }
        if (cambioColorTotal == 9)
        {
            Rend.material.SetColor("_Color", Color.magenta);
        }
        if (cambioColorTotal == 10)
        {
            Rend.material.SetColor("_Color", Color.blue);
        }
        if (cambioColorTotal == 11)
        {
            Rend.material.SetColor("_Color", Color.yellow);
        }
        if (cambioColorTotal == 12)
        {
            Rend.material.SetColor("_Color", Color.red);
        }

    }
}
