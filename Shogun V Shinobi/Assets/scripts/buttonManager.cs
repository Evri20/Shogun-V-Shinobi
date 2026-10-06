using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
public class buttonManager : MonoBehaviour
{
    public string gameplaySceneName = "playScene";
    public string mainMenuSceneName = "startScene";
    
    public AudioSource audioSource;          // reference to the AudioSource component
    public AudioClip buttonClickSound; // Sound to play when a button is clicked
    
    public void PlayAgain()
    {
        StartCoroutine(PlaySoundThenLoad(gameplaySceneName));
    }

    public void MainMenu()
    {
        StartCoroutine(PlaySoundThenLoad(mainMenuSceneName));
    }

    public void QuitGame()
    {
        if (audioSource != null && buttonClickSound != null)
        {
            audioSource.PlayOneShot(buttonClickSound); // Play the button click sound
        }
        Application.Quit();
    }

    IEnumerator PlaySoundThenLoad(string sceneName)
    {
        if (audioSource != null && buttonClickSound != null)
        {
            audioSource.PlayOneShot(buttonClickSound); // Play the button click sound
            yield return new WaitForSeconds(buttonClickSound.length); // Wait for the sound to finish
        }
        SceneManager.LoadScene(sceneName);
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
