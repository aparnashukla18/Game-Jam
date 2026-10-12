using UnityEngine;
using UnityEngine.SceneManagement;


public class ComputerScene : MonoBehaviour
{
   
    void Start()
    {
        
    }

    void Update()
    {
        ChangeWorld();
    }
    void ChangeWorld()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {

            SceneManager.LoadScene (1);
        }
    }
}
