using UnityEngine;
using TMPro;

public class ComputerZone : MonoBehaviour
{
    public TextMeshProUGUI computerText;
    void Start()
    {
        computerText.gameObject.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            computerText.gameObject.SetActive(true);
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            computerText.gameObject.SetActive(false);
        }
    }

}
