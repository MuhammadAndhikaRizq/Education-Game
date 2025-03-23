using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetObject : MonoBehaviour
{
     public void ResetPosition(GameObject target)
    {
        ObjectPosition objPost = target.GetComponent<ObjectPosition>(); // Ambil komponen ObjectPosition
        
        if (objPost != null) // Pastikan komponen ada
        {
            target.transform.position = objPost.GetOriginalPosition(); // Set posisi kembali ke awal
        }
        else
        {
            Debug.LogWarning("ObjectPosition tidak ditemukan di " + target.name);
        }
    }
}
