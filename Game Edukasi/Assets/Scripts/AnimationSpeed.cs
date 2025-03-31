using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSpeed : MonoBehaviour
{
    public Animator animatorSpeed;
    // Start is called before the first frame update
    void Awake()
    {
        animatorSpeed.SetFloat("Speed", .2f);
    }

    
}
