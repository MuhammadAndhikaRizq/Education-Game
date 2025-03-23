using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    [SerializeField] private GameObject[] uiElements;

    public void SwitchTo(GameObject uiEnabled)
    {
        foreach (GameObject ui in uiElements)
        {
            ui.SetActive(false);
        }
        
        uiEnabled.SetActive(true);
    }

    public void ActiveCharater(GameObject character)
    {
        character.SetActive(true); 
    
    }

    public void DeactiveCharater(GameObject character)
    {
        character.SetActive(false); 
    
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
