using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public void LoadNextScene()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        int nextScene = currentScene + 1;
        
        if(nextScene > SceneManager.sceneCountInBuildSettings - 1)
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene(0);
        }
        Time.timeScale = 1f;
        SceneManager.LoadScene(nextScene);
    }    

    public void LoadSpecificScene(int buildIndex)
    {
        //likely to remain unused
        Time.timeScale = 1f;
        SceneManager.LoadScene(buildIndex);
    }

    public void ReturnToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }

    public void ReloadScene()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;

        Time.timeScale = 1f;
        SceneManager.LoadScene(currentScene);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
