using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mostrar : MonoBehaviour
{

    //Guardar objeto a visualizar  
    public  int Valor = 0;
    public static int valor;
    //public int num;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public GameObject opc1, opc2, opc3, opc4, opc5, opc6, opc7, opc8, opc9;
      
    public void optenerTag()
    {
        valor = Valor;
    }

}
