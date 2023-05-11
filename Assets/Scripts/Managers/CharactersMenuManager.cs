using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CharactersMenuManager : MonoBehaviour
{
    [SerializeField]
    public GameObject buttonTemplate;
    void Start()
        {
        }
    public void GenerateMenu(Family family = null)
    {
        
        if (family != null)
        {
            GameObject g;
            foreach (Transform child in gameObject.transform) { GameObject.Destroy(child.gameObject); }

            foreach (var character in family.characters)
            {
                g = Instantiate(buttonTemplate, transform);
                g.transform.GetChild(0).GetComponent<TMP_Text>().text = character.characterName;

                g.GetComponent<Button>().onClick.AddListener(delegate () {
                    ItemClicked(character);
                });
                //g.GetComponent<Button>().AddEventListener(i, ItemClicked);
            }
        }
    }
    void ItemClicked(Character character)
    {
        GameObject.Find("NamePlate").transform.Find("Text (TMP)").GetComponent<TMP_Text>().text = character.characterName;
        GameObject g = GameObject.Find("CurrentCharacter").gameObject;
        g.transform.Find("base").GetComponent<SpriteRenderer>().sprite = character.bodyBase.Front;
        g.transform.Find("base").GetComponent<SpriteRenderer>().color = character.bodyColor;
        g.transform.Find("bottom").GetComponent<SpriteRenderer>().sprite = character.bodyBottom.Front;
        g.transform.Find("shoe").GetComponent<SpriteRenderer>().sprite = character.bodyShoe.Front;
        g.transform.Find("face").GetComponent<SpriteRenderer>().sprite = character.bodyFace.Front;
        g.transform.Find("hair").GetComponent<SpriteRenderer>().sprite = character.bodyHair.Front;
        g.transform.Find("hair").GetComponent<SpriteRenderer>().color = character.hairColor;
        g.transform.Find("top").GetComponent<SpriteRenderer>().sprite = character.bodyTop.Front;
    }
}
