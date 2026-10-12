using TMPro;
using UnityEngine;
using System.Collections;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI dialogueText;
    public float typingSpeed = 0.2f;

    public string[] dialogueSentences;
    private string fullText;
    private int currentSentenceIndex = 0;

    private Coroutine typingCoroutine;
    private bool isTyping = false;
    void Start()
    {
        dialogueText.gameObject.SetActive(false);
        fullText = dialogueSentences[currentSentenceIndex];
        dialogueText.text = "";

        typingCoroutine = StartCoroutine(TypeText());
    }
    IEnumerator TypeText()
    {
        isTyping = true;
       for (int i = 0; i < fullText.Length; i++)
        {
            dialogueText.text += fullText[i];
            yield return new WaitForSeconds(typingSpeed);
        }
        isTyping = false;
        typingCoroutine = null;
    }

    void completeCurrentSentence()
    {
        if (typingCoroutine != null)
        {
            StopCoroutine(typingCoroutine);
            typingCoroutine = null;
        }
        //dialogueText.text = sentences[currentSentenceIndex];
    }

}
