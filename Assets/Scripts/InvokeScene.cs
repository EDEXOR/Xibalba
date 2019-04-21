using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InvokeScene : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Invoke("MenuScene", 3);
    }

    private void MenuScene()
    {
        SceneManager.LoadScene("Menu");
    }
}
