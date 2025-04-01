using UnityEngine;

public class Broom : DragAndDrop
{
    [SerializeField] private Animator animator;
    public bool isPlay = false;


    private void OnEnable()
    {
        isPlay = true;
        animator.SetBool("IsPlay", isPlay);
    }

    private void OnDisable()
    {
        isPlay = false;
        animator.SetBool("IsPlay", isPlay);
    }
}