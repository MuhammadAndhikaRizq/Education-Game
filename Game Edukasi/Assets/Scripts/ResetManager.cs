using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetManager : MonoBehaviour
{
    private Dictionary<GameObject, Vector3> startPositions = new Dictionary<GameObject, Vector3>();

    void Start()
    {
        // Find all objects with the "Resettable" tag and store their positions
        GameObject[] resettableObjects = GameObject.FindGameObjectsWithTag("ResetAble");

        foreach (GameObject obj in resettableObjects)
        {
            startPositions[obj] = obj.transform.position; // ✅ Stores the correct object's position
        }
    }

    public void ResetObjects()
    {
        foreach (var obj in startPositions)
        {
            if (obj.Key != null) // Check if the object still exists
            {
                obj.Key.transform.position = obj.Value; // ✅ Reset to stored position
            }
        }
    }
}
