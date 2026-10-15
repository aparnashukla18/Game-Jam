using UnityEngine;

public class inscreenplayermovement : MonoBehaviour
{
    public float speed = 1f;


    void Start()
    {

    }


    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            transform.Translate(Vector2.right * Input.GetAxis("Horizontal") * speed * Time.deltaTime);
        }
        if (Input.GetAxis("Vertical") != 0)
        {
            transform.Translate(Vector2.up * Input.GetAxis("Vertical") * speed * Time.deltaTime);
        }
    }
}
