using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{

    float red = 0;
    float green = 0;
    float blue = 0;

//Sliders - Instead of using GetComponent, created a serializefield for ease of access

[SerializeField] Slider rSlider;
[SerializeField] Slider gSlider;
[SerializeField] Slider bSlider;



    //ColorToChange
    Color colorSelection = new Color(220,170,160,255);
    SpriteRenderer spriteRenderer;
    

    // Start is called before the first frame update
    void Start()
    {
        GameObject baseFront = GameObject.FindGameObjectWithTag("Player");
        //Get Sprite Renderer for its assigned object
        spriteRenderer = baseFront.GetComponent<SpriteRenderer>();
       // spriteRenderer.color = colorSelection;
    }

    // Update is called once per frame
    void Update()
    {
        
        red = rSlider.value;
        green = gSlider.value;
        blue = bSlider.value;
        Debug.Log("Red: " + red + "Green" + green + "Blue: " + blue);
        spriteRenderer.color = new Color(24,32,65,255);


    }
    void ChoosePartToColor()
    {
        
    }

    void SetColor()
    {

    }
}
