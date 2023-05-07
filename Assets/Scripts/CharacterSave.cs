using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
public class CharacterSave : MonoBehaviour
{
    public void SaveCharacter()
    {
        var outfitChanger = GameObject.Find("Player").GetComponent<OptionsManager>();
        var familyname = "Family1";//GameObject.Find("FamilyDropdown").GetComponent<TMP_Dropdown>().options[GameObject.Find("FamilyDropdown").GetComponent<TMP_Dropdown>().value].text;
        var skintone = GameObject.Find("baseFront").GetComponent<PlayerScript>().GetColor();
        var haircolor = GameObject.Find("hairFront_1").GetComponent<PlayerScript>().GetColor();
        var traits = GameObject.Find("SceneManager").GetComponent<CharacterTraits>().GetActiveCharTraitList();
        var character = new Character()
        {
            characterName = outfitChanger.name,

            bodyBase = outfitChanger.optionsBase[outfitChanger.currentBaseOption],
            bodyBottom = outfitChanger.optionsBottom[outfitChanger.currentBottomOption],
            bodyShoe = outfitChanger.optionsShoe[outfitChanger.currentShoeOption],
            bodyFace = outfitChanger.optionsFace[outfitChanger.currentFaceOption],
            bodyHair = outfitChanger.optionsHair[outfitChanger.currentHairOption],
            bodyTop = outfitChanger.optionsTop[outfitChanger.currentTopOption],
            traits = traits,
            bodyColor = skintone,
            hairColor = haircolor,
            family = familyname
        };

        foreach (var trait in traits)
        {
            Debug.Log($"{trait}");
        }

        var index = 0;

        index = Manager.instance.families.families.FindIndex(x => x.familyName == character.family);

        Manager.instance.families.families[index].AddCharacter(character);

        
    }
}
