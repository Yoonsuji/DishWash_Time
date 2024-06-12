using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextEffect : MonoBehaviour
{
    public TMP_Text dialogueText; 
    public float typingSpeed = 0.1f;

    private void Start()
    {
        string testSentence = "¾Ñ! ¾ß»ý ¶ûÈ£¶ûÀÌ ³ªÅ¸³µ´Ù!!!";
        StartCoroutine(TypeSentence(testSentence));
    }

    public IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = ""; 
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }
}
