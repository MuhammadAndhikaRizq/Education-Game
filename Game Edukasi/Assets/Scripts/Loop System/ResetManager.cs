using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetManager : MonoBehaviour
{
   public void ResetAllDraggableObjects()
    {
        DragAndDrop[] draggableObjects = FindObjectsOfType<DragAndDrop>();
        foreach (var obj in draggableObjects)
        {
            obj.ResetPosition();
        }
    }
}
