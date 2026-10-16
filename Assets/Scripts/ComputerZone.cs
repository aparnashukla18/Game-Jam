using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ComputerZone : MonoBehaviour
{
    public GameObject computerText;
    private bool playerInRange = false;
    void Start()
    {
        computerText.gameObject.SetActive(false);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
            computerText.gameObject.SetActive(true);
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        playerInRange = false;
        computerText.gameObject.SetActive(false);
    }
    public void HideComputerPrompt()
    {
        computerText.gameObject.SetActive(false);
    }
    public void ShowComputerPrompt()
    {
        if (!playerInRange)
        {
            computerText.gameObject.SetActive(true);
        }
    }

    void Update()
    {
        ChangeWorld();
    }
    void ChangeWorld()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerInRange)
        {
            SceneManager.LoadScene(1);
        }
    }
}
