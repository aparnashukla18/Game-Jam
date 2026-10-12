using NUnit.Framework.Constraints;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public playermovement playermovement;
    public GameObject StartButton;
    void Start()
    {
       playermovement.enabled = false;
        StartButton.SetActive(true);
    }
    public void GameReady()
    {
        StartButton.SetActive(false);
        playermovement.enabled = true;
    }

    
    
}
