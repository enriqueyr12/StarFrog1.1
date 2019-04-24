using UnityEngine;
using UnityEngine.UI;


public class LifeController : MonoBehaviour
{

    public PlayerController lifes;
    public Text vidasText;

    void Update()
    {

        vidasText.text = lifes.vidas.ToString();

    }
}
