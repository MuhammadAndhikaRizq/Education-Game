using UnityEngine;

public class Chemicals : DragAndDrop
{
    protected override void CheckTouchOrClick(Vector3 inputPosition)
    {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(inputPosition), Vector2.zero);
        if (hit.collider != null && hit.collider.gameObject == gameObject)
        {
            offset = transform.position - MouseWorldPosition(inputPosition);
            isDragging = true;
        }
    }
}