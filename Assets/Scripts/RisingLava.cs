using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RisingLava : MonoBehaviour
{
    public Transform playerRespawnPoint;
    public Transform startPoint;

    void Update()
    {
        transform.Translate(Vector3.up * 0.5f * Time.deltaTime);
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            Debug.Log("You died!");
            col.transform.position = playerRespawnPoint.position;
            transform.position = startPoint.position;
        }
    }
}
