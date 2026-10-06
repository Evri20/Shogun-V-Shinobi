using UnityEngine;

public class health_code : MonoBehaviour
{
    public int maxhealth = 5;
    public int currentHealth;
    public HeartsUI_code heartsUI;
    public string opponentWinScene;
    public Animator animator;
    public MonoBehaviour movementScript;
    
    public AudioSource audioSource;          // reference to the AudioSource component
    public AudioClip deathSound; // Sound to play when the player dies
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth = maxhealth;
        heartsUI.UpdateHearts(currentHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth < 0) currentHealth = 0;
        heartsUI.UpdateHearts(currentHealth);

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        if (animator != null)
        {
            animator.SetTrigger("Die");
        }

        if (audioSource != null && deathSound != null)
        {
            audioSource.PlayOneShot(deathSound, 2f); // Play the death sound
        }

        if (movementScript !=null)
        {
            movementScript.enabled = false;
        }

        gameManager.Instance.DeclareWinner(opponentWinScene);
    }

}
