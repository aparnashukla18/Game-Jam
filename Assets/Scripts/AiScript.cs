using UnityEngine;

public class AiScript : MonoBehaviour
{
    public GameObject AIPanel;
    public GameObject SecAssignment;
    public GameObject firstPanel;
    public GameObject tryPanel;
    void Start()
    {
        if (AIPanel != null)
        {
           AIPanel.SetActive(false);
        }
        if (SecAssignment != null)
        {
            SecAssignment.SetActive(false);
        }
    }
    public void openAi()
    {
        if(AIPanel  != null)
        {
            AIPanel.SetActive(true);
        }
    }
    public void ChangePanel()
    {
        if(AIPanel !=null)
        {
            AIPanel.SetActive(false);
        }
        if(firstPanel != null)
        {
            firstPanel.SetActive(false);
        }
        if(tryPanel != null)
        {
            tryPanel.SetActive(false);
        }
        if(SecAssignment != null)
        {
            SecAssignment.SetActive(true);
            Debug.Log("Sec Panel open ho gya");
        }
        else
        {
            Debug.Log("Nhiii Assign hai");
        }

    }


    void Update()
    {
        
    }
}
