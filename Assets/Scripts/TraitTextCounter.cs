using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TraitTextCounter : MonoBehaviour
{
    [SerializeField] GameObject sceneManager;
    TextMeshProUGUI traitTxt;
    string currentTraitCountTxt;
    // Start is called before the first frame update
    void Start()
    {
        sceneManager.GetComponent<CharacterTraits>().GetActiveCharTraitList();
        traitTxt = gameObject.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateTraitCount(int traitCount)
    {
        traitTxt.text = traitCount.ToString() + "/3";
    }
}
