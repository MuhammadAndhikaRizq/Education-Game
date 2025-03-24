using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    private Vector3 startPosition;
    private Vector3 offset;
    private Collider2D collider2d;
    public string destinationTag = "DropArea";
    private bool isDragging = false;

    void Awake()
    {
        collider2d = GetComponent<Collider2D>();
        startPosition = transform.position;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Mouse Click (PC)
        {
            CheckTouchOrClick(Input.mousePosition);
        }
        else if (Input.touchCount > 0) // Touch Input (Android)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                CheckTouchOrClick(touch.position);
            }
            else if (touch.phase == TouchPhase.Moved && isDragging)
            {
                transform.position = MouseWorldPosition(touch.position) + offset;
            }
            else if (touch.phase == TouchPhase.Ended && isDragging)
            {
                DropObject();
            }
        }

        if (Input.GetMouseButton(0) && isDragging) // Dragging with mouse
        {
            transform.position = MouseWorldPosition(Input.mousePosition) + offset;
        }
        if (Input.GetMouseButtonUp(0) && isDragging) // Mouse release
        {
            DropObject();
        }
    }

    private void CheckTouchOrClick(Vector3 inputPosition)
    {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(inputPosition), Vector2.zero);
        if (hit.collider != null && hit.collider.gameObject == gameObject)
        {
            offset = transform.position - MouseWorldPosition(inputPosition);
            isDragging = true;
        }
    }

    private void DropObject()
    {
        isDragging = false;
        collider2d.enabled = false;
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, Vector2.zero);

        if (hitInfo.collider != null && hitInfo.transform.CompareTag(destinationTag))
        {
            transform.position = hitInfo.transform.position + new Vector3(0, 0, -0.01f);
        }

        collider2d.enabled = true;
    }

    private Vector3 MouseWorldPosition(Vector3 inputPosition)
    {
        inputPosition.z = Camera.main.WorldToScreenPoint(transform.position).z;
        return Camera.main.ScreenToWorldPoint(inputPosition);
    }

    public void ResetPosition()
    {
        transform.position = startPosition;
    }
}
