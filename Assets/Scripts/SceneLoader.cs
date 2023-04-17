using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void LoadStartingScene()
    {
        SceneManager.LoadScene(0);
    }


    public void doExitGame()
    {
        Application.Quit();
    }
}