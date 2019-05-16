using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjetoShow : MonoBehaviour
{
    public int master;
    public  GameObject obj1;
    //public bool key = true;

    void Start()
    {
        master = Mostrar.valor;
    }

    void Update()
    {
        if (master == 1)
        {
            Debug.Log("Here we are");
            obj1.SetActive(true);
            Debug.Log(obj1);

        }
        else if (master == 2)
        {
            Debug.Log("Here we are again");
        }
    }
    
}
