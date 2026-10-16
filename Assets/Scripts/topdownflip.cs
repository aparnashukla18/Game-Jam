using UnityEngine;

public class topdownflip : MonoBehaviour
{
    public float speed = 1f;


    void Start()
    {

    }


    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.Translate(new Vector2(-horizontal, -vertical) * speed * Time.deltaTime);
    }
}
