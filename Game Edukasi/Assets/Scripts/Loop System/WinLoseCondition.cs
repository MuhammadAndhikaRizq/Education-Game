using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLoseCondition : MonoBehaviour
{
    [SerializeField] private List<GameObject> toys; // Daftar mainan yang harus masuk
    [SerializeField] private GameObject winLoseUI;
    [SerializeField] private string toysTag = "Toys";

    private HashSet<GameObject> placedToys = new HashSet<GameObject>(); // Menyimpan mainan yang sudah masuk

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(toysTag) && !placedToys.Contains(other.gameObject))
        {
            placedToys.Add(other.gameObject);

            if (placedToys.Count == toys.Count) // Jika semua mainan sudah masuk
            {
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
