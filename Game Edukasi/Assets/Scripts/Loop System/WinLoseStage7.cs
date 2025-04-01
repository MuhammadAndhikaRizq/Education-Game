using System.Collections.Generic;
using UnityEngine;

public class WinLoseStage7 : MonoBehaviour
{
    [SerializeField] private List<GameObject> trashs;
    [SerializeField] private GameObject winUI;
    [SerializeField] private string broomTag = "Broom";
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag(broomTag))
        {
            DestroyImmediate(other.gameObject);
        }
    }

}