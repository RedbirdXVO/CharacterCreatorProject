using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FamiliesMenuManager : MonoBehaviour
{
    void Start()
	{
		GameObject buttonTemplate = transform.GetChild(0).gameObject;
		GameObject g;

		foreach (var family in Manager.instance.families.families)
		{
			g = Instantiate(buttonTemplate, transform);
			g.transform.GetChild(0).GetComponent<TMP_Text>().text = family.familyName;

			g.GetComponent <Button> ().onClick.AddListener (delegate() {ItemClicked(family);});
			//g.GetComponent<Button>().AddEventListener(i, ItemClicked);
		}

		Destroy(buttonTemplate);
	}
	void ItemClicked(Family family)
	{
		GameObject.Find("CharactersPanel").GetComponent<CharactersMenuManager>().GenerateMenu(family);
	}
	public void GetCharacters()
    {
        foreach (var family in Manager.instance.families.families)
        {
            Debug.Log(family.familyName);
            foreach (var character in family.characters)
            {
                Debug.Log(character.characterName);
            }
        }
    }

}
public static class ButtonExtension
{
	public static void AddEventListener<T>(this Button button, T param, Action<T> OnClick)
	{
		button.onClick.AddListener(delegate () {
			OnClick(param);
		});
	}
}