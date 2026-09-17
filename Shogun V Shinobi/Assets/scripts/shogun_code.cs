using UnityEngine;

public class shogun : MonoBehaviour
{
    private Rigidbody2D shgogun;
    public float speed = 5f;
    public float jumpForce = 7f;
    
    public Transform groundCheck;      // an empty GameObject placed at the character's feet
    public float groundCheckRadius = 0.1f;
    public LayerMask groundLayer;      // set this to whatever layer your ground/platforms are on
    private bool isGrounded;
    
    public Transform otherCharacter;   // reference to the other character's transform
    
    public Animator animator;          // reference to the Animator component
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        shgogun = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
        animator.SetBool("isJumping", !isGrounded); // Set the "isJumping" parameter based on whether the character is grounded
        animator.SetFloat("verticalVelocity", shgogun.linearVelocity.y); // Set the "verticalVelocity" parameter to the character's vertical velocity
        
        Vector2 pos = transform.position;

        if (Input.GetKey(KeyCode.D))
        {
            pos.x += speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            pos.x -= speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            animator.SetBool("isRunning", true);
        }
        else
        {
            animator.SetBool("isRunning", false);
        }

        transform.position = pos;
       
        if (Input.GetKeyDown(KeyCode.W) && isGrounded)
        {
            shgogun.linearVelocity = new Vector2(shgogun.linearVelocity.x, jumpForce);
        }

        FlipTowardsOpponent();
    }

    void FlipTowardsOpponent()
    {
        if(transform.position.x < otherCharacter.position.x)
        {
            transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
        }
        else
        {
            transform.localScale = new Vector3(-Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
        }
    }

}
