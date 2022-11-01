using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuHandler : MonoBehaviour
{
    public void StartButtonPressed()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }

    public void ExitButtonPressed()
    {
        Application.Quit();
    }

    public void ReturnToMenuPressed()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }

    public void MagnifyPressed()
    {
        SceneManager.LoadScene(2, LoadSceneMode.Single);
    }
}
