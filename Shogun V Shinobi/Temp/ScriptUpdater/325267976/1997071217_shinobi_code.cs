using UnityEngine;

public class shinobi_code : MonoBehaviour
    {
    private Rigidbody2D shinobi;
    public float speed = 5f;
    public float jumpForce = 7f;
    public Transform groundCheck;      // an empty GameObject placed at the character's feet
    public float groundCheckRadius = 0.1f;
    public LayerMask groundLayer;      // set this to whatever layer your ground/platforms are on
    private bool isGrounded;
    
    public Animator animator;          // reference to the Animator component
    public Transform otherCharacter;   // reference to the other character's transform
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
     void Start()
    {
        shinobi = GetComponent<Rigidbody2D>();
    }
    

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
        animator.SetBool("isJumping", !isGrounded); // Set the "isJumping" parameter based on whether the character is grounded
        animator.SetFloat("verticalVelocity", shinobi.linearVelocity.y); // Set the "verticalVelocity" parameter to the character's vertical velocity
        
        Vector2 pos = transform.position;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            pos.x += speed * Time.deltaTime;
        }
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            pos.x -= speed * Time.deltaTime;
            FlipTowardsOpponent();
        }

        transform.position = pos;

        if (Input.GetAxis("Horizontal") != 0)
        {
            animator.SetBool("isRunning", true);
        }
        else
        {
            animator.SetBool("isRunning", false);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded)
        {
            shinobi.linearVelocity = new Vector2(shinobi.linearVelocity.x, jumpForce);
        }

        FlipTowardsOpponent();
    
    }

    void FlipTowardsOpponent()
    {
        if(transform.position.x > otherCharacter.position.x)
        {
            transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
        }
        else
        {
            transform.localScale = new Vector3(-Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
        }

    }
    
    
    }