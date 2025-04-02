using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<SpriteRenderer> characterRenderers; // Semua karakter di scene
    public List<Sprite> characterSprites; // Sprite karakter yang tersedia

    void Start()
    {
        int selectedChar = PlayerPrefs.GetInt("SelectedCharacter", 0); // Ambil pilihan karakter terakhir
        foreach (SpriteRenderer sr in characterRenderers)
        {
            sr.sprite = characterSprites[selectedChar];
        }
    }
}