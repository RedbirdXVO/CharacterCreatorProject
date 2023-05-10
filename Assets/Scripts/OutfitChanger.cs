using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutfitChanger : MonoBehaviour
{
    public SpriteRenderer bodyBase;
    public SpriteRenderer bodyBottom;
    public SpriteRenderer bodyShoe;
    public SpriteRenderer bodyFace;
    public SpriteRenderer bodyHair;
    public SpriteRenderer bodyTop;

    public List<SpriteObject> optionsBase = new List<SpriteObject>();
    public List<SpriteObject> optionsBottom = new List<SpriteObject>();
    public List<SpriteObject> optionsShoe = new List<SpriteObject>();
    public List<SpriteObject> optionsFace = new List<SpriteObject>();
    public List<SpriteObject> optionsHair = new List<SpriteObject>();
    public List<SpriteObject> optionsTop = new List<SpriteObject>();
    // Start is called before the first frame update
    private int currentBaseOption = 0;
    private int currentBottomOption = 0;
    private int currentShoeOption = 0;
    private int currentFaceOption = 0;
    private int currentHairOption = 0;
    private int currentTopOption = 0;
    //public SpriteObject spriteObject;
    private int[] directions = { 0, 1, 2, 3 };
    private int currentDirection = 0;
    public void NextTopOption()
    {
        currentTopOption++;
        if (currentTopOption >= optionsTop.Count)
        {
            currentTopOption = 0;
        }
        bodyTop.sprite = optionsTop[currentTopOption].GetSprite(currentDirection);
    }
    public void PreviousTopOption()
    {
        currentTopOption--;
        if (currentTopOption < 0)
        {
            currentTopOption = optionsTop.Count - 1;
        }
        bodyTop.sprite = optionsTop[currentTopOption].GetSprite(currentDirection);
    }
    public void NextHairOption()
    {
        currentHairOption++;
        if (currentHairOption >= optionsHair.Count)
        {
            currentHairOption = 0;
        }
        bodyHair.sprite = optionsHair[currentHairOption].GetSprite(currentDirection);
    }
    public void PreviousHairOption()
    {
        currentHairOption--;
        if (currentHairOption < 0)
        {
            currentHairOption = optionsHair.Count - 1;
        }
        bodyHair.sprite = optionsHair[currentHairOption].GetSprite(currentDirection);
    }
    public void NextFaceOption()
    {
        currentFaceOption++;
        if (currentFaceOption >= optionsFace.Count)
        {
            currentFaceOption = 0;
        }
        bodyFace.sprite = optionsFace[currentFaceOption].GetSprite(currentDirection);
    }
    public void PreviousFaceOption()
    {
        currentFaceOption--;
        if (currentFaceOption < 0)
        {
            currentFaceOption = optionsFace.Count - 1;
        }
        bodyFace.sprite = optionsFace[currentFaceOption].GetSprite(currentDirection);
    }
    public void NextShoeOption()
    {
        currentShoeOption++;
        if (currentShoeOption >= optionsShoe.Count)
        {
            currentShoeOption = 0;
        }
        bodyShoe.sprite = optionsShoe[currentShoeOption].GetSprite(currentDirection);
    }
    public void PreviousShoeOption()
    {
        currentShoeOption--;
        if (currentShoeOption < 0)
        {
            currentShoeOption = optionsShoe.Count - 1;
        }
        bodyShoe.sprite = optionsShoe[currentShoeOption].GetSprite(currentDirection);
    }
    public void NextBottomOption()
    {
        currentBottomOption++;
        if (currentBottomOption >= optionsBottom.Count)
        {
            currentBottomOption = 0;
        }
        bodyBottom.sprite = optionsBottom[currentBottomOption].GetSprite(currentDirection);
    }
    public void PreviousBottomOption()
    {
        currentBottomOption--;
        if (currentBottomOption < 0)
        {
            currentBottomOption = optionsBottom.Count - 1;
        }
        bodyBottom.sprite = optionsBottom[currentBottomOption].GetSprite(currentDirection);
    }
    public void NextBaseOption()
    {
        currentBaseOption++;
        if (currentBaseOption >= optionsBase.Count)
        {
            currentBaseOption = 0;
        }
        bodyBase.sprite = optionsBase[currentBaseOption].GetSprite(currentDirection);
    }
    public void PreviousBaseOption()
    {
        currentBaseOption--;
        if (currentBaseOption < 0)
        {
            currentBaseOption = optionsBase.Count - 1;
        }
        bodyBase.sprite = optionsBase[currentBaseOption].GetSprite(currentDirection);
    }

    public void RotateRightOption()
    {
        currentDirection--;
        if (currentDirection < 0)
        {
            currentDirection = directions.Length - 1;
        }
        bodyBase.sprite = optionsBase[currentBaseOption].GetSprite(currentDirection);
        bodyBottom.sprite = optionsBottom[currentBottomOption].GetSprite(currentDirection);
        bodyShoe.sprite = optionsShoe[currentShoeOption].GetSprite(currentDirection);
        bodyFace.sprite = optionsFace[currentFaceOption].GetSprite(currentDirection);
        bodyHair.sprite = optionsHair[currentHairOption].GetSprite(currentDirection);
        bodyTop.sprite = optionsTop[currentTopOption].GetSprite(currentDirection);
    }
    public void RotateLeftOption()
    {
        currentDirection++;
        if (currentDirection >= directions.Length)
        {
            currentDirection = 0;
        }
        bodyBase.sprite = optionsBase[currentBaseOption].GetSprite(currentDirection);
        bodyBottom.sprite = optionsBottom[currentBottomOption].GetSprite(currentDirection);
        bodyShoe.sprite = optionsShoe[currentShoeOption].GetSprite(currentDirection);
        bodyFace.sprite = optionsFace[currentFaceOption].GetSprite(currentDirection);
        bodyHair.sprite = optionsHair[currentHairOption].GetSprite(currentDirection);
        bodyTop.sprite = optionsTop[currentTopOption].GetSprite(currentDirection); ;
    }

}


