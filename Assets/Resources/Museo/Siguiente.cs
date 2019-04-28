using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Siguiente : MonoBehaviour
{
    public Camera camPerrito;
    public Camera camPiramide;

    void start()
    {
        camPerrito.enabled = true;
        camPiramide.enabled = false;
        print("INICIANDO");
    }

    public void verPiramide()
    {
        camPerrito.enabled = false;
        camPiramide.enabled = true;
        print("PIRAMIDE");
    }

    public void verPerrito()
    {
        camPerrito.enabled = true;
        camPiramide.enabled = false;
        print("PERRITO");
    }
    
}
