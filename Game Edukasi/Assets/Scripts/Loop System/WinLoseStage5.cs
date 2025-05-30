using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLoseStage5 : MonoBehaviour
{
    [SerializeField] private GameObject winUI;
    [SerializeField] private GameObject loseUI;
    [SerializeField] private GameObject plane;
    [SerializeField] private Transform target;
    private Vector3 startPosition;

    public void Start()
    {
        startPosition = plane.transform.position;
    }

    public void StartFlyPlane()
    {
        StartCoroutine(MoveSmoothly(plane.transform, target.position, 1f));
    }

    public void TriggerWin()
    {
        StartCoroutine(ActiveWinUI());
    }

    private IEnumerator MoveSmoothly(Transform obj, Vector3 targetPos, float duration)
    {
        Vector3 startPos = obj.position;
        float elapsed = 0f;

        while (elapsed < duration)
        {
            elapsed += Time.deltaTime;
            float t = Mathf.Clamp01(elapsed / duration);
            obj.position = Vector3.Lerp(startPos, targetPos, t);
            yield return null;
        }

        obj.position = targetPos;
    }

    private IEnumerator ActiveWinUI()
    {
        yield return new WaitForSeconds(2);
        AudioManager.Instance.PlayEventSound();
        AudioManager.Instance.PlayWinStage5Sound();
        winUI.SetActive(true);
    }

    private IEnumerator ActiveLoseUI()
    {
        yield return new WaitForSeconds(2);
        loseUI.SetActive(true);
    }

    public void ResetPlane()
    {
        plane.transform.position = startPosition;
    }

   
}