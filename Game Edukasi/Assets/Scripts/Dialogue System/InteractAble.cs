using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractAble : MonoBehaviour
{
    // public Dialogue dialogue;

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogueAuto();
    }
}
