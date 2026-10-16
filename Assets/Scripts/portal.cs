using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class portal : MonoBehaviour
{
    public GameObject Player;
    public int time = 1;

    public SpriteRenderer portalsprite;
    public Collider2D portalcollider; 

    void Start()
    {
        portalsprite= GetComponent<SpriteRenderer>();
        portalcollider = GetComponent<Collider2D>();

        if (portalsprite ==null ||  portalcollider == null )
        {
            Debug.Log("assign");
            return;
        }
        portalsprite.enabled = false;
        portalcollider.enabled = false;

        StartCoroutine(Portal());
       
    }
    IEnumerator Portal()
    {
        yield return new WaitForSeconds(time);

        portalsprite.enabled = true;
        portalcollider.enabled = true;

        Debug.Log("portal ids visible");
        


    }

   
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == Player)
        {
            Destroy (Player);
            SceneManager.LoadScene(4);
        }
    }
}
