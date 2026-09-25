using UnityEngine;
using UnityEngine.SceneManagement;
public class buttonManager : MonoBehaviour
{
    public string gameplaySceneName = "playScene";
    public string mainMenuSceneName = "startScene";
    
    public void PlayAgain()
    {
        SceneManager.LoadScene(gameplaySceneName);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(mainMenuSceneName);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
