using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class TraitListGenerator : MonoBehaviour
{

    [SerializeField] public GameObject traitPrefab;
    GameObject traitList;
    GameObject sceneManager;
    CharacterTraits characterTraits;
    

    // Start is called before the first frame update
    void Start()
    {

        //Obj Init////////////////////////
        traitList = GameObject.Find("Rows");
        sceneManager = GameObject.Find("SceneManager");
        characterTraits = sceneManager.GetComponent<CharacterTraits>();

        
        AssignTraitInfoToItem();
        //characterTraits.GetTraitList();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateTraitObj(GameObject parentObj, string traitName, int i)
    {
        GameObject trait1 = Instantiate(traitPrefab);
        trait1.transform.SetParent(parentObj.transform, false);
        trait1.GetComponentInChildren<TextMeshProUGUI>().text = traitName;
        trait1.GetComponentInChildren<TraitButton>().SetButtonNum(i);
    }

    void AssignTraitInfoToItem()
    {
        int count = characterTraits.GetTraitListCount();
        string trait;
        for (int i = 0; i < count; i++)
        {
            trait = characterTraits.GetTraitByPos(i);
            CreateTraitObj(traitList, trait, i);

        }
        

        
    }
}
