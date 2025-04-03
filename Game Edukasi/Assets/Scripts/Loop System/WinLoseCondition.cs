using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLoseCondition : MonoBehaviour
{
    [SerializeField] protected List<GameObject> items; // Daftar mainan yang harus masuk
    [SerializeField] protected GameObject winLoseUI;
    [SerializeField] protected string toysTag = "Toys";

    protected HashSet<GameObject> placedToys = new HashSet<GameObject>(); // Menyimpan mainan yang sudah masuk

    protected virtual void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(toysTag) && !placedToys.Contains(other.gameObject))
        {
            placedToys.Add(other.gameObject);

            if (placedToys.Count == items.Count) // Jika semua mainan sudah masuk
            {
                AudioManager.Instance.PlayEventSound();
                winLoseUI.SetActive(true);
            }
        }
    }

    // void OnTriggerExit2D(Collider2D other) // Jika mainan keluar dari area, hapus dari daftar
    // {
    //     if (other.CompareTag(toysTag) && placedToys.Contains(other.gameObject))
    //     {
    //         placedToys.Remove(other.gameObject);
    //         winLoseUI.SetActive(false); // Jika ada yang keluar, jangan tampilkan win UI
    //     }
    // }

    
}
