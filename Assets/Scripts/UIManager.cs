﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI txtMoney;
    public TextMeshProUGUI txtHealth;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void UpdateMoneyText(string moneyAmount)
    {
        txtMoney.text = "$" + moneyAmount;
    }

    public void UpdateHealthText(string healthPoints)
    {
        txtHealth.text = healthPoints;
    }

}
