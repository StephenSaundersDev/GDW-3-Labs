using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalHandler : MonoBehaviour
{
    GameObject loadingScreen;

    private void Start()
    {
        if (loadingScreen == null)
            loadingScreen = GameObject.FindGameObjectWithTag("LoadingPanel").transform.GetChild(0).gameObject;
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
