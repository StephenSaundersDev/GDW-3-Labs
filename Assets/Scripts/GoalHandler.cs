using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalHandler : MonoBehaviour
{
    public GameObject loadingScreen;

    private void Start()
    {
        if (loadingScreen == null)
            loadingScreen = GameObject.FindGameObjectWithTag("LoadingPanel");
        
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            Debug.Log("You win!");
            loadingScreen.SetActive(true);
            SceneManager.LoadScene(0, LoadSceneMode.Single);
        }
    }
}
