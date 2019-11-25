using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShift : MonoBehaviour

    //setup camera as public
{   public Camera MainCam;
    public Camera TopCam;
    public Camera DownCam;

    public void CameraChangePyramid()
    //change camera to the lower angle
    {
        DownCam.enabled = true;
        TopCam.enabled = false;
        MainCam.enabled = false;
    }

    public void CameraChangeFace()
    //change camera to the upper angle
    {
        DownCam.enabled = false;
        TopCam.enabled = true;
        MainCam.enabled = false;
    }
    public void CameraChangeMain()
     //change camera to the main camera
    {
        DownCam.enabled = false;
        TopCam.enabled = false;
        MainCam.enabled = true;
    }
   

}
