using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Families
{
    public List<Family> families;

    public Families()
    {
        this.families = new List<Family>();
    }
    public void AddFamily(Family family)
    {
        families.Add(family);
    }
    public void RemoveFamily(Family family)
    {
        families.Remove(family);
    }
    public void UpdateFamily(Family family)
    {
        var matchedFamilies = families.Where(c => c.familyName == family.familyName);
        foreach (var matchedFamily in matchedFamilies)
        {
            RemoveFamily(matchedFamily);
        }
        families.Add(family);
    }
}
