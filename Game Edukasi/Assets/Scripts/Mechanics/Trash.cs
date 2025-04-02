using System.Collections;
using UnityEngine;

public class Trash : MonoBehaviour
{
    [SerializeField] private string broomTag = "Broom";
    [SerializeField] private WinLoseStage7 removeList;
    private bool isBeingDestroyed = false;

    private void Start()
    {
        if (removeList == null)
        {
            removeList = FindObjectOfType<WinLoseStage7>();
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(broomTag))
        {
            Debug.Log("Collide with " + broomTag);
            StartCoroutine(DestroyTrash()); // Perbaikan nama method
        }
    }

    IEnumerator DestroyTrash()
    {
        if (isBeingDestroyed) yield break;
        isBeingDestroyed = true;

        yield return new WaitForSeconds(2);

        removeList.trashs.Remove(gameObject);
        removeList.trashs.RemoveAll(item => item == null);
        gameObject.transform.SetParent(null);
        removeList.WinCondition();

        Destroy(gameObject); // Ganti DestroyImmediate dengan Destroy
    }
}