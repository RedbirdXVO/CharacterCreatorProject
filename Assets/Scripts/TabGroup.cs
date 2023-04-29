using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;


// State machine for tab group
public class TabGroup : MonoBehaviour
{

    public List<TabButton> tabButtons;
    public Color tabIdle;
    public Color tabHover;
    public Color tabActive;
    public TabButton selectedTab;
    public List<GameObject> objectsToSwap;

    //Color Tab Swapping
    public string objName;
    public bool isColorTab;
    private string tabName;



    [SerializeField] public GameObject sceneManager;

    // Adds button to list
    public void Subscribe(TabButton button)
    {
        // When first tab is added, it creates the list
        if(tabButtons == null)
        {
            tabButtons = new List<TabButton>();
        }

        tabButtons.Add(button);
    }

    void Start()
    {
        objName = gameObject.name;
        //Determine if this is the color tabgroup

        if(objName == "ColorTabGroup")  {isColorTab = true;}
        else                            {isColorTab = false;}

    }
    public void OnTabEnter(TabButton button)
    {
        ResetTabs();
        if(selectedTab == null || button != selectedTab) 
        { 
            button.background.color = tabHover;
        }
        
    }


    public void OnTabExit(TabButton button)
    {
        ResetTabs();
    }

    public void OnTabSelected(TabButton button)
    {
        selectedTab = button;
        ResetTabs();
        button.background.color = tabActive;
        int index = button.transform.GetSiblingIndex();
        for (int i = 0; i < objectsToSwap.Count; i++)
        {
            if (i == index)
            {
                objectsToSwap[i].SetActive(true);
            }
            else
            {
                objectsToSwap[i].SetActive(false);
            }
        } 

        //allows swapping between skin and hair color
        if(isColorTab == true)
        {
            tabName = selectedTab.name;
            sceneManager.GetComponent<SceneScript>().SwapPartToColor(tabName);
            
        }
    }


    public void ResetTabs()
    {
        foreach(TabButton button in tabButtons)
        {
            if(selectedTab!=null && button == selectedTab)
            {
                continue;
            }

            button.background.color = tabIdle;
        }
        
    }
    
    public void getActiveTab(TabButton button)
    {

    }
        
}
