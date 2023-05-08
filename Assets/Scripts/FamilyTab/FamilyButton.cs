using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static UnityEngine.ParticleSystem;

public class FamilyButton : MonoBehaviour
{
    Image buttonImage;
    bool buttonSelected = false;

    public GameObject sceneManager;
    public GameObject familyButton;
    //public GameObject totalTraitsText;

    public CharacterFamily characterFamily;
   // public TraitTextCounter traitTextCounter;

    //public List<string> traitList = new List<string>();
    //public List<string> selectedTraits = new List<string>();


    int buttonNum;
    int cnt;
    // Start is called before the first frame update
    void Start()
    {
        // Value Init -------------------------- //
        familyButton = GameObject.Find("Toggle");
        buttonImage = GetComponent<Button>().GetComponent<Image>(); // <--------    // Note: This line of code generates an error "NullReferenceException: Object reference not set to an instance of an object"
        sceneManager = GameObject.Find("SceneManager");                             // It doesn't seem to break anything, and my attempts at fixing it have caused more issues than its worth. Leaving it for now.
        characterFamily = sceneManager.GetComponent<CharacterFamily>();

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ButtonSelected()
    {
        if (!buttonSelected && characterFamily.activeFamily == "")
        {
            buttonSelected = true;
            buttonImage.color = Color.gray;
            characterFamily.SetActiveFamily(buttonNum);
            characterFamily.GetActiveFamily();
        }
        else if(buttonSelected)
        {
            buttonSelected = false;
            buttonImage.color = Color.white;
            characterFamily.SetActiveFamilyNull();
            characterFamily.GetActiveFamily();
        }
        
    }
    public void SetButtonNum(int num)
    {
        buttonNum = num;
    }
}
