// Jeremías 29:11
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Team : MonoBehaviour
{
    public GameObject panelTeam, panelSettings, panelInfo;

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

    public void OpenPanelInf()
    {
        if (panelInfo != null)
        {
            bool isActive = panelInfo.activeSelf;
            panelInfo.SetActive(!isActive);
        }
    }

    
}
