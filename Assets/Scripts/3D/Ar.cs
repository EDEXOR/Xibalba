// Jeremías 29:11
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ar : MonoBehaviour
{
    public Button btn1, btn2; // BOTONES DE INFORMACION
    public GameObject obj1, obj2, obj3, obj4, obj5, obj6, obj7, obj8, obj9; //MODELOS 3D
    public string idioma;
    public int master;

    // Start is called before the first frame update
    void Start()
    {
        idioma = Languages.lang;
        master = Mostrar.opc;

        if (idioma == "Español")
        {
            btn1.GetComponentInChildren<Text>().text = "Regresar";
            btn2.GetComponentInChildren<Text>().text = "Museo";
        }
        else if (idioma == "Ingles")
        {
            btn1.GetComponentInChildren<Text>().text = "Back";
            btn2.GetComponentInChildren<Text>().text = "Museum";
        }


        switch (master)
        {
            case 1:
                obj1.SetActive(true);
                break;

            case 2:
                obj2.SetActive(true);
                break;

            case 3:
                obj3.SetActive(true);
                break;

            case 4:
                obj4.SetActive(true);
                break;

            case 5:
                obj5.SetActive(true);
                break;

            case 6:
                obj6.SetActive(true);
                break;

            case 7:
                obj7.SetActive(true);
                break;

            case 8:
                obj8.SetActive(true);
                break;

            case 9:
                obj9.SetActive(true);    
                break;

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
