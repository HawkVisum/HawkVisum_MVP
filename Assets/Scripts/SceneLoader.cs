using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void LoadStartingScene(string sceneName)
    {
        SceneManager.LoadScene(0);
    }


    public void doExitGame()
    {
        Application.Quit();
    }
}