using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShift : MonoBehaviour
{   public Camera MainCam;
    public Camera TopCam;
    public Camera DownCam;

    void Start()
    {
        MainCam.enabled = true;
        TopCam.enabled = false;
        DownCam.enabled = false;

    }

    void Update()
    {
        if (IsQuestA == true)
        {   
            DownCam.enabled = true;
            TopCam.enabled = false;
            MainCam.enabled = false;
            
        }
        else
        {
            MainCam.enabled = true;
            TopCam.enabled = false;
            DownCam.enabled = false;
        }

        if (IsQuestB == true)
        {
            TopCam.enabled = true;
            MainCam.enabled = false;
            DownCam.enabled = false;
        }
        else
        {
            MainCam.enabled = true;
            TopCam.enabled = false;
            DownCam.enabled = false;
        }

    }
}
