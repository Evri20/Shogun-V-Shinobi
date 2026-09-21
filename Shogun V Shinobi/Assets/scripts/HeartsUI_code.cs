using UnityEngine;

public class HeartsUI_code : MonoBehaviour
{
    public GameObject[] hearts; // drag 5 heart sprites in order in the inspector
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateHearts(int currentHealth)
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            hearts[i].SetActive(i < currentHealth);
        }

    }
}