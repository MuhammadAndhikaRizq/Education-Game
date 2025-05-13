using UnityEngine;

public class Plane : MonoBehaviour
{
    [SerializeField] private string targetTag = "Target";
    [SerializeField] private WinLoseStage5 winLoseHandler; // reference to other script

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(targetTag))
        {
            winLoseHandler.TriggerWin(); // call method on other script
        }
    }

    
}