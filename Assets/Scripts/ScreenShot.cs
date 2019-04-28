using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ScreenShot : MonoBehaviour
{
    public void TakeShot()
    {
        StartCoroutine("CaptureIt");
    }

    IEnumerator CaptureIt()
    {
        yield return new WaitForEndOfFrame();
        string data = System.DateTime.Now.ToFileTime().ToString();
        string fileName = "Cihutan" + data + ".png";
        string pathToSave = fileName;
        ScreenCapture.CaptureScreenshot(pathToSave);

        //string origin = System.IO.Path.Combine(Application.persistentDataPath, fileName);
        //string destination = "/internalstorage/ScreenCapture/" + fileName; // could be anything 


    }
}
