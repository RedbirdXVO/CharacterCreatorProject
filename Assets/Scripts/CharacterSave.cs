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
        var name = GameObject.Find("NameField").GetComponent<TMP_InputField>().text;
        var familyname = GameObject.Find("FamilyDropdown").GetComponent<TMP_Dropdown>().options[GameObject.Find("FamilyDropdown").GetComponent<TMP_Dropdown>().value].text;
        var colors = GameObject.Find("SceneManager").GetComponent<SceneScript>().colors;
        var color = new Color(colors[0], colors[1], colors[2]);

        var character = new Character()
        {
            characterName = name,

            bodyBase = outfitChanger.optionsBase[outfitChanger.currentBaseOption],
            bodyBottom = outfitChanger.optionsBottom[outfitChanger.currentBottomOption],
            bodyShoe = outfitChanger.optionsShoe[outfitChanger.currentShoeOption],
            bodyFace = outfitChanger.optionsFace[outfitChanger.currentFaceOption],
            bodyHair = outfitChanger.optionsHair[outfitChanger.currentHairOption],
            bodyTop = outfitChanger.optionsTop[outfitChanger.currentTopOption],

            bodyColor = color,
            family = familyname
        };
        var index = Manager.instance.families.families.FindIndex(x => x.familyName == character.family);
        Manager.instance.families.families[index].AddCharacter(character);
        Debug.Log($"{familyname}, {character.family}, {character.bodyBase}, {character.characterName} {character.bodyColor}");
        foreach (var familyCharacter in Manager.instance.families.families[index].characters)
        {
            Debug.Log($"{familyCharacter.characterName}");

        }
    }
}
