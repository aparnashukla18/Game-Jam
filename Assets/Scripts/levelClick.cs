using UnityEngine;
using UnityEngine.UI;

public class levelClick : MonoBehaviour
{
    public GameObject levelPanel;
    public Image pcPanel;
    void Start()
    {
        if(levelPanel != null)
        {
            levelPanel.SetActive(false);
            pcPanel.gameObject.SetActive(true);
        }
        else
        {
            Debug.LogError("Inspector main button assign nhi hai");
        }
    }

    
    public void OnClick()
    {
       if(levelPanel != null)
       {
            levelPanel.SetActive(true);
            pcPanel.gameObject.SetActive(false);
            Debug.Log("Inspector main assign ho gya");
       }
       else
        {
            Debug.Log("NHii hua ");
        }
    }
}
