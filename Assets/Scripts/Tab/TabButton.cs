using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

// TabGroup and TabButton scripts used instead of UI buttons, as there is no clean way to implement tab functionality with buttons alone in Unity.



[RequireComponent(typeof(Image))]       // Makes an image required. 
                                        // Without an image, the script will return errors.

// IPointer handlers allow script to run when exiting, entering, or clicking a tab
public class TabButton : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler, IPointerExitHandler
{
    public TabGroup tabGroup;

    public Image background;

    public void OnPointerClick(PointerEventData eventData)
    {
        tabGroup.OnTabSelected(this);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        tabGroup.OnTabEnter(this);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        tabGroup.OnTabExit(this);
    }


    // Start is called before the first frame update
    void Start()
    {
        background = GetComponent<Image>();
        tabGroup.Subscribe(this);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
