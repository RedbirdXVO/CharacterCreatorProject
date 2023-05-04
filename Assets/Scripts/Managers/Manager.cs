using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


public class Manager : MonoBehaviour
{
    public static Manager instance = null;
    public Families families;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            families = new Families();
            var family1 = new Family("Family1");
            families.AddFamily(family1);
            var family2 = new Family("Family2");
            families.AddFamily(family2);
            DontDestroyOnLoad(this.gameObject);
        }
        else if (instance != this) Destroy(gameObject);
    }
}
