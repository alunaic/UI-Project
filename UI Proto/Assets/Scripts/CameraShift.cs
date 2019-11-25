using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShift : MonoBehaviour
{   public Camera MainCam;
    public Camera TopCam;
    public Camera DownCam;

    public void CameraChangePyramid()
    {
        DownCam.enabled = true;
        TopCam.enabled = false;
        MainCam.enabled = false;
    }

    public void CameraChangeFace()
    {
        DownCam.enabled = false;
        TopCam.enabled = true;
        MainCam.enabled = false;
    }
    public void CameraChangeMain()
    {
        DownCam.enabled = false;
        TopCam.enabled = false;
        MainCam.enabled = true;
    }
   
        // if ( public string WelcomeText == true)
        // {   
        //     DownCam.enabled = true;
        //     TopCam.enabled = false;
        //     MainCam.enabled = false;
            
        // }
        // else
        // {
        //     MainCam.enabled = true;
        //     TopCam.enabled = false;
        //     DownCam.enabled = false;
        // }

        // if ( GameObject TitleText3 == true)
        // {
        //     TopCam.enabled = true;
        //     MainCam.enabled = false;
        //     DownCam.enabled = false;
        // }
        // else
        // {
        //     MainCam.enabled = true;
        //     TopCam.enabled = false;
        //     DownCam.enabled = false;
        // }

}
