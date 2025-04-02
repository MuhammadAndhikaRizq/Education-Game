using System.Collections;
using System.Collections.Generic;
using Unity.Properties;
using UnityEngine;

public class SchoolEquipment : DragAndDrop
{
    [SerializeField] private WinLoseStage8 bagList;
    [SerializeField] private GameObject insideBag;
    [SerializeField] private string bagTag = "Bag";

    private void Start()
    {
        bagList = FindObjectOfType<WinLoseStage8>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(bagTag))
        {
            Debug.Log("Collide with " + bagTag);
            bagList.insideBag.Add(gameObject);
            insideBag.SetActive(false);
            
        }
    }


}
