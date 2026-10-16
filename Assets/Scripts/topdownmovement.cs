using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class inscreenplayermovement : MonoBehaviour
{
    public float speed = 1f;
    Animator anim;


    void Start()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            Debug.Log("xx");
            anim.SetBool("walkingSideways", true);
            transform.Translate(Vector2.right * Input.GetAxis("Horizontal") * speed * Time.deltaTime);
            
        }
        else if (Input.GetAxis("Vertical") > 0)
        {
            Debug.Log("yy");
            anim.SetBool("walkingUp", true);
            transform.Translate(Vector2.up * Input.GetAxis("Vertical") * speed * Time.deltaTime);
            
        }

        else if (Input.GetAxis("Vertical") < 0) ;
        {
            Debug.Log("zz");

            anim.SetBool("walkingDown", true);
            transform.Translate(Vector2.up * Input.GetAxis("Vertical") * speed * Time.deltaTime);

        }
    }
}
