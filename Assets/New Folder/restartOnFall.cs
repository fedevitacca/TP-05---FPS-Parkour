﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartOnFall : MonoBehaviour
{

    public float yFallHeight;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y + 20 < yFallHeight)
        {
            Debug.Log("Me caí");
            SceneManager.LoadScene("TP 05 - FPS Parkour");

        }
    }
}
