using UnityEngine;
using System.Collections;
using TMPro;

public class door : MonoBehaviour
{
    public TextMeshProUGUI dialogue3;
    public TextMeshProUGUI dialogue4;
    public TextMeshProUGUI mumDialogue;
    public TextMeshProUGUI mumDialogue1;
    public TextMeshProUGUI sonDialogue;
    public int dialougeIndex = 0;
    public float dialogueDelay = 1f;
    private Coroutine dialogueCoroutine;
    bool mumDialogueShown = false;
    public playermovement playermovement;


    void Start()
    {
        HideAllDialogue();

    }
    void HideAllDialogue()
    {
        dialogue3.gameObject.SetActive(false);
        dialogue4.gameObject.SetActive(false);
        mumDialogue.gameObject.SetActive(false);
        mumDialogue1.gameObject.SetActive(false);
        sonDialogue.gameObject.SetActive(false);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && dialougeIndex==0)
        {
            dialogueCoroutine = StartCoroutine(StartDialogueAfterDelay());
            playermovement.StopMovement();
        }
    }
    IEnumerator StartDialogueAfterDelay()
    {
        yield return new WaitForSeconds(dialogueDelay);
        dialogue3.gameObject.SetActive(true);
        dialougeIndex = 1;
        playermovement.StopMovement();

        dialogueCoroutine = null;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (dialougeIndex == 1)
            {
                dialogue3.gameObject.SetActive(false);
                dialogue4.gameObject.SetActive(true);
                dialougeIndex = 2;
                
            }
            else if (dialougeIndex == 2)
            {
                dialogue4.gameObject.SetActive(false);
                mumDialogue.gameObject.SetActive(true);
                dialougeIndex = 3;
                
            }
            else if (dialougeIndex == 3) //&&  !mumDialogueShown)
            {
                mumDialogue.gameObject.SetActive(false);
                mumDialogue1.gameObject.SetActive(true);
                mumDialogueShown = true;
                dialougeIndex = 4;
                
            }
            else if (dialougeIndex == 4) //&& mumDialogueShown)
            {
                mumDialogue1.gameObject.SetActive(false);
                sonDialogue.gameObject.SetActive(true);
                dialougeIndex = 5;
               
            }
            else if (dialougeIndex == 5)
            {
                sonDialogue.gameObject.SetActive(false);
                dialougeIndex = 6;
                playermovement.ResumeMovement();
            }
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (dialogueCoroutine != null)
            {
                StopCoroutine(dialogueCoroutine);
                dialogueCoroutine = null;
            }
            HideAllDialogue();
            dialougeIndex = 0;
            playermovement.enabled = true;

        }
    }





}
