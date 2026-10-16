using UnityEngine;

public class SeeClick : MonoBehaviour
{
    public GameObject tryPanel;
    public GameObject levelPanel;
    void Start()
    {
        
    }

   
    public void OncLick()
    {
        tryPanel.SetActive(false);
        levelPanel.SetActive(true); 
    }
}
