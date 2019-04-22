using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Team : MonoBehaviour
{
    public GameObject panelTeam, panelSettings;

    public void OpenPanelT()
    {
        if (panelTeam != null)
        {
            bool isActive = panelTeam.activeSelf;
            panelTeam.SetActive(!isActive);
        }
    }

    public void OpenPanelS()
    {
        if (panelSettings != null)
        {
            bool isActive = panelSettings.activeSelf;
            panelSettings.SetActive(!isActive);
        }
    }

}
