using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.ParticleSystem;

public class CharacterFamily : MonoBehaviour
{

    List<Family> families = Manager.instance.families.families;

    public string activeFamily = "";

    GameObject traitsTextObj;
    TraitTextCounter traitTextCounter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    public List<Family> GetTraitList()
    {
        for (int i = 0; i < families.Count; i++)
        {
            Debug.Log(families[i]);
        }

        return families;
    }

    //Get Trait my position - useful for looping through
    public Family GetTraitByPos(int i)
    {
        return families[i];
    }

    public int GetTraitListCount()
    {

        return families.Count;
    }

    public void SetActiveFamily(int num)
    {
        activeFamily = families[num].familyName;
    }
    public void SetActiveFamilyNull()
    {
        activeFamily = "";
    }
    public string GetActiveFamily()
    {
        return activeFamily;
    }
}
