using UnityEngine;

public class AiScript : MonoBehaviour
{
    public GameObject AIPanel;
    public GameObject SecAssignment;
    void Start()
    {
        AIPanel.SetActive(true);
        SecAssignment.SetActive(false);
    }
    public void ChangePanel()
    {
        AIPanel.SetActive(false);
        SecAssignment.SetActive(true);

    }


    void Update()
    {
        
    }
}
