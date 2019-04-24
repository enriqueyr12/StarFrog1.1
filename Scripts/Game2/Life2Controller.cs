using UnityEngine;
using UnityEngine.UI;


public class Life2Controller : MonoBehaviour
{

    public Player2Controlelr lifes;
    public Text vidasText;


    void Update()
    {
        vidasText.text = lifes.vidas.ToString();
    }


}

