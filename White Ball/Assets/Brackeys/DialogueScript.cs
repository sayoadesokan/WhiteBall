using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class DialogueScript : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;
    public Animator animator; 

    private Queue<string> sentences; 
    void Start()
    {
        sentences = new Queue<string>(); 
    }

    public void StartDialogue(Dialogue dialogue)
    {
        animator.SetBool("intOpen", true); 

        Debug.Log("Starting Conversation with " + dialogue.name);

        nameText.text = dialogue.name;  

        sentences.Clear(); 

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence); 
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if(sentences.Count == 0)
        {
            EndDialogue();
            return; 
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines(); 
        StartCoroutine(TypeSentence(sentence)); 
    }

    IEnumerator TypeSentence (string sentence)
    {
        dialogueText.text = "";
        foreach(char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null; 
        }
    }

    void EndDialogue()
    {
        animator.SetBool("intOpen", false);
        Debug.Log("End of Conversation"); 
    }
}
