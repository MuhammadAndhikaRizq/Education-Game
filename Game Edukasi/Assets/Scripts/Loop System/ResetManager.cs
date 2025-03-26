using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetManager : MonoBehaviour
{
    // public Animator throwAnimation;

    public void ResetAllDraggableObjects()
    {
        DragAndDrop[] draggableObjects = FindObjectsOfType<DragAndDrop>();
        foreach (var obj in draggableObjects)
        {
            obj.ResetPosition();
        }
    }

    public void NonActiveUI(GameObject gameObject)
    {
        gameObject.SetActive(false);

    }
}
