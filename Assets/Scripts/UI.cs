using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UI : MonoBehaviour
{
    public GameObject logoPanel;
    public GameObject menuPanel;
    public GameObject secondIntro;

    private void Start()
    {
        StartCoroutine(StartingScreen());
    }

    IEnumerator StartingScreen()
    {
        logoPanel.SetActive(true); 
        menuPanel.SetActive(false);

        yield return new WaitForSeconds(3);

        logoPanel.SetActive(false);
        menuPanel.SetActive(true);
        secondIntro.SetActive(true);

    }

    public void End()
    {
        Application.Quit();
    }

    public void Cessna172()
    {
        SceneManager.LoadScene("f 2");
    }
    public void ComingSoon()
    {
        SceneManager.LoadScene("Scene 3");
    }
}
