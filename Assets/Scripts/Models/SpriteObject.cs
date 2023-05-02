using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class SpriteObject : MonoBehaviour
{
    public Sprite Front;
    public Sprite Left;
    public Sprite Right;
    public Sprite Back;
    public Sprite GetSprite(int direction)
    {
        switch(direction)
        {
            case 0 : return Front;
            case 1 : return Left;
            case 3 : return Right;
            case 2 : return Back;
            default: return null;
        }
    }
}

