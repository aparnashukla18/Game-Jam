using System.Diagnostics.CodeAnalysis;
using UnityEngine;
using UnityEngine.UIElements;

public class playermovement : MonoBehaviour
{
    public float speed = 1f;
    public Animator animator;

    private Vector2 targetposition;
    private bool ismoving;
    private Rigidbody rb;
    public SpriteRenderer spriteRenderer;   
    private void Start()
    {
        ismoving = false;
        rb = GetComponent<Rigidbody>();

        if (animator == null)
        {
            animator = GetComponentInChildren<Animator>();
        }
        if(animator!= null)
        {
            animator.SetFloat("Speed", 0f);
        }

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
        if (Vector2.Distance(transform.position, targetposition) < 0.1f)
        {
            transform.position = new Vector3(targetposition.x, transform.position.y, transform.position.z);
            ismoving = false;
            SetIdle();
        }
        if(ismoving == true)
        {
            animator.SetFloat("Speed", 1f);
        }


        if(ismoving)
        {
            if (targetposition .x < transform.position.x)
            {
                transform.localScale = new Vector3(-3, 3, 3);
            }
            else if ( targetposition.x > transform.position.x)
            {
                transform.localScale = new Vector3(3, 3, 3);
            }
        }

    }
    void SetIdle()
    {
        animator.SetFloat("Speed", 0f);
    }
}
