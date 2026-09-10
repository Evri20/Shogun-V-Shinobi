using UnityEngine;

public class shinobi_code : MonoBehaviour
    {
    private Rigidbody2D shinobi;
    public float speed = 5f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        shinobi = GetComponent<Rigidbody2D>();
    }
    

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            pos.x += speed * Time.deltaTime;
        }
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            pos.x -= speed * Time.deltaTime;
        }

        transform.position = pos;
    }

    }