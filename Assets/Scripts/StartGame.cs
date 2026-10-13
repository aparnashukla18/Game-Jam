using NUnit.Framework.Constraints;
using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour
{
    public playermovement playermovement;
    public GameObject StartButton;
    public Dialogue dialogue;
    public float dialogueDelay = 3f;
    void Start()
    {
       playermovement.enabled = false;
        StartButton.SetActive(true);
        dialogue.enabled = false;
    }
    public void GameReady()
    {
        StartButton.SetActive(false);
        dialogue.enabled = true;
        StartCoroutine(StartDialogueAfterDelay());

    }
    IEnumerator StartDialogueAfterDelay()
    {
        yield return new WaitForSeconds(dialogueDelay);
        playermovement.enabled = true;
        //dialogue.enabled = false;
    }



}
