using UnityEngine;

public class Broom : DragAndDrop
{
    [SerializeField] private Animator animator;
    public bool isPlay = false;

    protected override void Update()
    {
        DisableAnimation();
        InputSystem();
    }

    protected override void InputSystem()
    {
        if (Input.GetMouseButtonDown(0)) // Mouse Click (PC)
        {
            CheckTouchOrClick(Input.mousePosition);
            EnableAnimation();
        }
        else if (Input.touchCount > 0) // Touch Input (Android)
        {
            Touch touch = Input.GetTouch(0);
            EnableAnimation();
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
            EnableAnimation();
        }
        if (Input.GetMouseButtonUp(0) && isDragging) // Mouse release
        {
            DropObject();
            EnableAnimation();
        }

    }
    private void EnableAnimation()
    {
        isPlay = true;
        animator.SetBool("IsPlay", isPlay);
    }

    private void DisableAnimation()
    {
        isPlay = false;
        animator.SetBool("IsPlay", isPlay);
    }
}