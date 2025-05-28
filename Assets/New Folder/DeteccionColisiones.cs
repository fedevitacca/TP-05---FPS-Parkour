using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeteccionColisiones : MonoBehaviour
{
    public int precio;

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name == "player")
        {
            Destroy(gameObject);
        }
    }
}
