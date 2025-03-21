using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelected : UI
{
    public void SelectCharacter(GameObject character)
    {
        character.SetActive(false); 
    }
}
