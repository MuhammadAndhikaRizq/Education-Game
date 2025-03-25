using UnityEngine;

public class CharacterSelector : MonoBehaviour
{
    [Header("Character")]
    public GameObject boy;
    public GameObject girl;

    private ActiveCondition boyActive;
    private ActiveCondition girlActive;

     public ActiveCondition characterManager;

    private void Awake()
    {
        // Simpan referensi komponen ActiveCondition saat game dimulai
        boyActive = boy.GetComponent<ActiveCondition>();
        girlActive = girl.GetComponent<ActiveCondition>();
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