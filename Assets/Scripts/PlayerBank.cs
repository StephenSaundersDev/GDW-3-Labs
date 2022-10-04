using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerBank : MonoBehaviour
{
    public int balance = 0;

    public TextMeshProUGUI balanceText;

    private void Update()
    {
        Debug.Log(balance);
        balanceText.text = "" + balance;
    }
}
