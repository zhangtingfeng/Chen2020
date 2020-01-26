using UnityEngine;
using System.Collections;

public class ScreenSet : MonoBehaviour
{

    // Use this for initialization
    // Use this for initialization
    void Start()
    {
        // Set screen resolution to 640x960, non-fullscreen
        Screen.SetResolution(1920, 1080, false);
        // Use this for initialization

        // Set screen resolution to 640x960, non-fullscreen
        Screen.fullScreen = true;

    }


    // Update is called once per frame
    void Update()
    {

    }
}
