using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System.Collections;

public class gameManager : MonoBehaviour
{
    public static gameManager Instance;
    public TextMeshProUGUI countdownText;
    public int countdownFrom = 3;
    
    void Awake()
    {
        Instance = this;
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = 0f; // freeze everything
        StartCoroutine(CountdownCoroutine());
    }

    IEnumerator CountdownCoroutine()
    {
        int count = countdownFrom;

        while (count > 0)
        {
            countdownText.text = count.ToString();  
            yield return new WaitForSecondsRealtime(1f);
            count--; 
        }
        countdownText.text = "Fight!";
        yield return new WaitForSecondsRealtime(0.5f);
        countdownText.gameObject.SetActive(false);
        Time.timeScale = 1f; // unfreeze everything
    }

    public void DeclareWinner(string winSceneName)
    {
        Time.timeScale = 1f; // Ensure time scale is reset before loading the scene
        StartCoroutine(DeclareWinScene(winSceneName));
    }
    IEnumerator DeclareWinScene(string winSceneName)
    {
        yield return new WaitForSecondsRealtime(3f); // Wait for 3 seconds before loading the win scene
        SceneManager.LoadScene(winSceneName);
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
