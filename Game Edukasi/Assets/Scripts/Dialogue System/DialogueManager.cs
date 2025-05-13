using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    public TMP_Text dialogueText;
    public GameObject winUI;
    public SpriteRenderer spriteRenderer;
    private Queue<string> sentences;

    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogueAuto()
    {
        sentences.Clear();

        // Tentukan isi dialog dan audio berdasarkan sprite
        if (spriteRenderer.sprite.name == "1")
        {
            AudioManager.Instance.PlayBoyTalk();
            sentences.Enqueue("Nama Saya Andhika.");
            sentences.Enqueue("Ibu Saya Kireina.");
            sentences.Enqueue("Ayah Saya Rizki.");
        }
        else
        {
            AudioManager.Instance.PlayGirlTalk();
            sentences.Enqueue("Nama Saya Jasmien.");
            sentences.Enqueue("Ibu Saya Nabila.");
            sentences.Enqueue("Ayah Saya Raka.");
        }

        StartCoroutine(PlayDialogueSequence());
    }

    IEnumerator PlayDialogueSequence()
    {
        while (sentences.Count > 0)
        {
            string sentence = sentences.Dequeue();
            yield return StartCoroutine(TypeSentence(sentence));
            yield return new WaitForSeconds(1.5f); // jeda antar kalimat
        }

        EndDialogue(); // otomatis di akhir
    }

    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(0.03f); // kecepatan ketik
        }
    }

    public void EndDialogue()
    {
        AudioManager.Instance.PlayEventSound();
        AudioManager.Instance.PlayWinStage5Sound();
        FindObjectOfType<ButtonActivetedCondition>().ActivateWinUI5();
    }

    
}
