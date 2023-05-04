using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static UnityEngine.ParticleSystem;

public class TraitButton : MonoBehaviour
{


    Image                   buttonImage;
    bool                    buttonSelected      = false;

    public GameObject       sceneManager;
    public GameObject       traitButton;
    public GameObject       totalTraitsText;

    public CharacterTraits  characterTraits;
    public TraitTextCounter traitTextCounter;

    public List<string>     traitList           = new List<string>();
    public List<string>     selectedTraits      = new List<string>();


    int buttonNum;
    int cnt;
    // Start is called before the first frame update
    void Start()
    {
        // Value Init -------------------------- //
        traitButton = GameObject.Find("Toggle");
        buttonImage = GetComponent<Button>().GetComponent<Image>(); // <--------    // Note: This line of code generates an error "NullReferenceException: Object reference not set to an instance of an object"
        sceneManager = GameObject.Find("SceneManager");                             // It doesn't seem to break anything, and my attempts at fixing it have caused more issues than its worth. Leaving it for now.
        totalTraitsText = GameObject.Find("Total Traits Text");
        characterTraits = sceneManager.GetComponent<CharacterTraits>();
        traitTextCounter = totalTraitsText.GetComponent<TraitTextCounter>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ButtonSelected()
    {
        
        buttonSelected = !buttonSelected;
        if (buttonSelected)
        {
            cnt = characterTraits.GetActiveCharTraitCount();

            if (characterTraits.GetActiveCharTraitCount() >= characterTraits.GetMaxTraits()) { buttonSelected = !buttonSelected; }
            else 
            { 
                buttonImage.color = Color.gray;
            }
            
        }
        else
        {
            buttonImage.color = Color.white;
        }
        characterTraits.SetActiveCharTraitList(buttonNum);
        characterTraits.GetActiveCharTraitList();
        
    }

    public void SetButtonNum(int num)
    {
        buttonNum = num;
    }
}
