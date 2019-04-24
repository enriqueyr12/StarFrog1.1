using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color2Controller : MonoBehaviour
{
    private Renderer Rendb;
    public int cambioColorb, cambioColorb1, cambioColorb2, cambioColorb3;
    public int cambioColorTotalb;


    void Start()
    {
        GameObject colorEnemigo = GameObject.Find("defensa");
        BaseController baseScript = colorEnemigo.GetComponent<BaseController>();
        cambioColorb = baseScript.cambioColor;
        Rendb = GetComponent<Renderer>();

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
        cambioColorb = baseScript.cambioColor;
        cambioColorb1 = baseScript1.cambioColor;
        cambioColorb2 = baseScript2.cambioColor;
        cambioColorb3 = baseScript3.cambioColor;
        cambioColorTotalb = cambioColorb + cambioColorb1 + cambioColorb2 + cambioColorb3;


        if (cambioColorTotalb == 1)
        {
            Rendb.material.SetColor("_Color", Color.red);
        }
        if (cambioColorTotalb == 2)
        {
            Rendb.material.SetColor("_Color", Color.yellow);
        }
        if (cambioColorTotalb == 3)
        {
            Rendb.material.SetColor("_Color", Color.magenta);
        }
        if (cambioColorTotalb == 4)
        {
            Rendb.material.SetColor("_Color", Color.cyan);
        }
        if (cambioColorTotalb == 5)
        {
            Rendb.material.SetColor("_Color", Color.gray);
        }
        if (cambioColorTotalb == 6)
        {
            Rendb.material.SetColor("_Color", Color.green);
        }
        if (cambioColorTotalb == 7)
        {
            Rendb.material.SetColor("_Color", Color.cyan);
        }
        if (cambioColorTotalb == 8)
        {
            Rendb.material.SetColor("_Color", Color.magenta);
        }
        if (cambioColorTotalb == 9)
        {
            Rendb.material.SetColor("_Color", Color.blue);
        }
        if (cambioColorTotalb == 10)
        {
            Rendb.material.SetColor("_Color", Color.yellow);
        }
        if (cambioColorTotalb == 11)
        {
            Rendb.material.SetColor("_Color", Color.red);
        }
        if (cambioColorTotalb == 12)
        {
            Rendb.material.SetColor("_Color", Color.gray);
        }

    }
}
