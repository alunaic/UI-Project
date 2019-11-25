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
    //public GameObject TitleText4;
    //public GameObject TitleText5;
    //public GameObject TitleText6;
    
    public string QuestionFace;
    public string QuestionPyramid;
    public string EndText;

    public void WhereButtonClick()
    {
        WelcomeObj.SetActive(false);
        WhereButton.SetActive(false);
        QuestObj.SetActive(true);
        PyramidButton.SetActive(true);
        FaceButton.SetActive(true);

    }

    public void PyramidButtonClick()
    {
        PyramidButton.SetActive(false);
        FaceButton.SetActive(false);
        //BackButton.SetActive(true);
        Questtext.text = QuestionPyramid;
      

    }
    //setup true-false statements to use later, to check for button clicks and trigger camera change
    // public bool IsQuestA;
    // public bool IsQuestB;
    
    // public bool IsWelcomeB;
    // public bool IsChoiceA;
    // public bool IsChoiceB;
    // public bool Reset;

    //Turns off the welcome text
    //Turns on ChoiceA and ChoiceB buttons
    public void TurnOnChoiceButtons(){
        PyramidButton.SetActive(true);
        FaceButton.SetActive(true);
        WhereButton.SetActive(false);
        WhatButton.SetActive(false);
        
    }
}
