using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public string characterName;

    public SpriteObject bodyBase;
    public SpriteObject bodyBottom;
    public SpriteObject bodyShoe;
    public SpriteObject bodyFace;
    public SpriteObject bodyHair;
    public SpriteObject bodyTop;

    public Color bodyColor;
    public Color hairColor;

    public string family;

    public void SaveCharacter(string characterName, SpriteObject bodyBase, SpriteObject bodyBottom, SpriteObject bodyShoe, SpriteObject bodyFace, 
        SpriteObject bodyHair, SpriteObject bodyTop, Color bodyColor, string family)
    {
        this.characterName = characterName;
        this.bodyBase = bodyBase;
        this.bodyBottom = bodyBottom;
        this.bodyShoe = bodyShoe;
        this.bodyFace = bodyFace;
        this.bodyHair = bodyHair;
        this.bodyTop = bodyTop;

        this.bodyColor = bodyColor;

        this.family = family;
    }
}
