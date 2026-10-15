using UnityEngine;

public class AiScript : MonoBehaviour
{
    public GameObject AIPanel;
    public GameObject SecAssignment;
    public GameObject firstPanel;
    void Start()
    {
        AIPanel.SetActive(false);
        SecAssignment.SetActive(false);
       // firstPanel.SetActive(false);
    }
    public void openAi()
    {
        AIPanel.SetActive(true);
    }
    public void ChangePanel()
    {
        AIPanel.SetActive(false);
        //firstPanel.SetActive(false);
       SecAssignment.SetActive(true);

    }


    void Update()
    {
        
    }
}
