using UnityEngine;

public class SecClick : MonoBehaviour
{
    public GameObject sumbitButton;
    public GameObject levels;
    public GameObject SecPanel;
    void Start()
    {
        
    }

   
    public void SecOnClick()
    {
        SecPanel.SetActive(false);
        levels.SetActive(true);

    }
}
