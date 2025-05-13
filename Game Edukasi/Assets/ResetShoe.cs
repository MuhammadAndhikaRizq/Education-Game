using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetShoe : MonoBehaviour
{
    public Vector3 startPosition;
    public GameObject shoe;


    // Start is called before the first frame update
    public void Start()
    {
        startPosition = shoe.transform.position;
    }

    // Update is called once per frame
    public void Reset()
    {
        shoe.transform.position = startPosition;
    }
}
