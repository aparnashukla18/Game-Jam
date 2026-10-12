using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject StartPanel;
    public GameObject StartButton;
    void Start()
    {
        StartPanel.SetActive(true);
        StartButton.SetActive(true);
    }
    public void GameReady()
    {
        StartPanel.SetActive(false);
        StartButton.SetActive(false);
    }

    
    
}
