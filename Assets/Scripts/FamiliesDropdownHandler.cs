using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FamiliesDropdownHandler : MonoBehaviour
{   
    // Start is called before the first frame update
    void Start()
    {
        var dropdown = transform.GetComponent<TMP_Dropdown>();
        dropdown.options.Clear();
        List<string> items = new List<string>();
        //var manager = GameObject.Find("GameManager").GetComponent<Manager>();
        foreach (var family in Manager.instance.families.families)
        {
            //Debug.Log($"Families are {family.familyName}");
            items.Add(family.familyName);
        }

        foreach(var item in items)
        {
            dropdown.options.Add(new TMP_Dropdown.OptionData() { text = item });
        }
    }
}
