using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Team : MonoBehaviour
{
    public GameObject panelTeam;

    public void OpenPanel()
    {
        if (panelTeam != null)
        {
            bool isActive = panelTeam.activeSelf;
            panelTeam.SetActive(!isActive);
        }
    }
}
