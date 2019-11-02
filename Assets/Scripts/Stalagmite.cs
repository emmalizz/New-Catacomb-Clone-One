using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stalagmite : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionStay2D(Collision2D collision)
    { 
        if (collision.collider.CompareTag("Player"))
        {
            print("ouchie!"); //this will be replaced with health decrements once health is implemented
        }
    }
}
