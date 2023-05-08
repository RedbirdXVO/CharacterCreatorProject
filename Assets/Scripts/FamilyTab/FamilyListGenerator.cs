using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class FamilyListGenerator : MonoBehaviour
{

    [SerializeField] public GameObject familyPrefab;
    GameObject familyList;
    GameObject sceneManager;
    List<Family> families;
    //CharacterFamily characterFamily;

    // Start is called before the first frame update
    void Start()
    {

        //Obj Init////////////////////////
        familyList = GameObject.Find("FamilyRows");
        sceneManager = GameObject.Find("SceneManager");
        families = Manager.instance.families.families;
        //characterFamily = sceneManager.GetComponent<CharacterFamily>();
        //.


        AssignTraitInfoToItem();
        //characterTraits.GetTraitList();

    }

    // Update is called once per frame
    void Update()
    {

    }

    void CreateTraitObj(GameObject parentObj, string familyName, int i)
    {
        GameObject trait1 = Instantiate(familyPrefab);
        trait1.transform.SetParent(parentObj.transform, false);
        trait1.GetComponentInChildren<TextMeshProUGUI>().text = familyName;
        trait1.GetComponentInChildren<FamilyButton>().SetButtonNum(i);
    }

    void AssignTraitInfoToItem()
    {
        int count = families.Count;
        string familyName;
        
        for (int i = 0; i < count; i++)
        {
            familyName = families[i].familyName;
            Debug.Log(familyName);
            CreateTraitObj(familyList, familyName, i);

        }

    }
}
