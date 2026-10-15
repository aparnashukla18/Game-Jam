using UnityEngine;
using UnityEngine.SceneManagement;

public class error : MonoBehaviour
{
    public GameObject Player;

    public health healthcount;

    void Start()
    {
        healthcount.Health();

    }


    void Update()
    {


    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("error");
        if (collision.gameObject == Player)
        {
            Debug.Log("error");
            healthcount.healthcount++;
            if (healthcount.healthcount == 3)
            {
                SceneManager.LoadScene(2);
            }


        }
        

    }   
}
