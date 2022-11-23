using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{

    public int currencyValue = 1;

    public PlayerBank bank;

    public AudioSource collectSoundEffect;

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
            //Debug.Log("Collected a coin!");
            collectSoundEffect.Play();
            bank.balance += currencyValue;
            
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            gameObject.GetComponent<MeshCollider>().enabled = false;
            transform.GetChild(0).gameObject.SetActive(false);
            transform.GetChild(1).gameObject.SetActive(false);

            Destroy(gameObject, 2.5f);
        }
    }
}
