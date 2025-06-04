using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeteccionColisiones : MonoBehaviour
{
    public int precio;
    public MoneyManager moneyManager;

    void Start()
    {
        moneyManager = FindObjectOfType<MoneyManager>();
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name == "player")
        {
            bool leAlcanza = moneyManager.UpdateMoney(-precio);
            if (leAlcanza)
            {
                Destroy(gameObject);
            }
        }
    }
}
