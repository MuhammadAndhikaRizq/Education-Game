using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
  public List<SpriteRenderer> characterRenderers; // List untuk semua karakter di scene
    public List<Sprite> characterSprites; // List untuk sprite karakter yang bisa dipilih
    private int selectedChar = 0;

    void Start()
    {
        // Set sprite semua karakter di scene sesuai dengan pilihan terakhir
        SetAllCharacterSprites();
    }

    public void SelectedCharacterBoy()
    {
        selectedChar = 0;
        SetAllCharacterSprites();
        PlayerPrefs.SetInt("SelectedCharacter", selectedChar);
    }

    public void SelectedCharacterGirl()
    {
        selectedChar = 1;
        SetAllCharacterSprites();
        PlayerPrefs.SetInt("SelectedCharacter", selectedChar);
    }

    private void SetAllCharacterSprites()
    {
        foreach (SpriteRenderer sr in characterRenderers)
        {
            sr.sprite = characterSprites[selectedChar]; // Set semua karakter dengan sprite yang dipilih
        }
    }
}
