using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenAuto : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Screen.orientation = ScreenOrientation.AutoRotation;
    }


}
