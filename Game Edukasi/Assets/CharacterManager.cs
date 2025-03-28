using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    public SpriteRenderer sr;
    public List<Sprite> character  = new List<Sprite>();
    private int selectedChar = 0;
    public GameObject playerChar;

    public void SelectedCharacterBoy()
    {
        selectedChar = 0;
        sr.sprite = character[selectedChar];
        PrefabUtility.SaveAsPrefabAsset(playerChar, "Assets/Prefabs/Character.prefab");
    }

    public void SelectedCharacterGirl()
    {
        selectedChar = 1;
        sr.sprite = character[selectedChar];
        PrefabUtility.SaveAsPrefabAsset(playerChar, "Assets/Prefabs/Character.prefab");
    }
}
