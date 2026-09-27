using UnityEngine;

public class health_code : MonoBehaviour
{
    public int maxhealth = 5;
    public int currentHealth;
    public HeartsUI_code heartsUI;
    public string opponentWinScene;
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
            // Load the opponent win scene
            UnityEngine.SceneManagement.SceneManager.LoadScene(opponentWinScene);
        }
    }

}
