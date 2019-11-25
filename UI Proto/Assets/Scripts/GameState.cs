using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameState: MonoBehaviour
{ // Setup Buttons
    public GameObject PyramidButton;
    public GameObject FaceButton;
    public GameObject WhereButton;
    public GameObject WhatButton;
    public GameObject BackButton;

    // Setup text lines
    public GameObject WelcomeObj;
    public GameObject QuestObj;
    public Text Questtext;
    public GameObject EndObj; 
    bool PyramidSeen = false;
    bool FaceSeen = false;
    
    public string QuestionFace;
    public string QuestionPyramid;
    public string EndText;

    public void WhereButtonClick() 
    // on button click, disable welcome object and button and replace with first question and branching choice
    {
        WelcomeObj.SetActive(false);
        WhereButton.SetActive(false);
        QuestObj.SetActive(true);
        PyramidButton.SetActive(true);
        FaceButton.SetActive(true);

    }

    public void PyramidButtonClick()
    // on button click, change text and button and mark this option as seen
    {
        PyramidButton.SetActive(false);
        FaceButton.SetActive(false);
        Questtext.text = QuestionPyramid;
        BackButton.SetActive(true);
        PyramidSeen = true;

    }

    public void FaceButtonClick()
    // on button click, change text and button and mark this option as seen
    {
        PyramidButton.SetActive(false);
        FaceButton.SetActive(false);
        Questtext.text = QuestionFace;
        BackButton.SetActive(true);
        FaceSeen = true; 

    }
    public void BackButtonClick()
    // if both options have been seen return to main camera view and load end text
    {
        if (PyramidSeen == true && FaceSeen == true)
        {
        PyramidButton.SetActive(false);
        FaceButton.SetActive(false);
        Questtext.text = EndText;
        BackButton.SetActive(false);
        }
        else {
        PyramidButton.SetActive(true);
        FaceButton.SetActive(true);
        Questtext.text = "This is a strange space and it’s all in one place. Chose an angle:";
        BackButton.SetActive(false);
        }
    }
  
}
