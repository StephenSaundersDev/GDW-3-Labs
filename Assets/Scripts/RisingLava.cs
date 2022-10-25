using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RisingLava : MonoBehaviour
{
    public Transform playerRespawnPoint;
    public Transform startPoint;
    public int playerLives = 3;
    public PlayerBank livesBank;
    public GameObject gameOverScreen;


    private void Start()
    {
        if (livesBank == null)
        {
            livesBank = GameObject.FindGameObjectWithTag("Lives").GetComponent<PlayerBank>();
        }

        livesBank.balance = playerLives;
    }

    void Update()
    {
        transform.Translate(Vector3.up * 0.5f * Time.deltaTime);
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            if (playerLives > 1)
            {
                Debug.Log("You died!");
                playerLives--;
                livesBank.balance = playerLives;

                //Reset the player and the lava. Coins stay removed.
                col.transform.position = playerRespawnPoint.position;
                transform.position = startPoint.position;
            }
            else
            {
                Debug.Log("Game Over!");
                gameOverScreen.SetActive(true);
                Time.timeScale = 0; //Effectively pauses the game (UI only works on dynamic updates)

            }
        }
    }
}
