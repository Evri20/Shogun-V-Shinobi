using UnityEngine;

public class AttackHitbox : MonoBehaviour
{
    public int damage = 1; // Amount of damage this hitbox will deal
    private bool hasHit = false; // To prevent multiple hits in a single attack
    private Collider2D hitboxCollider;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hitboxCollider = GetComponent<Collider2D>();
        hitboxCollider.enabled = false; // Disable the hitbox initially only turns on when the attack animation is playing
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (hasHit) return; // If already hit, do nothing
        
        if (other.CompareTag("Player")) // Check if the other object has the "Player" tag
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

    public void EnableHitbox()
    {
        hasHit = false; // Reset hit status for the new attack
        hitboxCollider.enabled = true; // Enable the hitbox when the attack animation starts
    }

    public void DisableHitbox()
    {
        hitboxCollider.enabled = false; // Disable the hitbox when the attack animation ends
    }

}
