using UnityEngine;

public class AttackHitbox : MonoBehaviour
{
    public int damage = 1; // Amount of damage this hitbox will deal
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the other object has a Health component
        health_code targetHealth = other.GetComponent<health_code>();
        if (targetHealth != null)
        {
            // If it does, apply damage
            targetHealth.TakeDamage(damage);
        }
    }

}
