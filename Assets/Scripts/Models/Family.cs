using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Family
{
    public string familyName;
    public List<Character> characters;

    public void AddCharacter(Character character)
    {
        characters.Add(character);
    }
    public void RemoveCharacter(Character character)
    {
        characters.Remove(character);
    }
    public void UpdateCharacter(Character character)
    {
        var matchedCharacters = characters.Where(c => c.characterName == character.characterName);
        foreach (var matchedCharacter in matchedCharacters)
        {
            RemoveCharacter(matchedCharacter);
        }
        characters.Add(character);
    }
    public Family(string familyName)
    {
        this.familyName = familyName;
        this.characters = new List<Character>() { };
    }
}
