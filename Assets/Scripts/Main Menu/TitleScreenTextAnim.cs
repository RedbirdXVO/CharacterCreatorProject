using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class TitleScreenTextAnim : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_FontAsset titleFont;
    public Material titleFontMaterial;
    static float minGlow = 0.3f;
    static float maxGlow = 0.9f;
    TextMeshProUGUI titleObj;
    float glowIncrement = 0.1f;
    float glowCurrent;
    void Start()
    {
        titleObj = GetComponent<TextMeshProUGUI>();
        titleFont = titleObj.font;
        titleFontMaterial = titleObj.material;

        //Glow Init
        glowCurrent = minGlow;
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((glowCurrent > maxGlow) || (glowCurrent < minGlow))
        {
             glowIncrement = glowIncrement * -1;
        }

        glowCurrent += glowIncrement * Time.deltaTime;

        titleObj.fontSharedMaterial.SetFloat(ShaderUtilities.ID_GlowOffset, glowCurrent);

        //Debugging
        /*Debug.Log("ID_GlowOffset: " + titleObj.fontSharedMaterial.GetFloat(ShaderUtilities.ID_GlowOffset) + 
            " \tVar glowCurrent: " + glowCurrent + 
            "\tVar glowIncrement: " + glowIncrement);*/


        
    }
}
