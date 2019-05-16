using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjetoShow : MonoBehaviour
{
    public int master;
    public GameObject obj1, obj2, obj3, obj4, obj5, obj6, obj7, obj8, obj9;
    public GameObject txt1, txt2, txt3, txt4, txt5, txt6, txt7, txt8, txt9;
    public GameObject p1, p2, p3, p4, p5, p6, p7, p8, p9;
    public GameObject ptxt1, ptxt2, ptxt3, ptxt4, ptxt5, ptxt6, ptxt7, ptxt8, ptxt9;
    //public bool key = true;

    void Start()
    {
        master = Mostrar.valor;

        switch (master)
        {
            case 1:
                Debug.Log("Chuchito");
                obj1.SetActive(true);
                txt1.SetActive(true);
                p1.SetActive(true);
                ptxt1.SetActive(true);
                break;
            case 2:
                Debug.Log("Jaguar");
                obj2.SetActive(true);
                txt2.SetActive(true);
                p2.SetActive(true);
                ptxt2.SetActive(true);
                break;
            case 3:
                Debug.Log("Traje");
                obj3.SetActive(true);
                txt3.SetActive(true);
                p3.SetActive(true);
                ptxt3.SetActive(true);
                break;
            case 4:
                Debug.Log("Incensario");
                obj4.SetActive(true);
                txt4.SetActive(true);
                p4.SetActive(true);
                ptxt4.SetActive(true);
                break;
            case 5:
                Debug.Log("Masapan");
                obj5.SetActive(true);
                txt5.SetActive(true);
                p5.SetActive(true);
                ptxt5.SetActive(true);
                break;
            case 6:
                Debug.Log("Flecha");
                obj6.SetActive(true);
                txt6.SetActive(true);
                p6.SetActive(true);
                ptxt6.SetActive(true);
                break;
            case 7:
                Debug.Log("Plato");
                obj7.SetActive(true);
                txt7.SetActive(true);
                p7.SetActive(true);
                ptxt7.SetActive(true);
                break;
            case 8:
                Debug.Log("Craneo");
                obj8.SetActive(true);
                txt8.SetActive(true);
                p8.SetActive(true);
                ptxt8.SetActive(true);
                break;
            case 9:
                Debug.Log("Mascara");
                obj9.SetActive(true);
                txt9.SetActive(true);
                p9.SetActive(true);
                ptxt9.SetActive(true);
                break;
            default:
                Debug.Log("Ohh no! Algo ha salido mal");
                break;
        }
    }
      
    
}
