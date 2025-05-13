using UnityEngine;

public class ResetManager : MonoBehaviour
{
    public void ResetAllDraggableObjects()
    {
        // Reset posisi objek draggable
        DragAndDrop[] draggableObjects = FindObjectsOfType<DragAndDrop>();
        foreach (var obj in draggableObjects)
        {
            obj.ResetPosition();
        }

        // Reset kondisi Win/Lose
        WinLoseCondition winLoseCondition = FindObjectOfType<WinLoseCondition>();
        if (winLoseCondition != null)
        {
            winLoseCondition.ResetPlacedToys();
            winLoseCondition.HideUI();
        }
    }

    public void NonActiveUI(GameObject gameObject)
    {
        gameObject.SetActive(false);
    }

    public void ActiveUI(GameObject gameObject)
    {
        gameObject.SetActive(true);
    }
}
