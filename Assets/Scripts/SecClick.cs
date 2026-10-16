using UnityEngine;

public class SecClick : MonoBehaviour
{
    public GameObject sumbitButton;
    public GameObject tryPanel;
    public GameObject SecPanel;
    void Start()
    {
        
    }

   
    public void SecOnClick()
    {
        SecPanel.SetActive(false);
        tryPanel.SetActive(true);

    }
}
