using UnityEngine;
using System.Collections;
using TMPro;
using System.Security.Cryptography;

public class door : MonoBehaviour
{
    public TextMeshProUGUI doorInteraction;
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
    public ComputerZone computerScript;
    private bool playerInRange = false;
    private bool dialogueStarted = false;

    void Awake()
    {
        //doorInteraction.gameObject.SetActive(false);
    }
    void Start()
    {
        HideAllDialogue();

    }
    void HideAllDialogue()
    {
        doorInteraction.gameObject.SetActive(false);
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
            playerInRange = true;
            Debug.Log("player in range");
            Debug.Log("Interaction omn!!");

            if (computerScript != null)
            {
                {
                    computerScript.HideComputerPrompt();
                }
            }
            
        }
    }
   
    void Update()
    {

        if(playerInRange && !dialogueStarted && Input.GetKeyDown(KeyCode.E))
        {
            dialogueStarted = true;

            doorInteraction.gameObject.SetActive(false);
            

            
            playermovement.StopMovement();
            Debug.Log("Dialogue index is 0");

            dialogueCoroutine = StartCoroutine(StartDialogueAfterDelay());
        }
        if (dialogueStarted && dialougeIndex >= 0 && Input.GetKeyDown(KeyCode.Space))
        {
           
            NextDialogue();
        }
        IEnumerator StartDialogueAfterDelay()
        {
            yield return new WaitForSeconds(dialogueDelay);
            doorInteraction.gameObject.SetActive(true);
            dialougeIndex = 1;
            playermovement.StopMovement();

            dialogueCoroutine = null;
        }
       
       

    }
    void NextDialogue()
    {
        if (dialougeIndex == 1)
        {
            doorInteraction.gameObject.SetActive(false);
            dialogue3.gameObject.SetActive(true);
            dialougeIndex = 2;
            Debug.Log("Dialogue Index is 2 now");

        }
        else if (dialougeIndex == 2)
        {
            dialogue3.gameObject.SetActive(false);
            dialogue4.gameObject.SetActive(true);
            dialougeIndex = 3;

        }
        else if (dialougeIndex == 3) //&&  !mumDialogueShown)
        {
            dialogue4.gameObject.SetActive(false);
            mumDialogue.gameObject.SetActive(true);
            dialougeIndex = 4;

        }
        else if (dialougeIndex == 4) //&& mumDialogueShown)
        {
            mumDialogue.gameObject.SetActive(false);
            mumDialogue1.gameObject.SetActive(true);
            mumDialogueShown = true;
            dialougeIndex = 5;

        }
        else if (dialougeIndex == 5)
        {
            mumDialogue1.gameObject.SetActive(false);
            sonDialogue.gameObject.SetActive(true);
            dialougeIndex = 6;
        }
        else if (dialougeIndex == 6)
        {
            sonDialogue.gameObject.SetActive(false);
            dialougeIndex = 7;
            playermovement.ResumeMovement();
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {

        if (!other.CompareTag("Player"))
        {
            return;
            playerInRange = false;
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
  






