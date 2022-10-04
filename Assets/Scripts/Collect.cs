using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{

    public int currencyValue = 1;

    public PlayerBank bank;

    private void Start()
    {
        if (bank == null)
        {
            bank = GameObject.FindGameObjectWithTag("Bank").GetComponent<PlayerBank>();
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            Debug.Log("Collected a coin!");
            bank.balance += currencyValue;
            
            Destroy(gameObject);
        }
    }
}
