using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Cambiar : MonoBehaviour
{
    public Slider sliderRotacion;
    public GameObject objeto3D;
    
    public void cambiarEscena(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }

    public void rotarObjeto()
    {
        objeto3D.transform.rotation = Quaternion.Euler(0, sliderRotacion.value, 0);
    }
}
