﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private int health = 30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Stala"))
        {
            health -= 1;
            print(health);
        }
    }

    //private void OnCollisionStay2D(Collision2D collision)
    //{
    //    health -= 1;
    //}
}
