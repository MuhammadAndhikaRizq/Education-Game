using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLoseCondition : MonoBehaviour
{
     [SerializeField] private List<GameObject> items; // Daftar mainan yang harus masuk
    [SerializeField] private GameObject winLoseUI;
    [SerializeField] private GameObject stage;
    [SerializeField] private string toysTag = "Toys";
    [SerializeField] private string uiTag = "Win";

    private HashSet<GameObject> placedToys = new HashSet<GameObject>(); // Mainan yang sudah dimasukkan

    protected virtual void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(toysTag) && !placedToys.Contains(other.gameObject))
        {
            placedToys.Add(other.gameObject);

            if (placedToys.Count == items.Count)
            {
                PlayAudio();

                winLoseUI.SetActive(true);   
            }
        }
    }

    private void PlayAudio()
    {
        if (winLoseUI.tag == uiTag)
        {
            if (stage.name == "Stage_1")
            {
                AudioManager.Instance.PlayWinStage1Sound();
                AudioManager.Instance.PlayEventSound();
            }
            else if (stage.name == "Stage_7")
            {
                AudioManager.Instance.PlayWinStageMandiri();
                AudioManager.Instance.PlayEventSound();
            }
        }
        else
        {
            if (stage.name == "Stage_1")
            {
                AudioManager.Instance.PlayLoseStage1Sound();
            }
            else if (stage.name == "Stage_7")
            {
                AudioManager.Instance.PlayLoseStageMandiri();
            }
        }
    }

    public void ResetPlacedToys()
    {
        placedToys.Clear();
    }

    public void HideUI()
    {
        if (winLoseUI != null)
            winLoseUI.SetActive(false);
    }

    
}
