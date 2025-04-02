using System.Collections;
using System.Collections.Generic;
using Unity.Properties;
using UnityEngine;

public class SchoolEquipment : DragAndDrop
{
    [SerializeField] private WinLoseStage8 bagList;
    [SerializeField] private GameObject insideBag;

    void Start()
    {
        bagList = FindObjectOfType<WinLoseStage8>();
        destinationTag = "Bag";
    }

    protected override void DropObject()
    {
        isDragging = false;
        collider2d.enabled = false;
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, Vector2.zero);

        if (hitInfo.collider != null && hitInfo.transform.CompareTag(destinationTag))
        {
            bagList.insideBag.Add(gameObject);
            insideBag.SetActive(false);
        }

        collider2d.enabled = true;
    }


}
