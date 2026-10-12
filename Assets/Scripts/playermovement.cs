using System.Diagnostics.CodeAnalysis;
using UnityEngine;
using UnityEngine.UIElements;

public class playermovement : MonoBehaviour
{
    public float speed = 1f;

    private Vector2 targetposition;
    private bool ismoving;
    private Rigidbody rb;

    private void Start()
    {
        ismoving = false;
        rb = GetComponent<Rigidbody>();

    }




    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mouseposition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            targetposition = new Vector2(mouseposition.x, transform.position.y);
            ismoving = true;

        }
        if (ismoving == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, targetposition, speed * Time.deltaTime);


        }




    }
}
