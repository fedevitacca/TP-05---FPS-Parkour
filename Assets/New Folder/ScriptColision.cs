﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptColision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Contacto con " + collision.gameObject.name);
        Destroy(collision.gameObject);
    }
}
