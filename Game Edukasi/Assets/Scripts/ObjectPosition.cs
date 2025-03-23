using UnityEngine;

public class ObjectPosition : MonoBehaviour
{
    private Vector3 originalPosition; // Simpan posisi awal

    void Start()
    {
        originalPosition = transform.position; // Simpan posisi awal saat game mulai
    }

    public Vector3 GetOriginalPosition()
    {
        return originalPosition; // Mengembalikan posisi awal
    }
}