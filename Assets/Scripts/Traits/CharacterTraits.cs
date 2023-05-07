using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.ParticleSystem;

public class CharacterTraits : MonoBehaviour
{

    List<string> traits = new List<string>()
                        {   "Bookish",
                            "Sporty",
                            "Sleepy",
                            "Creative",
                            "Ambitious",
                            "Grumpy" };

    public List<string> activeCharTraits = new List<string>();
    string traitToAdd;

    GameObject traitsTextObj;
    TraitTextCounter traitTextCounter;

    int maxTraits = 3;

    // Start is called before the first frame update
    void Start()
    {
        GameObject traitsTextObj = GameObject.Find("Total Traits Text");
        traitTextCounter = traitsTextObj.GetComponent<TraitTextCounter>();
        for (int i = 0; i < GameObject.Find("MenuBase").transform.childCount; i++)
        {
            var child = GameObject.Find("MenuBase").transform.GetChild(i);
            if (child.name != "AppearancePage")
            {
                child.gameObject.SetActive(false);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        traitTextCounter.UpdateTraitCount(activeCharTraits.Count);
    }
    public List<string> GetTraitList()
    {
        for (int i = 0; i < traits.Count; i++)
        {
            Debug.Log(traits[i]);
        }

        return traits;
    }

    //Get Trait my position - useful for looping through
    public string GetTraitByPos(int i)
    {
        return traits[i];
    }

    public int GetTraitListCount()
    {

        return traits.Count;
    }

    public void SetActiveCharTraitList(int num)
    {
        traitToAdd = traits[num];
        Debug.Log("Trait to add: " + traitToAdd);
        Debug.Log("Char Trait Count: " + activeCharTraits.Count);

        if (activeCharTraits.Contains(traitToAdd))
        {
            activeCharTraits.Remove(traitToAdd);
        }
        else
        {
            if (GetActiveCharTraitCount() < GetMaxTraits()) 
            {
            activeCharTraits.Add(traitToAdd);
            }
        }
    }
    public List<string> GetActiveCharTraitList()
    {
        Debug.Log("ACTIVE CHAR TRAITS:\n\n ");
        for (int i = 0; i < activeCharTraits.Count; i++)
        {
            Debug.Log(activeCharTraits[i]);
        }
        Debug.Log("----------------");
        return activeCharTraits;
    }

    public int GetActiveCharTraitCount()
    {

        return activeCharTraits.Count;
    }

    public int GetMaxTraits()
    {
        return maxTraits;
    }
}
