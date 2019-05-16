using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mostrar : MonoBehaviour
{

    //Guardar objeto a visualizar  
    public static int valor;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    
    public GameObject opc1, opc2, opc3;
    public void Start()
    {
        if (opc1 = GameObject.FindGameObjectWithTag("opc1"))
        {            
            valor = 1;
            Debug.Log("Valor 1");
        }
        else if (opc2 = GameObject.FindGameObjectWithTag("opc2"))
        {
            valor = 2;
            Debug.Log("Valor 2");
        }
        else if (opc3 = GameObject.FindGameObjectWithTag("opc3"))
        {
            valor = 3;
            Debug.Log("Valor 3");
        }
           
    }
   
   
}
