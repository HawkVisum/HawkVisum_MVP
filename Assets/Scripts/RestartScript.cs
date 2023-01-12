using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestartScript : MonoBehaviour
{
    [SerializeField] private string GoBack = "f 1";
    public void NewGameButton()
    {
        SceneManager.LoadScene(GoBack);
    }
}
