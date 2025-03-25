using UnityEngine;

public class CharacterSelector : MonoBehaviour
{
    [Header("Character")]
    public GameObject boy;
    public GameObject girl;
     public ActiveCondition characterManager;

    private void Start()
    {
        string selectedCharacter = PlayerPrefs.GetString("SelectedCharacter", "Boy");

        if (selectedCharacter == "Boy")
        {
            characterManager.BoyActive(true);
            characterManager.GirlActive(false);
        }
        else
        {
            characterManager.BoyActive(false);
            characterManager.GirlActive(true);
        }
    }

    public void SelectBoy()
    {
        characterManager.BoyActive(true);
        characterManager.GirlActive(false);
        PlayerPrefs.SetString("SelectedCharacter", "Boy");
    }

    public void SelectGirl()
    {
        characterManager.BoyActive(false);
        characterManager.GirlActive(true);
        PlayerPrefs.SetString("SelectedCharacter", "Girl");
    }
}