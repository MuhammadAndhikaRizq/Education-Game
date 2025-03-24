using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetManager : MonoBehaviour
{
    private Vector3 startPosition;

    void Start()
    {
        // Store the initial position and active state
        startPosition = transform.position;
    }

    public void ResetMenuUI()
    {
        // Reset position
        transform.position = startPosition;

        // Reset visibility
        // menuPanel.SetActive(startActive);
    }
}
