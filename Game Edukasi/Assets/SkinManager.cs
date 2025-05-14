using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEditor;
using UnityEngine;

public class SkinManager : MonoBehaviour
{
    public SpriteRenderer sr;
    public List<Sprite> skins = new List<Sprite>();
    private int selectedSkin = 0;
    public GameObject playerSkin;
    public GameObject winUI;
    public GameObject loseUI;

    [Header("Buttons")]
    public GameObject nextButton;
    public GameObject prevButton;
    public GameObject chooseButton;


    void Start()
    {
        if (skins.Count > 0)
        {
            sr.sprite = skins[selectedSkin];
        }
    }
    public void NextOption()
    {
        selectedSkin = selectedSkin + 1;

        if(selectedSkin == skins.Count)
        {
            selectedSkin = 0;
        }

        sr.sprite = skins[selectedSkin];
    }

    public void PrevOption()
    {
        selectedSkin = selectedSkin - 1;
        if(selectedSkin < 0)
        {
            selectedSkin = skins.Count - 1;
        }
        sr.sprite = skins[selectedSkin];
    }

    public void Pilih()
    {
        if(sr.sprite.name == "Unif-1")
        {
            winUI.SetActive(true);
            playerSkin.SetActive(false);
            nextButton.SetActive(false);
            prevButton.SetActive(false);
            chooseButton.SetActive(false);
            AudioManager.Instance.PlayEventSound();
            AudioManager.Instance.PlayWinStageMandiri();
        }
        else{
            loseUI.SetActive(true);
            playerSkin.SetActive(false);
            nextButton.SetActive(false);
            prevButton.SetActive(false);
            chooseButton.SetActive(false);
            AudioManager.Instance.PlayLoseStageMandiri();
        }
    }
}
