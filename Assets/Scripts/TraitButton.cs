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


    Image buttonImage;
    bool buttonSelected = false;
    public GameObject sceneManager;
    public CharacterTraits characterTraits;
    public TraitTextCounter traitTextCounter;

    public List<string> traitList= new List<string>();
    public List<string> selectedTraits= new List<string>();


    int buttonNum;

    //GameObject gameObject;



    // test
    int cnt = 0;
    // Start is called before the first frame update
    void Start()
    {
        buttonImage = GetComponent<Button>().GetComponent<Image>();
        sceneManager = GameObject.Find("SceneManager");
        characterTraits = sceneManager.GetComponent<CharacterTraits>();
        traitTextCounter = sceneManager.GetComponent<TraitTextCounter>();

      //  traitList = characterTraits.GetTraitList();


     //   for (int i = 0; i < traitList.Count; i++)
     //   {
      //      Debug.Log(traitList[i]);
     //   }

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
            //cnt = cnt + 1;
            Debug.Log("Cnt: " + cnt.ToString());
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
