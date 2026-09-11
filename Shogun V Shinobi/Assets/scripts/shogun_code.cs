using UnityEngine;

public class shogun : MonoBehaviour
{
    private Rigidbody2D shgogun;
    public float speed = 5f;
    public float jumpForce = 7f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        shgogun = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;

        if (Input.GetKey(KeyCode.D))
        {
            pos.x += speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            pos.x -= speed * Time.deltaTime;
        }

        transform.position = pos;
       
        //if (Input.GetKeyDown(KeyCode.W) && isGrounded)
        //{
        //    shgogun.linearVelocity = new Vector2(shgogun.linearVelocity.x, jumpForce);
        //}
    }
}
