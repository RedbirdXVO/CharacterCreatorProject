using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class SceneScript : MonoBehaviour
{
    public GameObject objToColor;
    private PlayerScript playerScript;
    public float[] colors = { 0, 0, 0};
    // Start is called before the first frame update
    void Start()
    {
        // test: was able to change obj to color through this line
        objToColor = GameObject.Find("hairFront_1");

        playerScript = objToColor.GetComponent<PlayerScript>();
        Color startColor = playerScript.GetColor();
        colors[0] = startColor.r;
        colors[1] = startColor.g;
        colors[2] = startColor.b;
        
    }

   public void SwapPartToColor(string tabName)
    {
        if (tabName == "Skin")
        {
            objToColor = GameObject.Find("baseFront");
            playerScript = objToColor.GetComponent<PlayerScript>();
        }
        else
        {
            objToColor = GameObject.Find("hairFront_1");
            playerScript = objToColor.GetComponent<PlayerScript>();
        }
    }
   public void ChangePlayerColor(int rgbIndex, float colorFloat)
   {
        colors[rgbIndex] = colorFloat;
        Color tempColor = new Color(colors[0], colors[1], colors[2]);
        playerScript.SetColor(tempColor);
   }

    public void changeObjectToColor(GameObject objToColor)
    {
        
    }
}
