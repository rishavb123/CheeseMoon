﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switchto3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
            UnityEngine.SceneManagement.SceneManager.LoadScene("Scene3");
    }
}
