using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Languages : MonoBehaviour
{
    public static string lang;
    public static int est;
    public Button btn1, btn2;
    public Sprite bg1, bg2;
    public Text dev1, dev2, dev3, dev4;
             
    public void obtenerIndiomaEspañol()
    {        
        PlayerPrefs.SetString("language", "Español");
        lang = PlayerPrefs.GetString("language", "Español");

        PlayerPrefs.SetInt("btnEstado", 1);
        est = PlayerPrefs.GetInt("btnEstado", 1);        
        
    }
    public void obtenerIndiomaIngles()
    {
        PlayerPrefs.SetString("language", "Ingles");
        lang = PlayerPrefs.GetString("language", "Ingles");

        PlayerPrefs.SetInt("btnEstado", 2);
        est = PlayerPrefs.GetInt("btnEstado", 2);

    }

    void Start()
    {
        lang = PlayerPrefs.GetString("language", "Español");
        est = PlayerPrefs.GetInt("btnEstado", 1);

        if (est == 1)
        {
            btn1.image.overrideSprite = bg2;
            btn2.image.overrideSprite = bg1;
            dev1.text = "Equipo de desarrollo";
            dev2.text = "Cihuatán";
            dev3.text = "Museo";
            dev4.text = "Idioma de la aplicación";
            btn1.GetComponentInChildren<Text>().text = "Español";
            btn2.GetComponentInChildren<Text>().text = "Inglés";

        }
        else if (est == 2)
        {
            btn2.image.overrideSprite = bg2;
            btn1.image.overrideSprite = bg1;
            dev1.text = "Our amazing team";
            dev2.text = "Cihuatán";
            dev3.text = "Museum";
            dev4.text = "App language";
            btn1.GetComponentInChildren<Text>().text = "Spanish";
            btn2.GetComponentInChildren<Text>().text = "English";
        }

    }

    void Update()
    {

        if (est == 1)
        {
            btn1.image.overrideSprite = bg2;
            btn2.image.overrideSprite = bg1;
            dev1.text = "Equipo de desarrollo";
            dev2.text = "Cihuatán";
            dev3.text = "Museo";
            dev4.text = "Idioma de la aplicación";
            btn1.GetComponentInChildren<Text>().text = "Español";
            btn2.GetComponentInChildren<Text>().text = "Inglés";

        }
        else if (est == 2)
        {
            btn2.image.overrideSprite = bg2;
            btn1.image.overrideSprite = bg1;
            dev1.text = "Our amazing team";
            dev2.text = "Cihuatán";
            dev3.text = "Museum";
            dev4.text = "App language";
            btn1.GetComponentInChildren<Text>().text = "Spanish";
            btn2.GetComponentInChildren<Text>().text = "English";
        }
    }


}
