using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManeger : MonoBehaviour
{
    private Queue<string> Sentences;


    void Start()
    {
        Sentences = new Queue<string>();
    }

    public void StartDialogue (Dialogue dialogue)
    {
        Debug.Log("starting conversation with " + dialogue.name);

        Sentences.Clear();

        foreach(string sentence in dialogue.sentences)
        {
            Sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence ()
    {
        if (Sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = Sentences.Dequeue();
        Debug.Log(sentence);
    }
    void EndDialogue()
    {
        Debug.Log("end conversation");
    }
}
