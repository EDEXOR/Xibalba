using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Languajes : MonoBehaviour
{
    public static string lang;
    public static int est;
    public Button btn1, btn2;
    public Sprite bg1, bg2;
             
    public void obtenerIndiomaEspañol()
    {        
        PlayerPrefs.SetString("languaje", "Español");
        lang = PlayerPrefs.GetString("languaje", "Español");

        PlayerPrefs.SetInt("btnEstado", 1);
        est = PlayerPrefs.GetInt("btnEstado", 1);

        if (est == 1)
        {
            btn1.image.overrideSprite = bg2;
            btn2.image.overrideSprite = bg1;
        }
        
    }
    public void obtenerIndiomaIngles()
    {
        PlayerPrefs.SetString("languaje", "Ingles");
        lang = PlayerPrefs.GetString("languaje", "Ingles");

        PlayerPrefs.SetInt("btnEstado", 2);
        est = PlayerPrefs.GetInt("btnEstado", 2);

        if (est == 2)
        {
            btn2.image.overrideSprite = bg2;
            btn1.image.overrideSprite = bg1;
        }

    }

    void Start()
    {
        lang = PlayerPrefs.GetString("languaje", "Español");
        est = PlayerPrefs.GetInt("btnEstado", 1);
        
     }

    void Update()
    {

        if (est == 1)
        {
            btn1.image.overrideSprite = bg2;
            btn2.image.overrideSprite = bg1;
        }
        else if (est == 2)
        {
            btn2.image.overrideSprite = bg2;
            btn1.image.overrideSprite = bg1;
        }
    }


}
