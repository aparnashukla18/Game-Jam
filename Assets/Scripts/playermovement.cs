using System.Diagnostics.CodeAnalysis;
using UnityEngine;
using UnityEngine.UIElements;

public class playermovement : MonoBehaviour
{
    public float speed = 1f;
    public Animator animator;

    private Vector2 targetposition;
    private bool ismoving;
    private bool canMove = true;
    private Rigidbody rb;
    public SpriteRenderer spriteRenderer;
    public GameObject movingHere;
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
        if(!canMove)
        {
            ismoving = false;
            UpdateAnimation();
            return;
        }
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
            UpdateAnimation();
            
        }
        if(ismoving == true)
        {
            animator.SetFloat("Speed", 1f);
        }


        if(ismoving)
        {
            if (targetposition .x < transform.position.x)
            {
                transform.localScale = new Vector3(-1.5f, 1.5f,1.5f);
            }
            else if ( targetposition.x > transform.position.x)
            {
                transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
            }
        }

    }
    public void UpdateAnimation()
    {
        if(animator != null)
        {
            animator.SetFloat("Speed", ismoving && canMove ? 1f : 0f);
        }
    }
    public void StopMovement()
    {
        canMove = false;
        ismoving = false;
        UpdateAnimation();
    }
    public void ResumeMovement()
    {
        canMove = true;
        UpdateAnimation();
    }


}
