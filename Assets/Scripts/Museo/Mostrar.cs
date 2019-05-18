// Jeremías 29:11
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Mostrar : MonoBehaviour
{
    public  int Valor = 0, est;    
    public string idioma;
    public TextMeshProUGUI mu1;
    public static int opc;

    public void btn1()
    {
        PlayerPrefs.SetInt("opc", 1);
        opc = PlayerPrefs.GetInt("opc", 1);       
    }
    public void btn2()
    {
        PlayerPrefs.SetInt("opc", 2);
        opc = PlayerPrefs.GetInt("opc", 2);
    }
    public void btn3()
    {
        PlayerPrefs.SetInt("opc", 3);
        opc = PlayerPrefs.GetInt("opc", 3);
    }
    public void btn4()
    {
        PlayerPrefs.SetInt("opc", 4);
        opc = PlayerPrefs.GetInt("opc", 4);
    }
    public void btn5()
    {
        PlayerPrefs.SetInt("opc", 5);
        opc = PlayerPrefs.GetInt("opc", 5);
    }
    public void btn6()
    {
        PlayerPrefs.SetInt("opc", 6);
        opc = PlayerPrefs.GetInt("opc", 6);
    }
    public void btn7()
    {
        PlayerPrefs.SetInt("opc", 7);
        opc = PlayerPrefs.GetInt("opc", 7);
    }
    public void btn8()
    {
        PlayerPrefs.SetInt("opc", 8);
        opc = PlayerPrefs.GetInt("opc", 8);
    }
    public void btn9()
    {
        PlayerPrefs.SetInt("opc", 9);
        opc = PlayerPrefs.GetInt("opc", 9);
    }
        

    void Start()
    {
        idioma = PlayerPrefs.GetString("language", "");
        Debug.Log(idioma);

        if (idioma == "Español")
        {
            mu1.text = "Museo";            
        }
        else if (idioma == "Ingles")
        {
            mu1.text = "Museum";
        }
    }
}
