using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
    [SerializeField] private List<GameObject> toys;
    [SerializeField] private GameObject winUI;
    [SerializeField] private string toysTag = "Toys";


    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag(toysTag))
        {
            List<GameObject> newToys = new List<GameObject>();

            foreach (GameObject toy in toys)
            {
                newToys.Add(toy);
                if(newToys.Count == 3)
                    winUI.SetActive(true);
            }
        }
    }
}
