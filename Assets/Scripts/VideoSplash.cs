using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoSplash : MonoBehaviour
{
    public VideoPlayer videoSplash;
    // Start is called before the first frame update
    void Start()
    {
        videoSplash.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
