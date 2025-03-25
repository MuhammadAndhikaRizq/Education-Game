using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveCondition : MonoBehaviour
{
    public GameObject girl;
    public GameObject boy;

    public void BoyActive(bool active)
    {
        boy.SetActive(active);
    }

    public void GirlActive(bool active)
    {
        girl.SetActive(active);
    }
}
