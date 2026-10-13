using TMPro;
using UnityEngine;
using System.Collections;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI dialogue1;
    public TextMeshProUGUI dialogue2;
    public float typingSpeed = 0.05f;
    public float dialogueSpeed = 2f;
    public float dialogueDelay = 3f;
    private int dialougeIndex = 0;
    public playermovement playermovement;

    void Start()
    {
       dialogue1.gameObject.SetActive(false);
       dialogue2.gameObject.SetActive(false);

        StartCoroutine(StartDialogueAfterDelay());
    }
   
    IEnumerator StartDialogueAfterDelay()
    {
        yield return new WaitForSeconds(dialogueDelay);
        playermovement.enabled = false;
        dialogue1.gameObject.SetActive(true);
        dialougeIndex = 1;

        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (dialougeIndex == 1)
            {
                dialogue1.gameObject.SetActive(false);
                dialogue2.gameObject.SetActive(true);

                dialougeIndex = 2;
            }
            else if (dialougeIndex == 2)
            {
                StopAllCoroutines();
                dialogue2.gameObject.SetActive(false);
                dialougeIndex = 3;
                playermovement.enabled = true;
            }
        }

    }

}